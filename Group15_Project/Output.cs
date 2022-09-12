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

        private void btnOutput_Click(object sender, EventArgs e)
        {
            Document document = new Document();

            Page page = document.Pages.Add();
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Report Generate for SkyFall."));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("The following report was generated on the: " + DateTime.Now));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(lbxOutput.Text));

            document.Save("Report.pdf");
        }

        private void Output_Load(object sender, EventArgs e)
        {

        }
    }
}
