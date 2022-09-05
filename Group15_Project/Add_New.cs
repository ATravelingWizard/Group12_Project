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
    }
}
