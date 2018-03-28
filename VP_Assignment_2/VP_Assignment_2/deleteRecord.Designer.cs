namespace VP_Assignment_2
{
    partial class deleteRecord
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
            this.label2 = new System.Windows.Forms.Label();
            this.getID = new System.Windows.Forms.TextBox();
            this.showMsg = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.home)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student ID";
            // 
            // getID
            // 
            this.getID.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getID.Location = new System.Drawing.Point(205, 50);
            this.getID.Name = "getID";
            this.getID.Size = new System.Drawing.Size(176, 26);
            this.getID.TabIndex = 3;
            // 
            // showMsg
            // 
            this.showMsg.AutoSize = true;
            this.showMsg.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showMsg.ForeColor = System.Drawing.Color.Black;
            this.showMsg.Location = new System.Drawing.Point(55, 101);
            this.showMsg.Name = "showMsg";
            this.showMsg.Size = new System.Drawing.Size(12, 18);
            this.showMsg.TabIndex = 4;
            this.showMsg.Text = ".";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(244, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // home
            // 
            this.home.Image = global::VP_Assignment_2.Properties.Resources.HOME100x100blue_home_icon_png;
            this.home.Location = new System.Drawing.Point(222, 120);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(100, 105);
            this.home.TabIndex = 6;
            this.home.TabStop = false;
            this.home.Visible = false;
            this.home.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // deleteRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 246);
            this.Controls.Add(this.home);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showMsg);
            this.Controls.Add(this.getID);
            this.Controls.Add(this.label2);
            this.Name = "deleteRecord";
            this.Text = "Delete Record";
            ((System.ComponentModel.ISupportInitialize)(this.home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox getID;
        private System.Windows.Forms.Label showMsg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox home;
    }
}