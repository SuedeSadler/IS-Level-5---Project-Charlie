
namespace Visitor_Registration
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.meeting = new System.Windows.Forms.RadioButton();
            this.SalesAppoint = new System.Windows.Forms.RadioButton();
            this.SiteVisit = new System.Windows.Forms.RadioButton();
            this.StudentInterview = new System.Windows.Forms.RadioButton();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please specify the nature of the meeting";
            // 
            // meeting
            // 
            this.meeting.AutoSize = true;
            this.meeting.Location = new System.Drawing.Point(60, 62);
            this.meeting.Name = "meeting";
            this.meeting.Size = new System.Drawing.Size(79, 21);
            this.meeting.TabIndex = 1;
            this.meeting.TabStop = true;
            this.meeting.Text = "Meeting";
            this.meeting.UseVisualStyleBackColor = true;
            this.meeting.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // SalesAppoint
            // 
            this.SalesAppoint.AutoSize = true;
            this.SalesAppoint.Location = new System.Drawing.Point(204, 62);
            this.SalesAppoint.Name = "SalesAppoint";
            this.SalesAppoint.Size = new System.Drawing.Size(147, 21);
            this.SalesAppoint.TabIndex = 2;
            this.SalesAppoint.TabStop = true;
            this.SalesAppoint.Text = "Sales Appointment";
            this.SalesAppoint.UseVisualStyleBackColor = true;
            this.SalesAppoint.CheckedChanged += new System.EventHandler(this.SalesAppoint_CheckedChanged);
            // 
            // SiteVisit
            // 
            this.SiteVisit.AutoSize = true;
            this.SiteVisit.Location = new System.Drawing.Point(60, 109);
            this.SiteVisit.Name = "SiteVisit";
            this.SiteVisit.Size = new System.Drawing.Size(83, 21);
            this.SiteVisit.TabIndex = 3;
            this.SiteVisit.TabStop = true;
            this.SiteVisit.Text = "Site Visit";
            this.SiteVisit.UseVisualStyleBackColor = true;
            this.SiteVisit.CheckedChanged += new System.EventHandler(this.SiteVisit_CheckedChanged);
            // 
            // StudentInterview
            // 
            this.StudentInterview.AutoSize = true;
            this.StudentInterview.Location = new System.Drawing.Point(204, 109);
            this.StudentInterview.Name = "StudentInterview";
            this.StudentInterview.Size = new System.Drawing.Size(137, 21);
            this.StudentInterview.TabIndex = 4;
            this.StudentInterview.TabStop = true;
            this.StudentInterview.Text = "Student Interview";
            this.StudentInterview.UseVisualStyleBackColor = true;
            this.StudentInterview.CheckedChanged += new System.EventHandler(this.StudentInterview_CheckedChanged);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(245, 159);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(96, 24);
            this.OK.TabIndex = 5;
            this.OK.Text = "Ok";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(122, 159);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(96, 24);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Form2
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(375, 207);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.StudentInterview);
            this.Controls.Add(this.SiteVisit);
            this.Controls.Add(this.SalesAppoint);
            this.Controls.Add(this.meeting);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        public System.Windows.Forms.RadioButton meeting;
        public System.Windows.Forms.RadioButton SalesAppoint;
        public System.Windows.Forms.RadioButton SiteVisit;
        public System.Windows.Forms.RadioButton StudentInterview;
    }
}