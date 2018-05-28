namespace vpProject
{
    partial class TwitterTrends
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
            this.label3 = new System.Windows.Forms.Label();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trend10 = new System.Windows.Forms.LinkLabel();
            this.trend9 = new System.Windows.Forms.LinkLabel();
            this.trend8 = new System.Windows.Forms.LinkLabel();
            this.trend7 = new System.Windows.Forms.LinkLabel();
            this.trend6 = new System.Windows.Forms.LinkLabel();
            this.trend5 = new System.Windows.Forms.LinkLabel();
            this.trend4 = new System.Windows.Forms.LinkLabel();
            this.trend3 = new System.Windows.Forms.LinkLabel();
            this.trend2 = new System.Windows.Forms.LinkLabel();
            this.trend1 = new System.Windows.Forms.LinkLabel();
            this.spamFormSwitch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(245, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(444, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Current Top Ten Twitter Trends";
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(12, 301);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(858, 335);
            this.webBrowser2.TabIndex = 4;
            this.webBrowser2.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser2_DocumentCompleted);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.spamFormSwitch);
            this.panel1.Controls.Add(this.trend10);
            this.panel1.Controls.Add(this.trend9);
            this.panel1.Controls.Add(this.trend8);
            this.panel1.Controls.Add(this.trend7);
            this.panel1.Controls.Add(this.trend6);
            this.panel1.Controls.Add(this.trend5);
            this.panel1.Controls.Add(this.trend4);
            this.panel1.Controls.Add(this.trend3);
            this.panel1.Controls.Add(this.trend2);
            this.panel1.Controls.Add(this.trend1);
            this.panel1.Location = new System.Drawing.Point(12, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 188);
            this.panel1.TabIndex = 5;
            // 
            // trend10
            // 
            this.trend10.AutoSize = true;
            this.trend10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trend10.Location = new System.Drawing.Point(738, 80);
            this.trend10.Name = "trend10";
            this.trend10.Size = new System.Drawing.Size(94, 24);
            this.trend10.TabIndex = 9;
            this.trend10.TabStop = true;
            this.trend10.Text = "linkLabel5";
            this.trend10.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.trend10_LinkClicked);
            // 
            // trend9
            // 
            this.trend9.AutoSize = true;
            this.trend9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trend9.Location = new System.Drawing.Point(738, 25);
            this.trend9.Name = "trend9";
            this.trend9.Size = new System.Drawing.Size(94, 24);
            this.trend9.TabIndex = 8;
            this.trend9.TabStop = true;
            this.trend9.Text = "linkLabel4";
            this.trend9.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.trend9_LinkClicked);
            // 
            // trend8
            // 
            this.trend8.AutoSize = true;
            this.trend8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trend8.Location = new System.Drawing.Point(583, 80);
            this.trend8.Name = "trend8";
            this.trend8.Size = new System.Drawing.Size(94, 24);
            this.trend8.TabIndex = 7;
            this.trend8.TabStop = true;
            this.trend8.Text = "linkLabel3";
            this.trend8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.trend8_LinkClicked);
            // 
            // trend7
            // 
            this.trend7.AutoSize = true;
            this.trend7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trend7.Location = new System.Drawing.Point(583, 25);
            this.trend7.Name = "trend7";
            this.trend7.Size = new System.Drawing.Size(94, 24);
            this.trend7.TabIndex = 6;
            this.trend7.TabStop = true;
            this.trend7.Text = "linkLabel2";
            this.trend7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.trend7_LinkClicked);
            // 
            // trend6
            // 
            this.trend6.AutoSize = true;
            this.trend6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trend6.Location = new System.Drawing.Point(436, 80);
            this.trend6.Name = "trend6";
            this.trend6.Size = new System.Drawing.Size(94, 24);
            this.trend6.TabIndex = 5;
            this.trend6.TabStop = true;
            this.trend6.Text = "linkLabel1";
            this.trend6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.trend6_LinkClicked);
            // 
            // trend5
            // 
            this.trend5.AutoSize = true;
            this.trend5.DisabledLinkColor = System.Drawing.Color.Black;
            this.trend5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trend5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trend5.Location = new System.Drawing.Point(435, 25);
            this.trend5.Name = "trend5";
            this.trend5.Size = new System.Drawing.Size(94, 24);
            this.trend5.TabIndex = 4;
            this.trend5.TabStop = true;
            this.trend5.Text = "linkLabel5";
            this.trend5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.trend5_LinkClicked);
            // 
            // trend4
            // 
            this.trend4.AutoSize = true;
            this.trend4.DisabledLinkColor = System.Drawing.Color.Black;
            this.trend4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trend4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trend4.Location = new System.Drawing.Point(266, 75);
            this.trend4.Name = "trend4";
            this.trend4.Size = new System.Drawing.Size(94, 24);
            this.trend4.TabIndex = 3;
            this.trend4.TabStop = true;
            this.trend4.Text = "linkLabel4";
            this.trend4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.trend4_LinkClicked);
            // 
            // trend3
            // 
            this.trend3.AutoSize = true;
            this.trend3.DisabledLinkColor = System.Drawing.Color.Black;
            this.trend3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trend3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trend3.Location = new System.Drawing.Point(266, 25);
            this.trend3.Name = "trend3";
            this.trend3.Size = new System.Drawing.Size(94, 24);
            this.trend3.TabIndex = 2;
            this.trend3.TabStop = true;
            this.trend3.Text = "linkLabel3";
            this.trend3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.trend3_LinkClicked);
            // 
            // trend2
            // 
            this.trend2.AutoSize = true;
            this.trend2.DisabledLinkColor = System.Drawing.Color.Black;
            this.trend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trend2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trend2.Location = new System.Drawing.Point(91, 75);
            this.trend2.Name = "trend2";
            this.trend2.Size = new System.Drawing.Size(94, 24);
            this.trend2.TabIndex = 1;
            this.trend2.TabStop = true;
            this.trend2.Text = "linkLabel2";
            this.trend2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.trend2_LinkClicked);
            // 
            // trend1
            // 
            this.trend1.AutoSize = true;
            this.trend1.DisabledLinkColor = System.Drawing.Color.Black;
            this.trend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trend1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trend1.Location = new System.Drawing.Point(91, 25);
            this.trend1.Name = "trend1";
            this.trend1.Size = new System.Drawing.Size(94, 24);
            this.trend1.TabIndex = 0;
            this.trend1.TabStop = true;
            this.trend1.Text = "linkLabel1";
            this.trend1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.trend1_LinkClicked);
            // 
            // spamFormSwitch
            // 
            this.spamFormSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spamFormSwitch.Location = new System.Drawing.Point(648, 137);
            this.spamFormSwitch.Name = "spamFormSwitch";
            this.spamFormSwitch.Size = new System.Drawing.Size(184, 39);
            this.spamFormSwitch.TabIndex = 10;
            this.spamFormSwitch.Text = "Show Spam Trends";
            this.spamFormSwitch.UseVisualStyleBackColor = true;
            this.spamFormSwitch.Click += new System.EventHandler(this.spamFormSwitch_Click);
            // 
            // TwitterTrends
            // 
            this.ClientSize = new System.Drawing.Size(888, 648);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.label3);
            this.Name = "TwitterTrends";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Twitter Trends Spy";
            this.Load += new System.EventHandler(this.TwitterTrends_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox suspiciousList;
        private System.Windows.Forms.Button SuspiciousButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.PictureBox Home;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RichTextBox trends;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel trend5;
        private System.Windows.Forms.LinkLabel trend4;
        private System.Windows.Forms.LinkLabel trend3;
        private System.Windows.Forms.LinkLabel trend2;
        private System.Windows.Forms.LinkLabel trend1;
        private System.Windows.Forms.LinkLabel trend10;
        private System.Windows.Forms.LinkLabel trend9;
        private System.Windows.Forms.LinkLabel trend8;
        private System.Windows.Forms.LinkLabel trend7;
        private System.Windows.Forms.LinkLabel trend6;
        private System.Windows.Forms.Button spamFormSwitch;
    }
}