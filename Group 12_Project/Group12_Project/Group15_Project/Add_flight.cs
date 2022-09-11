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
    public partial class Add_flight : Form
    {
        public Add_flight()
        {
            InitializeComponent();
        }

        // varuables to be used for acessing the databases
        string constr = @"Data Source=DESKTOP-73JV06H;Initial Catalog=Flight database;Integrated Security=True";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter adap;
        DataSet ds;
        SqlDataReader read;
        public int destinationid;



        private void gbxInfo_Enter(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            numBaggage.Value = 0;
            numSeats.Value = 0;
            lbxConfirm.Items.Clear();
        }


        public void refreshin()
        {
            try
            {

                conn.Open();

                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT * FROM Destinations ";

                comm = new SqlCommand(sql, conn);
                read = comm.ExecuteReader();

                while (read.Read())
                {
                    cbxDestination.Items.Add(read.GetValue(0));

                }


                conn.Close();


         



            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lbxConfirm.Items.Add("===========Flight Information=========");
            lbxConfirm.Items.Add("Flight ID: " + lblFlightOut.Text);
            lbxConfirm.Items.Add("Total Baggage (KG): " + numBaggage.Value.ToString());
            lbxConfirm.Items.Add("Departure Time & Date: " + dateDeparture.Value.ToString());
            lbxConfirm.Items.Add("Arrival Time & Date: " + dateArrival.Value.ToString());
            lbxConfirm.Items.Add("Destination ID: " + cbxDestination.ToString());
        }

        private void gbxConfirm_Enter(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            


            //values sent second to the passenger table because it needs the baggage and seat code first otherwise an error will occur
            try
            {
                conn.Open();
                string sql = $"INSERT INTO Baggage VALUES('{numBaggage.Text}' ) ";

                SqlDataAdapter adap = new SqlDataAdapter();
                comm = new SqlCommand(sql, conn);
                adap.InsertCommand = comm;
                adap.InsertCommand.ExecuteNonQuery();

                conn.Close();
                // MessageBox.Show("Data sucessfully inserted");

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            //Gets the PK of baggage and seat
            refreshin();



            //values sent last to the passenger table because it needs the baggage and seat code first otherwise an error will occur
            try
            {
                conn.Open();
                string sql = $"INSERT INTO Passenger VALUES('{destinationid}','{dateDeparture.Text}' ,'{dateArrival.Text}','{numBaggage.Text}','{numSeats.Text}') ";


                SqlDataAdapter adap = new SqlDataAdapter();
                comm = new SqlCommand(sql, conn);
                adap.InsertCommand = comm;
                adap.InsertCommand.ExecuteNonQuery();

                conn.Close();
                // MessageBox.Show("Data sucessfully inserted");

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }


            btnSubmit.Enabled = true;
            lbxConfirm.Items.Clear();
        }

        private void Add_flight_Load(object sender, EventArgs e)
        {
            //connection to the database
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
        }
    }
}
