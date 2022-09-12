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

        public string seatCode, baggageCode, seatNum, passengerCode;

        private void lblNum_Click(object sender, EventArgs e)
        {

        }

        private void frmAdd_New_Load(object sender, EventArgs e)
        {
            btnConfirm.Enabled = false;
            try
            {
                conn = new SqlConnection(constr);
                conn.Open();
                conn.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //this method generates a seat arrangement 
        public void theSeat()
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
          
            Random rnd = new Random();
            seatCode = txtName.Text + rnd.Next(2000, 3000).ToString();
            baggageCode = txtName.Text + rnd.Next(8000, 9000).ToString();
            seatNum = rnd.Next(1, 11).ToString();
            passengerCode = txtSurname.Text + rnd.Next(1000, 3000).ToString();

            if(Double.Parse(txtBaggageWeight.Text) > 25.00)
            {
                MessageBox.Show("Enter a value smaller than 25KG");
            }
            else
            {
                //send values to listbox last
                lbxConfirm.Items.Add("=======Passenger Info=======");
                lbxConfirm.Items.Add("Name: " + txtName.Text);
                lbxConfirm.Items.Add("Surname: " + txtSurname.Text);
                lbxConfirm.Items.Add("Email: " + txtEmail.Text);
                lbxConfirm.Items.Add("=======Flight Info=======");
                lbxConfirm.Items.Add("Baggage Weight: " + txtBaggageWeight.Text + " kg");
                lbxConfirm.Items.Add("Seat Number: " + seatCode);
                lbxConfirm.Items.Add("Flight Number: " + baggageCode);

                btnConfirm.Enabled = true;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                adap = new SqlDataAdapter();

                string add_baggage = $"INSERT INTO Baggage VALUES ('{baggageCode}', '{Double.Parse(txtBaggageWeight.Text)}')";
                string add_seat = $"INSERT INTO Seat VALUES ('{seatCode}', '{seatNum}')";
                string add_passenger = $"INSERT INTO Passengers VALUES('{passengerCode}','{baggageCode}','{seatCode}','{txtName.Text}', '{txtSurname.Text}', '{txtEmail.Text}')";
                
                conn.Open();

                comm = new SqlCommand(add_baggage, conn);
                adap.InsertCommand = comm;
                adap.InsertCommand.ExecuteNonQuery();

                comm = new SqlCommand(add_seat, conn);
                adap.InsertCommand = comm;
                adap.InsertCommand.ExecuteNonQuery();

                comm = new SqlCommand(add_passenger, conn);
                adap.InsertCommand = comm;
                adap.InsertCommand.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Passenger " + txtName.Text + " added!");

                txtEmail.Text = "";
                txtSurname.Text = "";
                txtName.Text = "";
                txtBaggageWeight.Text = "";
                lbxConfirm.Items.Clear();
                btnSubmit.Enabled = true;
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtSurname.Text = "";
            txtName.Text = "";
            txtBaggageWeight.Text = "";
            lbxConfirm.Items.Clear();
            btnSubmit.Enabled = true;
        }

        private void numBaggage_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
