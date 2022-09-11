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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
           if (ActiveMdiChild != null)
            {
                if (ActiveMdiChild.GetType().Name != "frmAdd_New")
                {
                    ActiveMdiChild.Close();
                    frmAdd_New frmAdd = new frmAdd_New();
                    frmAdd.MdiParent = this;
                    frmAdd.Show();
                }
                else
                {
                    Console.WriteLine("Add_New Window Already Open - Do Nothing");
                }
            }
            else
            {
                frmAdd_New frmAdd = new frmAdd_New();
                frmAdd.MdiParent = this;
                frmAdd.Show();
            }          
        }

        private void btnFlights_Click(object sender, EventArgs e)
        { 
           
             if (ActiveMdiChild != null)
             {
                if (ActiveMdiChild.GetType().Name != "frmView_Flights")
                {
                    ActiveMdiChild.Close();
                    frmView_Flights frmFlight = new frmView_Flights();
                    frmFlight.MdiParent = this;
                    frmFlight.Show();
                }
                else
                {
                    Console.WriteLine("View_Flights Window Already Open - Do Nothing");
                }
            }
            else
            {
                frmView_Flights frmFlight = new frmView_Flights();
                frmFlight.MdiParent = this;
                frmFlight.Show();
            }           
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                if (ActiveMdiChild.GetType().Name != "frmView_Passengers")
                {
                    ActiveMdiChild.Close();
                    frmView_Passengers frmPass = new frmView_Passengers();
                    frmPass.MdiParent = this;
                    frmPass.Show();
                }
                else
                {
                    Console.WriteLine("View_Passenger Window Already Open - Do Nothing");
                }
            }
            else
            {
                frmView_Passengers frmPass = new frmView_Passengers();
                frmPass.MdiParent = this;
                frmPass.Show();
            }
            
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                if (ActiveMdiChild.GetType().Name != "frmHelp")
                {
                    ActiveMdiChild.Close();
                    frmHelp frmHelp = new frmHelp();
                    frmHelp.MdiParent = this;
                    frmHelp.Show();
                }
                else
                {
                    Console.WriteLine("Generate_Reports Window Already Open - Do Nothing");
                }
            }
            else
            {
                frmHelp frmHelp = new frmHelp();
                frmHelp.MdiParent = this;
                frmHelp.Show();
            }
        }

        private void pnlBottomLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblWelcomeTwo_Click(object sender, EventArgs e)
        {

        }
    }
}
