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
        string constr = @"Data Source=.;Initial Catalog = Skyfall; Integrated Security = True";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter adap;
        DataSet ds;
        SqlDataReader read;
        public int destinationid;

        public static string name, surname, email, bagID;
        public static double bag;

        public static string selected_passagenger;


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

                string sql = "SELECT * FROM Passengers ";

                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "Passengers");

                dgwPassengers.DataSource = ds;
                dgwPassengers.DataMember = "Passengers";

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

                string sql = $"SELECT * FROM Passengers WHERE Passenger_Code LIKE '%{txtSearchCode.Text}%' ";

                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "Passengers");

                dgwPassengers.DataSource = ds;
                dgwPassengers.DataMember = "Passengers";

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

                string sql = $"SELECT * FROM Passengers WHERE Baggage_Code LIKE '%{txtSearchBaggage.Text}%'";

                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "Passengers");

                dgwPassengers.DataSource = ds;
                dgwPassengers.DataMember = "Passengers";

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

                string sql = $"SELECT * FROM Passengers WHERE Contact_Email LIKE '%{txtSearchEmail.Text}%' ";

                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "Passengers");

                dgwPassengers.DataSource = ds;
                dgwPassengers.DataMember = "Passengers";

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

                string sql = $"SELECT * FROM Passengers WHERE First_Name LIKE '%{txtSearchName.Text}%' ";

                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "Passengers");

                dgwPassengers.DataSource = ds;
                dgwPassengers.DataMember = "Passengers";

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

                string sql = $"SELECT * FROM Passengers WHERE Last_Name LIKE '%{txtSearchSurname.Text}%' ";

                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "Passengers");

                dgwPassengers.DataSource = ds;
                dgwPassengers.DataMember = "Passengers";

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

                string sql = $"SELECT * FROM Passengers WHERE Seat_Code LIKE '%{txtSearchSeatcode.Text}%'";

                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "Passengers");

                dgwPassengers.DataSource = ds;
                dgwPassengers.DataMember = "Passengers";

                conn.Close();


            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgwPassengers.SelectedRows)
            {
                dgwPassengers.Rows.Remove(row);
            }
                
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgwPassengers.SelectedRows.Count > 0)
            { 
                name = dgwPassengers.SelectedCells[3].Value.ToString();
                surname = dgwPassengers.SelectedCells[4].Value.ToString();
                email = dgwPassengers.SelectedCells[5].Value.ToString();
                bagID = dgwPassengers.SelectedCells[1].Value.ToString();

                conn.Open();

                string sql = $"SELECT Weight FROM Baggage WHERE Baggage_Code = '{dgwPassengers.SelectedCells[1].Value.ToString()}'";

                comm = new SqlCommand(sql, conn);
                bag = Convert.ToDouble(comm.ExecuteScalar());

                conn.Close();

                Edit_Passenger edit_Passenger = new Edit_Passenger();
                edit_Passenger.ShowDialog();

                refreshin();
            }
            else
            {
                MessageBox.Show("Please select a passenger to edit");
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if(dgwPassengers.SelectedCells.Count > 0)
            {
                selected_passagenger = dgwPassengers.SelectedCells[0].Value.ToString() + "\t"
                    + dgwPassengers.SelectedCells[1].Value.ToString() + "\t"
                    + dgwPassengers.SelectedCells[2].Value.ToString() + "\t"
                    + dgwPassengers.SelectedCells[3].Value.ToString() + "\t\t"
                    + dgwPassengers.SelectedCells[4].Value.ToString() + "\t\t"
                    + dgwPassengers.SelectedCells[5].Value.ToString();
            }
            Output frmOut = new Output();
            frmOut.ShowDialog();

        }

        private void dgwFlights_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
