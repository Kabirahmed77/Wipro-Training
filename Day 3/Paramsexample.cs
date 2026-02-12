using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    internal class Paramsexample
    {
        public void Attendance(int DayNo,params string[] students)
        {
            Console.WriteLine("Day: " + DayNo + "  ");
            foreach(var student in students)
            {
                Console.Write(student+"  ");
            }
            Console.WriteLine();
        }
        static void Main()
        {
            Paramsexample paramsexample = new Paramsexample();
            paramsexample.Attendance(1,"Kabir", "Rohan", "rahul");
            paramsexample.Attendance(2, "Ganesh", "Yash", "Harsh", "Kishore");
            paramsexample.Attendance(3, "Tushar", "Uday", "Yash", "Eshwar", "Rithwik", "Vinay");

        }   
    }
}
