﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace VP_Assignment_1
{
    class search
    {
        public void srChoices()
        {
            Console.WriteLine("\n\t\t\t\t\t_____________________________");
            Console.WriteLine("\t\t\t\t\t|We offer you search         |");
            Console.WriteLine("\t\t\t\t\t|By Student ID               |");
            Console.WriteLine("\t\t\t\t\t|By Search by Student Name   |");
            Console.WriteLine("\t\t\t\t\t|By Search by semester (List)|");
            Console.WriteLine("\t\t\t\t\t______________________________");
        }
        public void searchID(string path)
        {
            Console.WriteLine("\n\n\t\t\tEnter your ID to find in records : ");
            string id = Console.ReadLine();
            string searchID, name, sem, gpa, uni, dept;
            string line;
            StreamReader file = new StreamReader(path);
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
                    Console.WriteLine(name);
                    Console.WriteLine(uni);
                    Console.WriteLine(dept);
                    Console.WriteLine(sem);
                    Console.WriteLine(gpa);
                    break;
                }
            }
        }
        public void searchByName(string path)
        {
            Console.WriteLine("\n\n\t\t\tEnter name to find in records : ");
            string name = Console.ReadLine();
            string id, searchName, sem, gpa, uni, dept;
            string line;
            StreamReader file = new StreamReader(path);
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
                    Console.WriteLine(id);
                    Console.WriteLine(name);
                    Console.WriteLine(uni);
                    Console.WriteLine(dept);
                    Console.WriteLine(sem);
                    Console.WriteLine(gpa);
                    break;
                }

            }
        }
        public void searchsmstr(string path)
        {
            Console.WriteLine("\n\n\t\t\tEnter your semester : ");
            string semester = Console.ReadLine();
            string id, name, sem, gpa, uni, dept;
            string line;
            StreamReader file = new StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                id = line;
                name = file.ReadLine();
                uni = file.ReadLine();
                dept = file.ReadLine();
                sem = file.ReadLine();
                gpa = file.ReadLine();

                if (sem == semester)
                {
                    Console.WriteLine(id);
                    Console.WriteLine(name);
                    Console.WriteLine(uni);
                    Console.WriteLine(dept);
                    Console.WriteLine(sem);
                    Console.WriteLine(gpa);
                    break;
                }
            }
        }
    }
}
