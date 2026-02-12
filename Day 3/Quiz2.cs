using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    internal class Quiz2
    {
        public void Show(object x)
        {
            System.Console.WriteLine("Show th output w.r.t object " + x);    
        }
        public void Show(double x)
        {
            System.Console.WriteLine("Show the ouptut w.r.t double " + x);
        }
        static void Main()
        {
            Quiz2 q2=new Quiz2();
            q2.Show(10);    
        }
    }
}
