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
    public partial class ManageForm : Form
    {
        DataClass myClass = new DataClass();
        string where = "";
        string sort = "order by Schedules.Date ";
        string desc = "";

        public ManageForm()
        {
            InitializeComponent();
        }

        private void ManageForm_Load(object sender, EventArgs e)
        {
            //Загружаем список аэропортов в комбобоксы
            List<string> listAirportsFrom = new List<string>() { "Not selected" };
            List<string> listAirportsTo = new List<string>() { "Not selected" };
            foreach (DataRow i in myClass.getData("select name from airports").Tables[0].Rows)
            {
                listAirportsFrom.Add(i.ItemArray[0].ToString());
                listAirportsTo.Add(i.ItemArray[0].ToString());
            }
            cbFrom.DataSource = listAirportsFrom;
            cbTo.DataSource = listAirportsTo;

            cbSort.SelectedIndex = 0;
            viewDataSchedules();
            
        }

        public void viewDataSchedules()
        {
            string query = "select " +
                "Schedules.Date as [Date], " +
                "Schedules.Time as [Time], " +
                "[AirportFrom].IATACode as [From], " +
                "[AirportTo].IATACode as [To], " +
                "Schedules.FlightNumber as [Flight Number], " +
                "Aircrafts.Name as [Plane Name], " +
                "Schedules.EconomyPrice as [Economy Price], " +
                "Schedules.EconomyPrice * 135 / 100 as [Business Price], " +
                "Schedules.EconomyPrice * 135 / 100 * 130 / 100 as [First Class Price], " +
                "Schedules.Confirmed as [Confirmed], " +
                "Schedules.ID as [ID] " +
                "from Schedules " +
                "left join [Routes] on Schedules.RouteID = [Routes].ID " +
                "left join Airports as [AirportFrom] on [Routes].DepartureAirportID = [AirportFrom].ID " +
                "left join Airports as [AirportTo] on [Routes].ArrivalAirportID = [AirportTo].ID " +
                "left join Aircrafts on Schedules.AircraftID = Aircrafts.ID " +
                $"where 1488=1488 {where} {sort}";
            dataGridSchedules.DataSource = myClass.getData(query).Tables[0];
            dataGridSchedules.Columns[9].Visible = false;
            dataGridSchedules.Columns[10].Visible = false;

            setColorRows();
        }

        void setColorRows()
        {
            foreach (DataGridViewRow i in dataGridSchedules.Rows)
            {
                if (!(bool)i.Cells["Confirmed"].Value)
                {
                    i.DefaultCellStyle.BackColor = Color.FromArgb(255, 0, 0);
                    i.DefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);
                }
            }
        }

        private void cbFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbTo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            dataSample();
        }

        void dataSample()
        {
            if (cbFrom.SelectedIndex != 0)
            {
                where += $"and [AirportFrom].IATACode = (select IATACode from Airports where Name='{cbFrom.SelectedItem}') ";
            }
            if (cbTo.SelectedIndex != 0)
            {
                where += $"and [AirportTo].IATACode = (select IATACode from Airports where Name='{cbTo.SelectedItem}') ";
            }
            if (checkBoxOut.Checked)
            {
                where += $"and Schedules.Date = '{dtpOutbound.Value.ToString("yyyy-MM-dd")}' ";
            }
            if (mtbFlyNumber.Text != "")
            {
                where += $"and Schedules.FlightNumber = '{mtbFlyNumber.Text}' ";
            }


            viewDataSchedules();
            where = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dtpOutbound.Enabled = checkBoxOut.Checked;
        }

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataSorting();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

            dataSorting();
        }

        void dataSorting()
        {
            if (checkBoxReverse.Checked)
            {
                desc = "desc ";
            }
            else
            {
                desc = "";
            }

            if (cbSort.SelectedIndex == 0)
            {
                sort = $"order by Schedules.Date {desc}";
            }
            if (cbSort.SelectedIndex == 1)
            {
                sort = $"order by Schedules.EconomyPrice {desc}";
            }
            if (cbSort.SelectedIndex == 2)
            {
                sort = $"order by Schedules.Confirmed {desc}";
            }
            viewDataSchedules();
        }

        private void btnCancelFly_Click(object sender, EventArgs e)
        {
            if ((bool)dataGridSchedules.SelectedRows[0].Cells["Confirmed"].Value)
            {
                myClass.executeQuery($"update Schedules set Confirmed = 0 where id = {dataGridSchedules.SelectedRows[0].Cells["ID"].Value}");
            }
            else
            {
                myClass.executeQuery($"update Schedules set Confirmed = 1 where id = {dataGridSchedules.SelectedRows[0].Cells["ID"].Value}");
            }
            dataSample();
        }

        private void btnEditFly_Click(object sender, EventArgs e)
        {
            if(dataGridSchedules.SelectedRows.Count != 0)
            {
                this.Hide();
                EditForm editForm = new EditForm();
                editForm.idFlight = (int)dataGridSchedules.SelectedRows[0].Cells["ID"].Value;
                editForm.lblFrom.Text = $"From: {dataGridSchedules.SelectedRows[0].Cells["From"].Value}";
                editForm.lblTo.Text = $"To: {dataGridSchedules.SelectedRows[0].Cells["To"].Value}";
                editForm.lblAir.Text = $"Aircraft: {dataGridSchedules.SelectedRows[0].Cells["Plane Name"].Value}";
                editForm.dtpDate.Value = DateTime.Parse(dataGridSchedules.SelectedRows[0].Cells["Date"].Value.ToString());
                editForm.mtbTime.Text = dataGridSchedules.SelectedRows[0].Cells["Time"].Value.ToString();
                editForm.tbPrice.Text = dataGridSchedules.SelectedRows[0].Cells["Economy Price"].Value.ToString();
                editForm.Show();
            }
        }

        private void btnImportChanges_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ImportForm().Show();
        }

        
    }
}
