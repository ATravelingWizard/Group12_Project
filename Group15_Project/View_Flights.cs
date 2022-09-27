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

namespace Group15_Project
{
    public partial class frmView_Flights : Form
    {
        public frmView_Flights()
        {
            InitializeComponent();
        }

        // variables to be used for acessing the databases
        string constr = @"Data Source=.;Initial Catalog = Skyfall; Integrated Security = True";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter adap;
        DataSet ds;
        SqlDataReader read;
        public int destinationid;

        private void frmView_Flights_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(constr);

                conn.Open();
                conn.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            refreshin();
            conn.Open();

            adap = new SqlDataAdapter();
            ds = new DataSet();

            string bsql = "SELECT DISTINCT Destination_Name FROM Destinations ";

            comm = new SqlCommand(bsql, conn);
            read = comm.ExecuteReader();

            while (read.Read())
            {
                cbxDestination.Items.Add(  read.GetValue(0));

            }


            conn.Close();
        }

        public void refreshin()
        {
            try
            {

                conn.Open();

                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT * FROM Flight ";

                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "Flight");

                dgwFlights.DataSource = ds;
                dgwFlights.DataMember = "Flight";

                conn.Close();


            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void dgwFlights_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //TEXT WAS NOT VISIBLE SO I CHANGED THE CELL COLOUR you can change the colour here if you want
            e.CellStyle.BackColor = Color.DimGray;
        }

        private void txtFlightNum_TextChanged(object sender, EventArgs e)
        {
            

            //filters flights code
            try
            {

                conn.Open();

                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = $"SELECT * FROM Flight WHERE Flight_Code = '{txtFlightNum.Text}'";

                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "Flight");

                dgwFlights.DataSource = ds;
                dgwFlights.DataMember = "Flight";

                conn.Close();


            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

           
        }

        private void cbxDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                conn.Open();

                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = $"SELECT * FROM Flight WHERE Destination_ID = '{cbxDestination.SelectedItem.ToString()}' ";

                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "Flight");

                dgwFlights.DataSource = ds;
                dgwFlights.DataMember = "Flight";

                conn.Close();


            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void numBaggage_ValueChanged(object sender, EventArgs e)
        {

            try
            {

                conn.Open();

                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = $"SELECT * FROM Flight WHERE Total_Baggage_Weight = '{numBaggage.Text}' ";

                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "Flight");

                dgwFlights.DataSource = ds;
                dgwFlights.DataMember = "Flight";

                conn.Close();


            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                conn.Open();

                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = $"SELECT * FROM Flight WHERE Seats_Available = '{numericUpDown1.Text}' ";

                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "Flight");

                dgwFlights.DataSource = ds;
                dgwFlights.DataMember = "Flight";

                conn.Close();


            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void dtpDepart_ValueChanged(object sender, EventArgs e)
        {


            //Cant figure out how to filter using the database format date time format
            try
            {

                conn.Open();

                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = $"SELECT * FROM Flight WHERE Departure_Time&Date LIKE '{dtpDepart.Format}' ";

                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "Flight");

                dgwFlights.DataSource = ds;
                dgwFlights.DataMember = "Flight";

                conn.Close();


            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void dtpArrival_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Output output = new Output();
            output.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgwFlights.SelectedRows.Count > 0)
            {
                Edit_Flights edit_Flights = new Edit_Flights();
                edit_Flights.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a flight to edit");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgwFlights.SelectedRows)
            {
                dgwFlights.Rows.Remove(row);
            }
        }
    }
}
