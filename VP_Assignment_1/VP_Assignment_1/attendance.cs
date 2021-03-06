﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace VP_Assignment_1
{
    class attendance
    {
        public void attend(string path, string anotherFile)
        {
            Console.WriteLine("\n\n\t\tIt's a teacher View");
            Console.WriteLine("\n\n\t\tEnter student semester : ");
            string semester = Console.ReadLine();
            Console.WriteLine("\n\n\t\tEnter file path to read student data (e.g, d:/name.txt) ");
            path = Console.ReadLine();
            Console.WriteLine("\n\n\t\tEnter file path to store attendance data [We'll create file when you give the path] (e.g, d:/store.txt) ");
            anotherFile = Console.ReadLine();
            string id, name, sem, gpa, uni, dept;
            string line;
            string att = "";  //attendance variable
            StreamReader file = new StreamReader(path);
            StreamWriter write = File.AppendText(anotherFile);
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
                    int[] x = new int[1000];
                    for (int i = 0; i < x.Length; i++)  // input equals to name count. jitny naam utni input k liy.
                    {
                        x[i] = name.Count();    //name count.
                        Console.WriteLine("\n\t\tEnter attendance for " + name + "(p/a) : ");
                        att = Console.ReadLine();
                        while (att.Equals("P") && att.Equals("p") && att.Equals("A") && att.Equals("a"))
                        {
                            Console.WriteLine("\n\n\t\tEnter (p or a) for (present or attendance) respectively : ");
                            att = Console.ReadLine();
                        }
                        if (att.Equals("P") || att.Equals("p") || att.Equals("A") || att.Equals("a"))
                        {
                            write.WriteLine(sem);
                            write.WriteLine(name);
                            write.WriteLine(att);
                            write.Flush();
                            break;
                        }
                    }
                    Console.WriteLine("Attendance Marked!");
                }
            }
        }
        public void viewAttendance(string anotherFile)
        {
            Console.WriteLine("\n\n\t\tIt's a teacher View");
            Console.WriteLine("\n\t\tEnter student semester number  ");
            string semester = Console.ReadLine();
            Console.WriteLine("\n\n\t\tEnter file path to view attendance (e.g, d:/name.txt) ");
            anotherFile = Console.ReadLine();
            if (File.Exists(anotherFile) == true)
            {
                string pres_absnt, name, sem;
                string line;
                StreamReader file = new StreamReader(anotherFile);
                while ((line = file.ReadLine()) != null)
                {
                    sem = line;
                    name = file.ReadLine();
                    pres_absnt = file.ReadLine();

                    if (sem == semester)
                    {
                        Console.WriteLine(name);
                        Console.WriteLine(pres_absnt);
                    }
                }
            }
            else
            {
                Console.WriteLine("Attendance storage file not found! Try again"); ;
            }
        }
    }
}
