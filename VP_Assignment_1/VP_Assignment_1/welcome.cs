﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Assignment_1
{
    class welcome
    {
        public void Welcome()
        {
            Console.WriteLine("\n\n\t\t\t\t\t_______________________________");
            Console.WriteLine("\t\t\t\t\t|Welcome to BU Student Profile|");
            Console.WriteLine("\t\t\t\t\t_______________________________");
        }
        public void choices()
        {
            Console.WriteLine("\n\t\t\t\t\t___________________________");
            Console.WriteLine("\t\t\t\t\t|Press                     |");
            Console.WriteLine("\t\t\t\t\t|1. To create your profile |");
            Console.WriteLine("\t\t\t\t\t|2. Search Student         |");
            Console.WriteLine("\t\t\t\t\t|3. Delete Student Record  |");
            Console.WriteLine("\t\t\t\t\t|4. List of top 3 students |");
            Console.WriteLine("\t\t\t\t\t|5. Mark attendance        |");
            Console.WriteLine("\t\t\t\t\t|6. View Attendance        |");
            Console.WriteLine("\t\t\t\t\t___________________________");
        }
    }
}
