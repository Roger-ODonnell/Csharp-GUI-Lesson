using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Drawing;

namespace CarsDatabase
{
    public partial class Form1 : Form
    {

        SQLiteConnection databaseConnection = new SQLiteConnection(@"data source= hire.db");

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            recordCounter("first");
            getData();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            recordCounter("previous");
            getData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            recordCounter("next");
            getData();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            recordCounter("last");
            getData();
        }

        int recordControlNo = 1;
        int totalRecords;

        public void recTotal()
        {
            string findTotal = "@SELECT COUNT(*) FROM tblCar";

            databaseConnection.Open();
            var command = databaseConnection.CreateCommand();
            command.CommandText = findTotal;
            using(var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var total = reader.GetInt32(0);
                    totalRecords = total;
                }
                recordCount.Text = $"{recordControlNo} of {totalRecords}";
                databaseConnection.Close();
            }
        }

        public void recordCounter(string frmBtn)
        {
            if (frmBtn == "next")
            {
                if (recordControlNo < totalRecords)
                {
                    recordControlNo += 1;
                }
            }

            if (frmBtn == "previous")
            {
                if (recordControlNo > 1)
                {
                    recordControlNo -= 1;
                }
            }

            if (frmBtn == "first")
            {
                recordControlNo = 1;
            }

            if (frmBtn == "last")
            {
                recordControlNo = totalRecords;
            }

            recordCount.Text = $"{recordControlNo} of {totalRecords}";
        }

        private void recordCount_TextChanged(object sender, EventArgs e)
        {
            recordCount.Text = $"{recordControlNo} of {totalRecords}";
        }

        private void frmCars_Load(object sender, EventArgs e)
        {
            try
            {
                recTotal();
                getData();
            }
            catch (Exception)
            {
                MessageBox.Show("Cant load database, check database connection!");
            }
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;
        }

        Details details = new Details();

        public void getData()
        {
            int rowPosition = recordControlNo - 1;

            try
            {
                databaseConnection.Open();
                string getDB = $@"SELECT * FROM(SELECT * tblCar LIMIT 1 OFFSET {rowPosition}";
                SQLiteCommand cmd = new SQLiteCommand(getDB, databaseConnection);
                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);

                //frmDataGrid.DataSource = dt;
                databaseConnection.Close();

                vehicleRegInput.Text = Convert.ToString(dt.Rows[0].ItemArray[1]);
                vehicleMakeInput.Text = Convert.ToString(dt.Rows[0].ItemArray[2]);
                vehicleEngineInput.Text = Convert.ToString(dt.Rows[0].ItemArray[3]);
                dateRegInput.Text = Convert.ToString(dt.Rows[0].ItemArray[4]);
                rentPerDayInput.Text = Convert.ToString(dt.Rows[0].ItemArray[5]);
                int available = Convert.ToInt32(dt.Rows[0].ItemArray[5]);
                if (available == 1)
                {
                    availCheck.Checked = true;
                }
                else
                {
                    availCheck.Checked = false;
                }

                btnUpdate.Enabled = false;
                btnCancel.Enabled = false;

                details.VehicleReg = vehicleRegInput.Text;
                details.Make = vehicleMakeInput.Text;
                details.Engine = vehicleEngineInput.Text;
                details.DateReg = dateRegInput.Text;
                details.RentalPerDay = rentPerDayInput.Text;
                details.Available = available;
            }
            catch (Exception)
            {
                MessageBox.Show("cannto find data");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch searchForm = new frmSearch();
            searchForm.ShowDialog();
        }

        private void vehicleRegInput_TextChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            btnCancel.Enabled = false;
        }

        private int availability;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd openAddForm = new frmAdd();
            this.Hide();
            openAddForm.ShowDialog();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult toUpdate = MessageBox.Show("Are you sure youd like to update this record", "",MessageBoxButtons.YesNo);
            if (toUpdate == DialogResult.Yes)
            {
                //updateRecord();
                MessageBox.Show("Record updated");
            }
            else if (toUpdate == DialogResult.No)
            {
                MessageBox.Show("No record has been deleted");
            }
            vehicleMakeInput.BackColor = Color.White;
            vehicleEngineInput.BackColor = Color.White;
            dateRegInput.BackColor = Color.White;
            availCheck.BackColor = Color.White;
            rentPerDayInput.BackColor = Color.White;
        }

        private void vehicleMakeInput_TextChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult toDelete = MessageBox.Show($"Are you sure youd like to delete this record\nVehicle Registration: {details.VehicleReg}\nMake: {details.Make}\nEngine Size: {details.Engine}\nDate Registered: {details.DateReg}\nRental Per Day: {details.RentalPerDay}\nAvailble: ", "", MessageBoxButtons.YesNo);
            if (toDelete == DialogResult.Yes)
            {
                deleteData();
                MessageBox.Show("Record deleted");
            }
            else if (toDelete == DialogResult.No)
            {
                MessageBox.Show("No record has been delted");
            }
        }

        private void deleteData()
        {
            try
            {
                string deleteARecord = $@"DELETE FROM tblCAR WHERE vehicleRegNo = '{vehicleRegInput}'";

                databaseConnection.Open();
                string sendData2 = deleteARecord;
                SQLiteCommand deleteSQL = new SQLiteCommand(databaseConnection);
                deleteSQL.CommandText = sendData2;
                deleteSQL.ExecuteNonQuery();
                databaseConnection.Close();
                recTotal();
                recordCounter("last");
                getData();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot delete data");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            getData();
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;
            vehicleMakeInput.BackColor  = Color.White;
            vehicleEngineInput.BackColor= Color.White;
            dateRegInput.BackColor = Color.White;
            availCheck.BackColor = Color.White;
            rentPerDayInput.BackColor = Color.White;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }//End of class
}
