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
    public partial class Edit_Passenger : Form
    {
        string constr = @"Data Source=.;Initial Catalog = Skyfall; Integrated Security = True";
        SqlConnection conn;
        SqlCommand commPas, commBag, comm;
        SqlDataAdapter adap;
        DataSet ds;
        SqlDataReader read;

        public string passID;

        public Edit_Passenger()
        {
            InitializeComponent();
        }

        private void gbxInfo_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Updated values should replace current values in the database and should be reflected in the other databases too.
            try
            {
                conn.Open();

                string sqlPas = $"UPDATE Passengers SET First_Name = '{txtName.Text}', Last_Name = '{txtSurname.Text}', Contact_Email = '{txtEmail.Text}' WHERE First_Name = '{frmView_Passengers.name}' AND Last_Name = '{frmView_Passengers.surname}' AND Contact_Email = '{frmView_Passengers.email}'";
                commPas = new SqlCommand(sqlPas, conn);
                commPas.ExecuteNonQuery();

                MessageBox.Show("Hier");

                string sqlBag = $"UPDATE Baggage SET Weight= '{(double)numBaggage.Value}' WHERE Baggage_Code = 'Louw8927'";
                commBag = new SqlCommand(sqlBag, conn);
                commBag.ExecuteNonQuery();

                conn.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit_Passenger_Load(object sender, EventArgs e)
        {
            lblOutName.Text = frmView_Passengers.name;
            lblOutSurname.Text = frmView_Passengers.surname;
            lblEmailOut.Text = frmView_Passengers.email;
            lblOutWeight.Text = frmView_Passengers.bag.ToString();

            conn = new SqlConnection(constr);

            conn.Open();
            conn.Close();
        }
    }
}
