using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;

namespace Session2
{
    public partial class ImportForm : Form
    {
        DataClass myClass = new DataClass();
        DataGridView dataGridView2 = new DataGridView();

        public ImportForm()
        {
            InitializeComponent();
        }

        private void ImportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.OpenForms["ManageForm"].Show();
        }

        void getDataFromExcel()
        {
            string str;
            int rCnt;
            int cCnt;

            try
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Excel (*.CSV)|*.CSV";
                opf.ShowDialog();
                System.Data.DataTable tb = new System.Data.DataTable();
                string filename = opf.FileName;
                tbFileName.Text = filename;

                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook ExcelWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
                Microsoft.Office.Interop.Excel.Range ExcelRange;

                ExcelWorkBook = ExcelApp.Workbooks.Open(filename, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false,
                    false, 0, true, 1, 0);
                ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

                ExcelRange = ExcelWorkSheet.UsedRange;
                dataGridView2.AllowUserToAddRows = false;
                dataGridView2.Columns.Add("Test", "Test");
                dataGridView2.Columns.Add("Test2", "Test2");
                dataGridView2.Columns[1].Visible = false;
                for (rCnt = 1; rCnt <= ExcelRange.Rows.Count; rCnt++)
                {
                    dataGridView2.Rows.Add(1);
                    for (cCnt = 1; cCnt <= 2; cCnt++)
                    {
                        str = (string)(ExcelRange.Cells[rCnt, cCnt] as Microsoft.Office.Interop.Excel.Range).Value2;
                        dataGridView2.Rows[rCnt - 1].Cells[cCnt - 1].Value = str;
                    }
                }
                ExcelWorkBook.Close(true, null, null);
                ExcelApp.Quit();

                releaseObject(ExcelWorkSheet);
                releaseObject(ExcelWorkBook);
                releaseObject(ExcelApp);
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getDataFromExcel();
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
