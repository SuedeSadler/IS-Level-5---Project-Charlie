using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Visitor_Registration
{

    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }
        bool buttonWasClicked = false;

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;
            Form2 f2 = new Form2();
            if (f2.ShowDialog() == DialogResult.OK)
            {
                if (f2.meeting.Checked == true)
                    MeetingAim.Text = f2.meeting.Text;
                else if (f2.SalesAppoint.Checked == true)
                    MeetingAim.Text = f2.SalesAppoint.Text;
                else if (f2.StudentInterview.Checked == true)
                    MeetingAim.Text = f2.StudentInterview.Text;
                else if (f2.SiteVisit.Checked == true)
                    MeetingAim.Text = f2.SiteVisit.Text;

            }
            else
            {
                MeetingAim.Text = "";
            }



        }

        private void FnameTxt_TextChanged(object sender, EventArgs e)
        {



        }

        private void LnameTxt_TextChanged(object sender, EventArgs e)
        {


        }

        private void VisitorsOnsiteList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VisitorOnsite_Enter(object sender, EventArgs e)
        {

        }

        private void SignIn_Click(object sender, EventArgs e)
        {


            int num = 0;
            if (FnameTxt.Text == "")
            {
                MessageBox.Show("Enter first name");
                FnameTxt.Focus();
            }
            else if (LnameTxt.Text == "")
            {
                MessageBox.Show("Enter last name");
                LnameTxt.Focus();
            }
            else if (int.TryParse(MobileNumTxt.Text, out num) == false)
            {
                MessageBox.Show("Enter a valid number please");
            }
            else if (emailtxt.Text == "")
            {
                MessageBox.Show("Enter an email");
            }
            else if (HourNum.Value == 0)
            {
                MessageBox.Show("Enter a time");
            }
            else if (MeetingName.SelectedIndex == -1)
            {
                MessageBox.Show("plese select the person your meeting with");
            }
            else if (buttonWasClicked == false)
            {
                MessageBox.Show("Please select an meeting aim");
            }
            else
            {
                listBox1.Items.Add("Meeting for: " + (FnameTxt.Text + " " + LnameTxt.Text));
                listBox1.Items.Add("Meeting at: " + (HourNum.Value + ":" + Minute.Value));
                listBox1.Items.Add("Meeting with: " + MeetingName.SelectedItem);
                listBox1.Items.Add("Meeting Aim: " + MeetingAim.Text);
                listBox1.Items.Add("--------------------------------------------------------");
                {

                    FnameTxt.Clear();
                    LnameTxt.Clear();
                    MobileNumTxt.Clear();
                    emailtxt.Clear();
                    HourNum.Value = 0;
                    Minute.Value = 0;
                    MeetingName.Text = ("");
                    MeetingAim.Text = ("");
                }




            }












        }

        private void VisitorsOnsite_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {


        }

        public void ValidationofEmail()
        {
            String pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\)+[a-zA]{2,9})$";
            if (Regex.IsMatch(emailtxt.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(emailtxt, "Please provide a valid email address");
            }
        }







        private void visitorsOnsitetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearinfofromVisitorslist();
        }
        void ClearInfo()
        {
            {
                FnameTxt.Clear();
                LnameTxt.Clear();
                MobileNumTxt.Clear();
                emailtxt.Clear();
                HourNum.Value = 0;
                Minute.Value = 0;
                MeetingName.Text = ("");
                MeetingAim.Text = ("");

            }
        }
        void ClearinfofromVisitorslist()
        {
            {
              
                

            }
        }
    }
}
        
    
   


