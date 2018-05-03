namespace vpProject
{
    partial class twitterTrends
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
            this.trendsList = new System.Windows.Forms.ListBox();
            this.showtrends = new System.Windows.Forms.Button();
            this.suspiciousTrends = new System.Windows.Forms.ListBox();
            this.suspicious = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Top Ten Twitter Trends";
            // 
            // trendsList
            // 
            this.trendsList.FormattingEnabled = true;
            this.trendsList.Location = new System.Drawing.Point(68, 152);
            this.trendsList.Name = "trendsList";
            this.trendsList.Size = new System.Drawing.Size(162, 199);
            this.trendsList.TabIndex = 8;
            this.trendsList.Visible = false;
            // 
            // showtrends
            // 
            this.showtrends.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showtrends.Location = new System.Drawing.Point(68, 375);
            this.showtrends.Name = "showtrends";
            this.showtrends.Size = new System.Drawing.Size(162, 52);
            this.showtrends.TabIndex = 9;
            this.showtrends.Text = "Show Top trends";
            this.showtrends.UseVisualStyleBackColor = true;
            this.showtrends.Click += new System.EventHandler(this.showtrends_Click);
            // 
            // suspiciousTrends
            // 
            this.suspiciousTrends.BackColor = System.Drawing.Color.White;
            this.suspiciousTrends.FormattingEnabled = true;
            this.suspiciousTrends.Location = new System.Drawing.Point(330, 152);
            this.suspiciousTrends.Name = "suspiciousTrends";
            this.suspiciousTrends.Size = new System.Drawing.Size(162, 199);
            this.suspiciousTrends.TabIndex = 10;
            this.suspiciousTrends.Visible = false;
            // 
            // suspicious
            // 
            this.suspicious.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suspicious.Location = new System.Drawing.Point(330, 375);
            this.suspicious.Name = "suspicious";
            this.suspicious.Size = new System.Drawing.Size(162, 52);
            this.suspicious.TabIndex = 11;
            this.suspicious.Text = "Show Suspicous Trends";
            this.suspicious.UseVisualStyleBackColor = true;
            this.suspicious.Visible = false;
            this.suspicious.Click += new System.EventHandler(this.suspicious_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::vpProject.Properties.Resources.close_button_2_128;
            this.pictureBox3.Location = new System.Drawing.Point(505, -2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(124, 119);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::vpProject.Properties.Resources.home_button_fix_icon_ageek_1;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 124);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // twitterTrends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(632, 449);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.suspicious);
            this.Controls.Add(this.suspiciousTrends);
            this.Controls.Add(this.showtrends);
            this.Controls.Add(this.trendsList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "twitterTrends";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "trends";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox trendsList;
        private System.Windows.Forms.Button showtrends;
        private System.Windows.Forms.ListBox suspiciousTrends;
        private System.Windows.Forms.Button suspicious;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}