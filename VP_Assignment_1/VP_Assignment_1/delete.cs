﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace VP_Assignment_1
{
    class delete
    {
        public void deleteRecord(string path, string id)
        {
            Console.WriteLine("Enter your id to delete");
            id = Console.ReadLine();
            StreamReader file = new StreamReader(path);
            string line;    //reading integers
            int addition = 0;
            while ((line = file.ReadLine()) != null)
            {
                addition++;
            }
            file.Close();
            file = new StreamReader(path);
            string[] length = new string[addition]; //passing string to n lines
            for (int i = 0; i < addition; i++)
            {
                length[i] = file.ReadLine();
                if (length[i] == id.ToString()) //if condition is true
                {
                    length[i] = null;   //make it null
                    i--;                //decrement previous records
                    for (int j = 0; j < 5; j++)
                    {
                        line = file.ReadLine();
                    }
                }
            }
            file.Close();
            using (StreamWriter newfile = new StreamWriter(path))
            {
                for (int i = 0; i < length.Length; i++)
                {
                    newfile.WriteLine(length[i]);
                }

            }
            Console.WriteLine("\n\t\tRecord has been deleted");
        }
    }
}
