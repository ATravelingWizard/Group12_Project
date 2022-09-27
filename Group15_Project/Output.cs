using System;
using System.Diagnostics;
using Microsoft.Win32;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Pdf;
using Aspose.Foundation;
using System.IO;

namespace Group15_Project
{
    public partial class Output : Form
    {
        public Output()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbxOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            //This list box should display the filtered database from the View Passenger or View Flight forms. Make sure to include the Titles of the fields in the records.
        }

        private async void btnOutput_Click(object sender, EventArgs e)
        {
            try
            {
               StreamWriter file = new StreamWriter(@"C:\Users\henar\OneDrive\Documents\Report.txt");
                file.WriteLine(lbxOutput.Text);
                file.Close();

                MessageBox.Show("Text file successfully created!");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Output_Load(object sender, EventArgs e)
        {
            if(frmView_Passengers.selected_passagenger != null)
            {
                lbxOutput.Items.Clear();
                lbxOutput.Items.Add("Passenger Code\t" + "Baggage Code\t" + " Seat Code\t" + "First Name\t" + "Surname\t\t" + "Contact Email");
                lbxOutput.Items.Add("===================================================================================================");
                lbxOutput.Items.Add(frmView_Passengers.selected_passagenger);
                lbxOutput.Items.Add("===================================================================================================");
            }

            if(frmView_Flights.selected_flight != null)
            {
                lbxOutput.Items.Clear();
                lbxOutput.Items.Add("Flight Code\t" + "Destination ID\t" + " Departure Date and Time\t" + "Arrival Date and Time\t" + "Total Baggage\t" + "Seats Available");
                lbxOutput.Items.Add("===================================================================================================");
                lbxOutput.Items.Add(frmView_Flights.selected_flight);
                lbxOutput.Items.Add("===================================================================================================");
            }
        }
    }
}
