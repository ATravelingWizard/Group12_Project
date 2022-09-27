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
    public partial class Edit_Flights : Form
    {
        string constr = @"Data Source=.;Initial Catalog = Skyfall; Integrated Security = True";
        SqlConnection conn;
        SqlCommand commFlight, commBag, comm;

        public Edit_Flights()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Update new data from the values into the current database and make it show up accordingly in the other databases.

            try
            {
                conn.Open();

                string sqlFlight = $"UPDATE Flight SET Total_Baggage_Weight = '{numBaggageOut.Value}', Seats_Available = '{numSeatOut.Value}' WHERE Flight_Code = '{frmView_Flights.flightID}'";
                commFlight = new SqlCommand(sqlFlight, conn);
                commFlight.ExecuteNonQuery();

                conn.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            this.Close();
        }

        private void Edit_Flights_Load(object sender, EventArgs e)
        {
            lblFlightOut.Text = frmView_Flights.flightID;
            lblSeatsOut.Text = frmView_Flights.seats.ToString();
            lblBaggageOut.Text = frmView_Flights.baggage.ToString();
            lblDestOut.Text = frmView_Flights.dest.ToString();

            lblFlightOut2.Text = frmView_Flights.flightID;
        }
    }
}
