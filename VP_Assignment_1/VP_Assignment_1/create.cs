using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace VP_Assignment_1
{
    class create
    {
        public void enter(string path, string studentID, string studentName, string uni, string dept, int smstr, float cgpa)
        {
            while (File.Exists(path) != true)
            {
                Console.WriteLine("\t!!!File does not exists (Create file by entereing path (e.g, d:/name.txt)): ");
                path = Console.ReadLine();
                StreamWriter makefile = new StreamWriter(path);
                makefile.Close();
            }
            Console.WriteLine("\n\t\tEnter unique id : ");
            studentID = Console.ReadLine();
            string line = "";
            StreamReader file = new StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                if (studentID == line)
                {
                    Console.WriteLine("\t\t!!!Please enter unique id : ");
                    studentID = Console.ReadLine();
                }
            }
            if (studentID != line)
            {
                file.Close();

                Console.WriteLine("\t\tEnter your Name : ");
                studentName = Console.ReadLine();

                Console.WriteLine("\t\tEnter your University Name : ");
                uni = Console.ReadLine();

                Console.WriteLine("\t\tEnter your department name : ");
                dept = Console.ReadLine();

                Console.WriteLine("\t\tEnter your semester : ");
                smstr = int.Parse(Console.ReadLine());
                while (smstr > 8)
                {
                    Console.Clear();
                    Console.WriteLine("\t\t!!!Correct your semester : ");
                    smstr = int.Parse(Console.ReadLine());
                }
                if (smstr <= 8)
                {
                    Console.WriteLine("\t\tEnter your CGPA : ");
                    cgpa = float.Parse(Console.ReadLine());
                    while (cgpa > 4)
                    {
                        Console.WriteLine("\n\n\t\t\t!!!Enter correct CGPA (below or equal to 4) : ");
                        cgpa = float.Parse(Console.ReadLine());
                    }
                    if (cgpa <= 4)
                    {
                        StreamWriter write = File.AppendText(path);
                        write.WriteLine(studentID);
                        write.WriteLine(studentName);
                        write.WriteLine(uni);
                        write.WriteLine(dept);
                        write.WriteLine(smstr);
                        write.WriteLine(cgpa);
                        write.Flush();
                    }
                }
                Console.WriteLine("Data has been successfully inserted in " + path);
            }
        }
    }
}
