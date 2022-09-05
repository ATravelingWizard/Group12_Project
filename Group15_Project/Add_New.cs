using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group15_Project
{
    public partial class frmAdd_New : Form
    {
        public frmAdd_New()
        {
            InitializeComponent();
        }

        private void lblNum_Click(object sender, EventArgs e)
        {

        }

        private void frmAdd_New_Load(object sender, EventArgs e)
        {
            //When form loads get first open seat and flight number from database.
            lblOutputFlight.Text = "Insert flight number in here.";
            lblOutputSeat.Text = "Insert seat number here.";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lbxConfirm.Items.Add("=======Passenger Info=======");
            lbxConfirm.Items.Add("Name: " + txtName.Text);
            lbxConfirm.Items.Add("Surname: " + txtSurname.Text);
            lbxConfirm.Items.Add("Email: " + txtEmail.Text);
            lbxConfirm.Items.Add("=======Flight Info=======");
            lbxConfirm.Items.Add("Baggage Weight: " + numBaggage.Value.ToString() + " kg");
            lbxConfirm.Items.Add("Seat Number: " + lblOutputSeat.Text);
            lbxConfirm.Items.Add("Flight Number: " + lblOutputFlight.Text);

            btnSubmit.Enabled = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New Passenger Has been added Successfully");

            /* When this button is clicked the data of the passenger should be read into the passenger database and a code generated for the passenger.
             * 
             * It should also create a random code that is added into the baggage database along with the weight.
             * 
             * A Random seat code should be made with flight and seat number and entered into the Seat database.
             * 
             * Passenger Code gets read into the Passengers_on_flight database.
             */

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
    }
}
