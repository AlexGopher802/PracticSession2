using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session2
{
    public partial class EditForm : Form
    {
        DataClass myClass = new DataClass();
        public int idFlight = 0;
        public EditForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ManageForm manageForm = (ManageForm)Application.OpenForms["ManageForm"];
            manageForm.viewDataSchedules();
            manageForm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if((mtbTime.Text == "") || (tbPrice.Text == "")) { return; }
            myClass.executeQuery($"update Schedules set date='{dtpDate.Value.ToString("yyyy-MM-dd")}', time='{mtbTime.Text}', EconomyPrice={tbPrice.Text} where id={idFlight}");
            this.Close();
        }
    }
}
