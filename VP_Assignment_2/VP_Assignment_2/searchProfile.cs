﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Assignment_2
{
    public partial class searchProfile : Form
    {
        public searchProfile()
        {
            InitializeComponent();
        }
        filePath passPath = new filePath();
        List<string> fill = new List<string>();     //declared globally
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
            string id = enterSearch.Text;
            string Path = passPath.mainPath;
            string searchID, name, sem, gpa, uni, dept;
            string line;
            StreamReader file = new StreamReader(Path);
            while ((line = file.ReadLine()) != null)
            {
                searchID = line;
                name = file.ReadLine();
                uni = file.ReadLine();
                dept = file.ReadLine();
                sem = file.ReadLine();
                gpa = file.ReadLine();

                if (id == searchID)
                {
                    fill.Add(name);
                    fill.Add(uni);
                    fill.Add(dept);
                    fill.Add(sem);
                    fill.Add(gpa);
                    showList.DataSource = fill;
                    file.Close();
                    break;
                }
                else
                {
                    showMsg.Text = "Record not found! Also check your file path";
                }
            }
            button1.Visible = false;
            home.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = true;
            button3.Visible = false;
            string name = enterSearch.Text;
            string Path = passPath.mainPath;
            string id, searchName, sem, gpa, uni, dept;
            string line;
            StreamReader file = new StreamReader(Path);
            while ((line = file.ReadLine()) != null)
            {
                id = line;
                searchName = file.ReadLine();
                uni = file.ReadLine();
                dept = file.ReadLine();
                sem = file.ReadLine();
                gpa = file.ReadLine();

                if (name == searchName)
                {
                    fill.Add(id);
                    fill.Add(uni);
                    fill.Add(dept);
                    fill.Add(sem);
                    fill.Add(gpa);
                    showList.DataSource = fill;
                    file.Close();
                    break;
                }
                else
                {
                    showMsg.Text = "Record not found! Also check your file path";
                }
            }
            button2.Hide();
            home.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = true;
            string sem = enterSearch.Text;
            string Path = passPath.mainPath;
            string id, Name, searchSem, gpa, uni, dept;
            string line;
            StreamReader file = new StreamReader(Path);
            while ((line = file.ReadLine()) != null)
            {
                id = line;
                Name = file.ReadLine();
                uni = file.ReadLine();
                dept = file.ReadLine();
                searchSem = file.ReadLine();
                gpa = file.ReadLine();

                if (sem == searchSem)
                {
                    fill.Add(id);
                    fill.Add(Name);
                    fill.Add(uni);
                    fill.Add(dept);
                    fill.Add(gpa);
                    showList.DataSource = fill;
                    file.Close();
                    break;
                }
                else
                {
                    showMsg.Text = "Record not found! Also check your file path";
                }
            }
            button3.Hide();
            home.Show();
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Application.Restart();
        }
    }
}