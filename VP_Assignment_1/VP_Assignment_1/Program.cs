﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            welcome wel = new welcome();
            wel.Welcome();
            wel.choices();
            create cr = new create();
            search sr = new search();
            delete del = new delete();
            cgpa sor = new cgpa();
            attendance att = new attendance();
            string anotherFile = "";
            string path = "";
            string id = null;
            string name = null;
            string university = null;
            string department = null;
            int semester = 0;
            float CGPA = 0;


            Console.WriteLine("\n\t\t\t\t\tEnter you choice : ");
            int choice = int.Parse(Console.ReadLine());
            while (choice != 1 && choice != 2 && choice != 3 && choice != 4 && choice != 5 && choice != 6)
            {
                Console.WriteLine("\n\t\t\t\t\tEnter you choice : ");
                choice = int.Parse(Console.ReadLine());
            }
            if (choice == 1)
            {
                Console.WriteLine("Enter file path to continue (e.g, d:/name.txt)");
                path = Console.ReadLine();
                cr.enter(path, id, name, university, department, semester, CGPA);
            }
            if (choice == 2)
            {

                Console.WriteLine("Enter file path to continue (e.g, d:/name.txt)");
                path = Console.ReadLine();
                sr.searchID(path);
                sr.searchByName(path);
                sr.searchsmstr(path);
            }
            if (choice == 3)
            {
                Console.WriteLine("Enter file path to continue (e.g, d:/name.txt)");
                path = Console.ReadLine();
                del.deleteRecord(path, id);
            }
            if (choice == 4)
            {
                Console.WriteLine("Enter file path to continue [Records must be mroe than one to sort] (e.g, d:/name.txt)");
                path = Console.ReadLine();
                sor.sort(path);
            }
            if (choice == 5)
            {
                att.attend(path, anotherFile);
            }
            if (choice == 6)
            {
                att.viewAttendance(anotherFile);
            }
            Console.ReadLine();
        }
    }
}