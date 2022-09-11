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
    public partial class Add_flight : Form
    {
        public Add_flight()
        {
            InitializeComponent();
        }

        private void gbxInfo_Enter(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            numBaggage.Value = 0;
            numSeats.Value = 0;
            lbxConfirm.Items.Clear();
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

        }
    }
}
