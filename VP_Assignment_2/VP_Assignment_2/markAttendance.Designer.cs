namespace VP_Assignment_2
{
    partial class markAttendance
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
            this.label2 = new System.Windows.Forms.Label();
            this.readData = new System.Windows.Forms.TextBox();
            this.saveAtt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.readSemester = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.change = new System.Windows.Forms.Label();
            this.inputAttendance = new System.Windows.Forms.TextBox();
            this.markAtt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.showMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(293, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin View";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(254, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "BU Attendance System";
            // 
            // readData
            // 
            this.readData.Location = new System.Drawing.Point(393, 120);
            this.readData.Name = "readData";
            this.readData.Size = new System.Drawing.Size(182, 20);
            this.readData.TabIndex = 2;
            // 
            // saveAtt
            // 
            this.saveAtt.Location = new System.Drawing.Point(393, 172);
            this.saveAtt.Name = "saveAtt";
            this.saveAtt.Size = new System.Drawing.Size(182, 20);
            this.saveAtt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "File Path to read from (d:/readThisFile.txt)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(338, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "File Path to store marked attendance (d:/markAtt.txt)";
            // 
            // readSemester
            // 
            this.readSemester.Location = new System.Drawing.Point(393, 226);
            this.readSemester.Name = "readSemester";
            this.readSemester.Size = new System.Drawing.Size(182, 20);
            this.readSemester.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(319, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Enter semester number to mark attendance (e.g 6)";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Location = new System.Drawing.Point(406, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Students List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(26, 293);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(128, 121);
            this.listBox1.TabIndex = 9;
            this.listBox1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mark Attendace for ";
            this.label6.Visible = false;
            // 
            // change
            // 
            this.change.AutoSize = true;
            this.change.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change.Location = new System.Drawing.Point(160, 146);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(46, 18);
            this.change.TabIndex = 11;
            this.change.Text = "label7";
            this.change.Visible = false;
            // 
            // inputAttendance
            // 
            this.inputAttendance.Location = new System.Drawing.Point(250, 144);
            this.inputAttendance.Name = "inputAttendance";
            this.inputAttendance.Size = new System.Drawing.Size(182, 20);
            this.inputAttendance.TabIndex = 12;
            this.inputAttendance.Visible = false;
            // 
            // markAtt
            // 
            this.markAtt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markAtt.Location = new System.Drawing.Point(250, 193);
            this.markAtt.Name = "markAtt";
            this.markAtt.Size = new System.Drawing.Size(161, 38);
            this.markAtt.TabIndex = 13;
            this.markAtt.Text = "Mark Attendance";
            this.markAtt.UseVisualStyleBackColor = true;
            this.markAtt.Visible = false;
            this.markAtt.Click += new System.EventHandler(this.markAtt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = ".";
            // 
            // showMsg
            // 
            this.showMsg.AutoSize = true;
            this.showMsg.Location = new System.Drawing.Point(256, 330);
            this.showMsg.Name = "showMsg";
            this.showMsg.Size = new System.Drawing.Size(10, 13);
            this.showMsg.TabIndex = 15;
            this.showMsg.Text = ".";
            // 
            // markAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 455);
            this.Controls.Add(this.showMsg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.markAtt);
            this.Controls.Add(this.inputAttendance);
            this.Controls.Add(this.change);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.readSemester);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saveAtt);
            this.Controls.Add(this.readData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "markAttendance";
            this.Text = "BU Semester Attendance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox readData;
        private System.Windows.Forms.TextBox saveAtt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox readSemester;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label change;
        private System.Windows.Forms.TextBox inputAttendance;
        private System.Windows.Forms.Button markAtt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label showMsg;
    }
}