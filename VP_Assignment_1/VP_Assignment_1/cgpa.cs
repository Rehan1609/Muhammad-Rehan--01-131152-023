using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace VP_Assignment_1
{
    class cgpa
    {
        public void sort(string path)
        {
            string searchID, name, sem, gpa, uni, dept;
            string line="";
            int i = 0;
            float max1, max2, max3;
            StreamReader file = new StreamReader(path);
            float[] array = new float[100];
            while ((line = file.ReadLine()) != null)
            {
                searchID = line;
                name = file.ReadLine();
                uni = file.ReadLine();
                dept = file.ReadLine();
                sem = file.ReadLine();
                gpa = file.ReadLine();
                array[i] = float.Parse(gpa);
                i++;

            }
            max1 = array.Max();
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] == max1)
                {
                    array[j] = 0;
                    break;
                }
            }
            max2 = array.Max();
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] == max2)
                {
                    array[j] = 0;
                    break;
                }
            }
            max3 = array.Max();
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] == max3)
                {
                    array[j] = 0;
                    break;
                }
            }
            Console.WriteLine("\n\n\t\tTop 3 CGPA's in class");
            Console.WriteLine("\n\n\t\t1. " + max1);
            Console.WriteLine("\t\t2. " + max2);
            Console.WriteLine("\t\t3. " + max3);
        }
    }
}
