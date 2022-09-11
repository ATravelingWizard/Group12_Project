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
    public partial class frmView_Passengers : Form
    {
        public frmView_Passengers()
        {
            InitializeComponent();
        }

        // variables to be used for acessing the databases
        string constr = @"Data Source=DESKTOP-73JV06H;Initial Catalog=Flight database;Integrated Security=True";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter adap;
        DataSet ds;
        SqlDataReader read;
        public int destinationid;

        private void frmView_Passengers_Load(object sender, EventArgs e)
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
            
        }


        public void refreshin()
        {
            try
            {

                conn.Open();

                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT * FROM Passenger ";

                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "Passenger");

                dgwFlights.DataSource = ds;
                dgwFlights.DataMember = "Passenger";

                conn.Close();


            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void txtSearchCode_TextChanged(object sender, EventArgs e)
        {
            try
            {

                conn.Open();

                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = $"SELECT * FROM Passenger WHERE Passenger_Code = '{txtSearchCode.Text}' ";

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

        private void txtSearchBaggage_TextChanged(object sender, EventArgs e)
        {
            try
            {

                conn.Open();

                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = $"SELECT * FROM Passenger WHERE Baggage_Code = '{txtSearchBaggage.Text}' ";

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

        private void dgwFlights_CellStyleChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgwFlights_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.BackColor = Color.DimGray;

        }

        private void txtSearchEmail_TextChanged(object sender, EventArgs e)
        {
            try
            {

                conn.Open();

                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = $"SELECT * FROM Passenger WHERE Contact_Email LIKE '%{txtSearchEmail.Text}%' ";

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

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            try
            {

                conn.Open();

                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = $"SELECT * FROM Passenger WHERE First_name LIKE '%{txtSearchName.Text}%' ";

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

        private void txtSearchSurname_TextChanged(object sender, EventArgs e)
        {
            try
            {

                conn.Open();

                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = $"SELECT * FROM Passenger WHERE Last_Name LIKE '%{txtSearchSurname.Text}%' ";

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

        private void txtSearchSeatcode_TextChanged(object sender, EventArgs e)
        {
            try
            {

                conn.Open();

                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = $"SELECT * FROM Passenger WHERE Seat_Code = '{txtSearchSeatcode.Text}' ";

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Add delete functionality here, this should delete the selected entry.
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit_Passenger edit_Passenger = new Edit_Passenger();
            edit_Passenger.ShowDialog();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Output frmOut = new Output();
            frmOut.ShowDialog();
        }
    }
}
