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
        public static string selected_flight;

        public static string flightID, dest;
        public static int seats;
        public static double baggage;

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

                string sql = $"SELECT * FROM Flight WHERE Flight_Code LIKE '%{txtFlightNum.Text}%' ";

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

                adap = new SqlDataAdapter();
                string destination = $"SELECT * FROM Destinations WHERE Destination_Name LIKE '" + cbxDestination.Text + "'";

                conn.Open();

                comm = new SqlCommand(destination, conn);
                ds = new DataSet();
                lblPlaceHolder.Text = Convert.ToString(comm.ExecuteScalar());

                conn.Close();



                conn.Open();

                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = $"SELECT * FROM Flight WHERE Destination_ID = '{lblPlaceHolder.Text}'";

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

                string sql = $"SELECT * FROM Flight WHERE Total_Baggage_Weight LIKE '%{numBaggage.Value}%' ";

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

                string sql = $"SELECT * FROM Flight WHERE Departure_Time LIKE '%{dtpDepart.Value}%' ";

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
            try
            {

                conn.Open();

                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = $"SELECT * FROM Flight WHERE Arrival_Time LIKE '%{dtpArrival.Value}%' ";

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

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (dgwFlights.SelectedCells.Count > 0)
            {
                selected_flight = dgwFlights.SelectedCells[0].Value.ToString() + "\t\t"
                    + dgwFlights.SelectedCells[1].Value.ToString() + "\t\t"
                    + dgwFlights.SelectedCells[2].Value.ToString() + "\t"
                    + dgwFlights.SelectedCells[3].Value.ToString() + "\t"
                    + dgwFlights.SelectedCells[4].Value.ToString() + "\t\t"
                    + dgwFlights.SelectedCells[5].Value.ToString();
            }
            Output output = new Output();
            output.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgwFlights.SelectedRows.Count > 0)
            {
                flightID = dgwFlights.SelectedCells[0].Value.ToString();
                seats = int.Parse(dgwFlights.SelectedCells[5].Value.ToString());
                baggage = double.Parse(dgwFlights.SelectedCells[4].Value.ToString());
                dest = dgwFlights.SelectedCells[1].Value.ToString();

                Edit_Flights edit_Flights = new Edit_Flights();
                edit_Flights.ShowDialog();

                refreshin();
            }
            else
            {
                MessageBox.Show("Please select a flight to edit");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwFlights.SelectedRows.Count > 0)
            {
                flightID = dgwFlights.SelectedCells[0].Value.ToString();

                conn.Open();

                string del = $"DELETE FROM Flight WHERE Flight_Code = '{flightID}'";

                comm = new SqlCommand(del, conn);
                comm.ExecuteNonQuery();

                conn.Close();

                refreshin();
            }
            else
            {
                MessageBox.Show("Unable to delete selected flight");
            }
        }
    }
}
