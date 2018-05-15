namespace vpProject
{
    partial class trends
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Home = new System.Windows.Forms.PictureBox();
            this.showButton = new System.Windows.Forms.Button();
            this.SuspiciousButton = new System.Windows.Forms.Button();
            this.trendsList = new System.Windows.Forms.ListBox();
            this.suspiciousList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::vpProject.Properties.Resources.shutdown;
            this.pictureBox3.Location = new System.Drawing.Point(465, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(154, 149);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Home
            // 
            this.Home.Image = global::vpProject.Properties.Resources.home_button_fix_icon_ageek_1;
            this.Home.Location = new System.Drawing.Point(-1, -1);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(99, 124);
            this.Home.TabIndex = 12;
            this.Home.TabStop = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // showButton
            // 
            this.showButton.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showButton.Location = new System.Drawing.Point(133, 457);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(110, 63);
            this.showButton.TabIndex = 13;
            this.showButton.Text = "Show Trends";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SuspiciousButton
            // 
            this.SuspiciousButton.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuspiciousButton.Location = new System.Drawing.Point(315, 457);
            this.SuspiciousButton.Name = "SuspiciousButton";
            this.SuspiciousButton.Size = new System.Drawing.Size(134, 63);
            this.SuspiciousButton.TabIndex = 14;
            this.SuspiciousButton.Text = "Suspicious Trends";
            this.SuspiciousButton.UseVisualStyleBackColor = true;
            this.SuspiciousButton.Visible = false;
            this.SuspiciousButton.Click += new System.EventHandler(this.SuspiciousButton_Click);
            // 
            // trendsList
            // 
            this.trendsList.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trendsList.FormattingEnabled = true;
            this.trendsList.ItemHeight = 26;
            this.trendsList.Location = new System.Drawing.Point(91, 221);
            this.trendsList.Name = "trendsList";
            this.trendsList.Size = new System.Drawing.Size(152, 212);
            this.trendsList.TabIndex = 15;
            this.trendsList.Visible = false;
            // 
            // suspiciousList
            // 
            this.suspiciousList.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suspiciousList.FormattingEnabled = true;
            this.suspiciousList.ItemHeight = 26;
            this.suspiciousList.Location = new System.Drawing.Point(295, 221);
            this.suspiciousList.Name = "suspiciousList";
            this.suspiciousList.Size = new System.Drawing.Size(154, 212);
            this.suspiciousList.TabIndex = 16;
            this.suspiciousList.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(101, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "Twitter Trends";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(290, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 26);
            this.label2.TabIndex = 18;
            this.label2.Text = "Suspicious Trends";
            // 
            // trends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(620, 570);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.suspiciousList);
            this.Controls.Add(this.trendsList);
            this.Controls.Add(this.SuspiciousButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "trends";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "trends";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox Home;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button SuspiciousButton;
        private System.Windows.Forms.ListBox trendsList;
        private System.Windows.Forms.ListBox suspiciousList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}