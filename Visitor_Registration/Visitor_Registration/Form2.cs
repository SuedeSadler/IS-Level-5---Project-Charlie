using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visitor_Registration
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void SalesAppoint_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void StudentInterview_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SiteVisit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            
            Form1 f1 = new Form1();
            f1.MeetingAim.Text = ("5456");
            
        }
    }
}
