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
            //This list box should display the filtered database from the View Passenger or View Flight forms.
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo()
            {
                CreateNoWindow = true,
                Verb = "print",
                FileName = @"C:\Output.pdf\"
            };
            p.Start();
        }
    }
}
