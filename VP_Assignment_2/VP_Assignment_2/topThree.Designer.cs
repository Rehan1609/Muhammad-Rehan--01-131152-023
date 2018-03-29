namespace VP_Assignment_2
{
    partial class topThree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(topThree));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.showMsg = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.home = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(55, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "University top three students";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(77, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Show List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // showMsg
            // 
            this.showMsg.AutoSize = true;
            this.showMsg.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showMsg.Location = new System.Drawing.Point(29, 202);
            this.showMsg.Name = "showMsg";
            this.showMsg.Size = new System.Drawing.Size(15, 24);
            this.showMsg.TabIndex = 6;
            this.showMsg.Text = ".";
            this.showMsg.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "label7";
            this.label6.Visible = false;
            // 
            // home
            // 
            this.home.Image = global::VP_Assignment_2.Properties.Resources.HOME100x100blue_home_icon_png;
            this.home.Location = new System.Drawing.Point(139, 96);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(100, 101);
            this.home.TabIndex = 10;
            this.home.TabStop = false;
            this.home.Visible = false;
            this.home.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VP_Assignment_2.Properties.Resources.close_128;
            this.pictureBox1.Location = new System.Drawing.Point(371, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 121);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // topThree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(493, 337);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.home);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.showMsg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "topThree";
            this.Text = "topThree";
            ((System.ComponentModel.ISupportInitialize)(this.home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label showMsg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox home;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}