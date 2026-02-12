using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    internal class MethodoverloadingEx1
    {
        public void Show(int x)
        {
            Console.WriteLine("show method of integer " + x);
        }
        public void Show(double x)
        {
            Console.WriteLine("show method of double " + x);
        }
        public void Show(string x)
        {
            Console.WriteLine("show method of string " + x);
        }
        static void Main()
        {
            MethodoverloadingEx1 methodoverloadingEx1 = new MethodoverloadingEx1();
            methodoverloadingEx1.Show(12.5);
            methodoverloadingEx1.Show(12);
            methodoverloadingEx1.Show("wipro");

        }
    }
}
