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
    public partial class Edit_Passenger : Form
    {
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

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit_Passenger_Load(object sender, EventArgs e)
        {
            //Current database values should be loaded into the form labels.
        }
    }
}
