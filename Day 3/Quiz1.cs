using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    internal class Quiz1
    {
        //public int Display(int x)
        //{
          //  Console.WriteLine("Display the answer if it is integer"+x);
          //  return x;
        //}
        public double Display(double x)
        {
            Console.WriteLine("Display if the answer is Double" + x);
            return x;
        }
        public string Display(string x)
        {
            Console.WriteLine("Display if the answer is String" + x);
            return x;
        }
        public void Display(object x)
        {
            Console.WriteLine("Display if the answer is Object" + x);

        }
        public static void Main()
        {
            Quiz1 q=new Quiz1();
            q.Display(10);
        }
        
    }
}
