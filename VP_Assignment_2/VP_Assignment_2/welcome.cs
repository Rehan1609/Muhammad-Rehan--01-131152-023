using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Assignment_2
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        
         createProfile create = new createProfile(); 
         searchProfile search = new searchProfile();
         deleteRecord delete = new deleteRecord();
         topThree topThree = new topThree();
         markAttendance mark = new markAttendance();
       
        private void Welcome_MdiChildActivate(object sender, EventArgs e)
        {

        }

        private void createProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            create.MdiParent = this;
            create.Show();
        }

        private void searchProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer=true;
            search.MdiParent = this;
            search.Show();
        }

        private void deleteProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            delete.MdiParent = this;
            delete.Show();
        }

        private void topThreeCGPAToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            this.IsMdiContainer = true;
            topThree.MdiParent = this;
            topThree.Show();
        }

        private void markAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            mark.MdiParent = this;
            mark.Show();
        }

        private void viewAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //to be done
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            create.Hide();
            search.Hide();
            delete.Hide();
            topThree.Hide();
            mark.Hide();
            this.Show();
        }
    }
}
