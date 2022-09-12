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
    public partial class frmAdd_New : Form
    {
        public frmAdd_New()
        {
            InitializeComponent();
        }

        // varuables to be used for acessing the databases
        string constr = @"Data Source=LAPTOP-291EM4C8;Initial Catalog=Skyfall;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter adap;
        DataSet ds;
        SqlDataReader read;

        public int seatcode;
        public int baggagecode;

        private void lblNum_Click(object sender, EventArgs e)
        {

        }

        private void frmAdd_New_Load(object sender, EventArgs e)
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

        public void refreshin()
        {
            try
            {

                conn.Open();

                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT * FROM Seat ";

                comm = new SqlCommand(sql, conn);
                read = comm.ExecuteReader();

                while(read.Read() )
                {
                    seatcode=(int)read.GetValue(0);

                }

                conn.Close();

                conn.Open();

                adap = new SqlDataAdapter();
                ds = new DataSet();

                string bsql = "SELECT * FROM Baggage ";

                comm = new SqlCommand(bsql, conn);
                read = comm.ExecuteReader();

                while (read.Read())
                {
                    baggagecode = (int)read.GetValue(0);
                }

                conn.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //intialising and declaring variables for seat assignment
        public string seatletter = "A";
        public int seatnumber=0;
        public string seatarrangement = "A3";


        //this method generates a seat arrangement 
        public void theSeat()
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // assigns a random number
            Random rand = new Random();
            seatnumber = rand.Next(1, 50);

            if (seatnumber < 20)
            {
                seatletter = "B";
            }
            else if (seatnumber < 30)
            {
                seatletter = "C";
            }
            else if (seatnumber < 40)
            {
                seatletter = "D";
            }
            else if (seatnumber < 45)
            {
                seatletter = "E";
            }
            else if (seatnumber < 50)
            {
                seatletter = "F";
            }

            //seat alignments created
            seatarrangement = seatnumber + seatletter;



            int flightno;
            // assigns a random number
            Random frand = new Random();
            flightno = frand.Next(1, 1000);


            //send values to listbox last
            lbxConfirm.Items.Add("=======Passenger Info=======");
            lbxConfirm.Items.Add("Name: " + txtName.Text);
            lbxConfirm.Items.Add("Surname: " + txtSurname.Text);
            lbxConfirm.Items.Add("Email: " + txtEmail.Text);
            lbxConfirm.Items.Add("=======Flight Info=======");
            lbxConfirm.Items.Add("Baggage Weight: " + numBaggage.Value.ToString() + " kg");
            lbxConfirm.Items.Add("Seat Number: " + seatarrangement);
            lbxConfirm.Items.Add("Flight Number: " + flightno.ToString());

            btnSubmit.Enabled = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New Passenger Has been added Successfully");

           //values sent to the seat table
            try
            {
                conn.Open();
                string sql = $"INSERT INTO Seat VALUES('{seatarrangement}' ) ";

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


            //values sent second to the passenger table because it needs the baggage and seat code first otherwise an error will occur
            try
            {
                conn.Open();
                string sql = $"INSERT INTO Baggage VALUES('{baggagecode}','{numBaggage.Value}' ) ";

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
                string sql = $"INSERT INTO Passengers VALUES('{baggagecode}','{seatcode}','{txtName.Text}' ,'{txtSurname.Text}','{txtEmail.Text}') ";


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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtSurname.Text = "";
            txtName.Text = "";

            lbxConfirm.Items.Clear();
            btnSubmit.Enabled = true;
        }

        private void numBaggage_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
