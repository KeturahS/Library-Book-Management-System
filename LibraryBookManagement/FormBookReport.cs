using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryBookManagement
{
    public partial class FormBookReport : Form
    {
        public FormBookReport()
        {
            InitializeComponent();
            this.BackColor = Color.LightYellow;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        public void SetReportText(string reportText)
        {
            textBoxReport.Text = reportText;
        }

        public void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }


        public void SetReportTitle(string reportTitle)
        {
            textBoxReportTitle.Text = reportTitle;
        }
    }
}
