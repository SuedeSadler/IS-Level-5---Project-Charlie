
namespace Visitor_Registration
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.VisitorDetails = new System.Windows.Forms.GroupBox();
            this.MobileNumTxt = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LnameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FnameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MeeingDetails = new System.Windows.Forms.GroupBox();
            this.MeetingAim = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Minute = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.HourNum = new System.Windows.Forms.NumericUpDown();
            this.MeetingName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.VisitorOnsite = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SignIn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.VisitorDetails.SuspendLayout();
            this.MeeingDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HourNum)).BeginInit();
            this.VisitorOnsite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // VisitorDetails
            // 
            this.VisitorDetails.Controls.Add(this.MobileNumTxt);
            this.VisitorDetails.Controls.Add(this.emailtxt);
            this.VisitorDetails.Controls.Add(this.label4);
            this.VisitorDetails.Controls.Add(this.label3);
            this.VisitorDetails.Controls.Add(this.LnameTxt);
            this.VisitorDetails.Controls.Add(this.label2);
            this.VisitorDetails.Controls.Add(this.FnameTxt);
            this.VisitorDetails.Controls.Add(this.label1);
            this.VisitorDetails.Location = new System.Drawing.Point(12, 12);
            this.VisitorDetails.Name = "VisitorDetails";
            this.VisitorDetails.Size = new System.Drawing.Size(188, 299);
            this.VisitorDetails.TabIndex = 3;
            this.VisitorDetails.TabStop = false;
            this.VisitorDetails.Text = "Visitor Details";
            this.VisitorDetails.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // MobileNumTxt
            // 
            this.MobileNumTxt.Location = new System.Drawing.Point(6, 171);
            this.MobileNumTxt.Name = "MobileNumTxt";
            this.MobileNumTxt.Size = new System.Drawing.Size(143, 22);
            this.MobileNumTxt.TabIndex = 10;
            this.MobileNumTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(9, 231);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(140, 22);
            this.emailtxt.TabIndex = 9;
            this.emailtxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mobile Number";
            // 
            // LnameTxt
            // 
            this.LnameTxt.Location = new System.Drawing.Point(6, 103);
            this.LnameTxt.Name = "LnameTxt";
            this.LnameTxt.Size = new System.Drawing.Size(143, 22);
            this.LnameTxt.TabIndex = 3;
            this.LnameTxt.TextChanged += new System.EventHandler(this.LnameTxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname";
            // 
            // FnameTxt
            // 
            this.FnameTxt.Location = new System.Drawing.Point(6, 47);
            this.FnameTxt.Name = "FnameTxt";
            this.FnameTxt.Size = new System.Drawing.Size(143, 22);
            this.FnameTxt.TabIndex = 1;
            this.FnameTxt.TextChanged += new System.EventHandler(this.FnameTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // MeeingDetails
            // 
            this.MeeingDetails.Controls.Add(this.MeetingAim);
            this.MeeingDetails.Controls.Add(this.label9);
            this.MeeingDetails.Controls.Add(this.Minute);
            this.MeeingDetails.Controls.Add(this.label8);
            this.MeeingDetails.Controls.Add(this.HourNum);
            this.MeeingDetails.Controls.Add(this.MeetingName);
            this.MeeingDetails.Controls.Add(this.label7);
            this.MeeingDetails.Controls.Add(this.label6);
            this.MeeingDetails.Controls.Add(this.dateTimePicker1);
            this.MeeingDetails.Controls.Add(this.label5);
            this.MeeingDetails.Location = new System.Drawing.Point(206, 12);
            this.MeeingDetails.Name = "MeeingDetails";
            this.MeeingDetails.Size = new System.Drawing.Size(188, 299);
            this.MeeingDetails.TabIndex = 4;
            this.MeeingDetails.TabStop = false;
            this.MeeingDetails.Text = "Meeting Details";
            // 
            // MeetingAim
            // 
            this.MeetingAim.Location = new System.Drawing.Point(6, 228);
            this.MeetingAim.Name = "MeetingAim";
            this.MeetingAim.Size = new System.Drawing.Size(149, 28);
            this.MeetingAim.TabIndex = 13;
            this.MeetingAim.UseVisualStyleBackColor = true;
            this.MeetingAim.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Meeting aim";
            // 
            // Minute
            // 
            this.Minute.Location = new System.Drawing.Point(96, 104);
            this.Minute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.Minute.Name = "Minute";
            this.Minute.Size = new System.Drawing.Size(59, 22);
            this.Minute.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = ":";
            // 
            // HourNum
            // 
            this.HourNum.Location = new System.Drawing.Point(9, 104);
            this.HourNum.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.HourNum.Name = "HourNum";
            this.HourNum.Size = new System.Drawing.Size(63, 22);
            this.HourNum.TabIndex = 9;
            // 
            // MeetingName
            // 
            this.MeetingName.AllowDrop = true;
            this.MeetingName.FormattingEnabled = true;
            this.MeetingName.Items.AddRange(new object[] {
            "Pop Smoke",
            "Saturo Gojo",
            "Lebron James"});
            this.MeetingName.Location = new System.Drawing.Point(6, 169);
            this.MeetingName.Name = "MeetingName";
            this.MeetingName.Size = new System.Drawing.Size(149, 24);
            this.MeetingName.TabIndex = 8;
            this.MeetingName.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Meeting with";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Time";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 22);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2021, 2, 22, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Date";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // VisitorOnsite
            // 
            this.VisitorOnsite.Controls.Add(this.listBox1);
            this.VisitorOnsite.Location = new System.Drawing.Point(400, 14);
            this.VisitorOnsite.Name = "VisitorOnsite";
            this.VisitorOnsite.Size = new System.Drawing.Size(352, 356);
            this.VisitorOnsite.TabIndex = 5;
            this.VisitorOnsite.TabStop = false;
            this.VisitorOnsite.Text = "Visitor\'s Onsite";
            this.VisitorOnsite.Enter += new System.EventHandler(this.VisitorOnsite_Enter);
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(17, 34);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(325, 308);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // SignIn
            // 
            this.SignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn.Location = new System.Drawing.Point(12, 319);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(382, 51);
            this.SignIn.TabIndex = 6;
            this.SignIn.Text = "Sign In";
            this.SignIn.UseVisualStyleBackColor = true;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 380);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.VisitorOnsite);
            this.Controls.Add(this.MeeingDetails);
            this.Controls.Add(this.VisitorDetails);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.VisitorDetails.ResumeLayout(false);
            this.VisitorDetails.PerformLayout();
            this.MeeingDetails.ResumeLayout(false);
            this.MeeingDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HourNum)).EndInit();
            this.VisitorOnsite.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox VisitorDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox MeeingDetails;
        private System.Windows.Forms.GroupBox VisitorOnsite;
        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox MeetingName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown Minute;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown HourNum;
        public System.Windows.Forms.TextBox LnameTxt;
        public System.Windows.Forms.TextBox FnameTxt;
        private System.Windows.Forms.TextBox emailtxt;
        public System.Windows.Forms.TextBox MobileNumTxt;
        private System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.Button MeetingAim;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

