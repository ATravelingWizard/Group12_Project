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
        string constr = @"Data Source=LAPTOP-291EM4C8;Initial Catalog = Skyfall; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter adap;
        DataSet ds;
        SqlDataReader read;

        private int flight_number;

        private void gbxInfo_Enter(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSeatsAvail.Text = "";
            txtTotalBaggage.Text = "";
            lbxConfirm.Items.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Double.Parse(txtTotalBaggage.Text) > 1200.00 || txtTotalBaggage.Text == null)
            {
                MessageBox.Show("Please enter a value smaller than 1200KG for baggage");
            }
            else if(Int32.Parse(txtSeatsAvail.Text) > 200 || Int32.Parse(txtSeatsAvail.Text) < 50)
            {
                MessageBox.Show("Please enter a value between 50 and 200 for seats available");
            }
            else if (dateArrival.Value < dateDeparture.Value)
            {
                MessageBox.Show("Please enter an Arrival Date after the Departure Date");
            }
            else
            {
                lbxConfirm.Items.Add("===========Flight Information=========");
                lbxConfirm.Items.Add("Flight ID: " + lblFlightOut.Text);
                lbxConfirm.Items.Add("Total Baggage (KG): " + txtSeatsAvail.Text);
                lbxConfirm.Items.Add("Total Seats Available: " + txtTotalBaggage.Text);
                lbxConfirm.Items.Add("Departure Time & Date: " + dateDeparture.Value.ToString());
                lbxConfirm.Items.Add("Arrival Time & Date: " + dateArrival.Value.ToString());
                lbxConfirm.Items.Add("Destination ID: " + cbxDestination.ToString());

                btnConfirm.Enabled = true;
            }
        }

        private void gbxConfirm_Enter(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            adap = new SqlDataAdapter();
            string add = $"INSERT INTO Flight VALUES('{lblFlightOut.Text}', '{cbxDestination.Text}', '{dateDeparture.Value}', '{dateArrival.Value}', '{Double.Parse(txtTotalBaggage.Text)}', '{Double.Parse(txtSeatsAvail.Text)}')";

            conn.Open();

            comm = new SqlCommand(add, conn);

            adap.InsertCommand = comm;
            adap.InsertCommand.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Flight " + lblFlightID.Text + " added successfully!");
        }

        private void Add_flight_Load(object sender, EventArgs e)
        {
            btnConfirm.Enabled = false;
            //connection to the database
            try
            {
                conn = new SqlConnection(constr);

                conn.Open();

                string sql_query = "SELECT DISTINCT Destination_ID FROM Destinations";
                adap = new SqlDataAdapter(sql_query, conn);

                ds = new DataSet();
                adap.Fill(ds, "Destinations");

                cbxDestination.DisplayMember = "Destination_ID";
                cbxDestination.DataSource = ds.Tables["Destinations"];

                conn.Close();

                Random rand = new Random();
                flight_number = rand.Next(1, 200);

                lblFlightOut.Text = "Flight: " + GetFlightLetter() + GetFlightLetter() + flight_number.ToString();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
        public static char GetFlightLetter()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random rand = new Random();
            int num = rand.Next(0, chars.Length);
            return chars[num];
        }
    }
}
