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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(164, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Top Ten Twitter Trends";
            // 
            // trendsList
            // 
            this.trendsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trendsList.FormattingEnabled = true;
            this.trendsList.ItemHeight = 20;
            this.trendsList.Items.AddRange(new object[] {
            "Dictator",
            "Pakistani",
            "Malala",
            "Terrorism"});
            this.trendsList.Location = new System.Drawing.Point(68, 202);
            this.trendsList.Name = "trendsList";
            this.trendsList.Size = new System.Drawing.Size(189, 204);
            this.trendsList.TabIndex = 8;
            this.trendsList.Visible = false;
            // 
            // showtrends
            // 
            this.showtrends.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showtrends.Location = new System.Drawing.Point(85, 439);
            this.showtrends.Name = "showtrends";
            this.showtrends.Size = new System.Drawing.Size(125, 52);
            this.showtrends.TabIndex = 9;
            this.showtrends.Text = "Show Top trends";
            this.showtrends.UseVisualStyleBackColor = true;
            this.showtrends.Click += new System.EventHandler(this.showtrends_Click);
            // 
            // suspiciousTrends
            // 
            this.suspiciousTrends.BackColor = System.Drawing.Color.White;
            this.suspiciousTrends.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suspiciousTrends.FormattingEnabled = true;
            this.suspiciousTrends.ItemHeight = 20;
            this.suspiciousTrends.Items.AddRange(new object[] {
            "Dictator",
            "Terrorism"});
            this.suspiciousTrends.Location = new System.Drawing.Point(307, 202);
            this.suspiciousTrends.Name = "suspiciousTrends";
            this.suspiciousTrends.Size = new System.Drawing.Size(185, 204);
            this.suspiciousTrends.TabIndex = 10;
            this.suspiciousTrends.Visible = false;
            // 
            // suspicious
            // 
            this.suspicious.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suspicious.Location = new System.Drawing.Point(342, 439);
            this.suspicious.Name = "suspicious";
            this.suspicious.Size = new System.Drawing.Size(134, 52);
            this.suspicious.TabIndex = 11;
            this.suspicious.Text = "Suspicious Trends";
            this.suspicious.UseVisualStyleBackColor = true;
            this.suspicious.Visible = false;
            this.suspicious.Click += new System.EventHandler(this.suspicious_Click);
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
            // pictureBox3
            // 
            this.pictureBox3.Image = global::vpProject.Properties.Resources.shutdown;
            this.pictureBox3.Location = new System.Drawing.Point(644, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(154, 149);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(65, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Twitter Top Trends";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(302, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Suspicious Trends";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(541, 202);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(242, 204);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // twitterTrends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(795, 514);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.suspicious);
            this.Controls.Add(this.suspiciousTrends);
            this.Controls.Add(this.showtrends);
            this.Controls.Add(this.trendsList);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "twitterTrends";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "trends";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox trendsList;
        private System.Windows.Forms.Button showtrends;
        private System.Windows.Forms.ListBox suspiciousTrends;
        private System.Windows.Forms.Button suspicious;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}