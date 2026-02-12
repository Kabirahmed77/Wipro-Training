using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    internal class Refkeyword2
    {
       public void fact(int x, ref int y)
        {
            for (int i = 1;i<=x;i++)
            {
                y = y * i;
            }
        }
        static void Main()
        {
            Refkeyword2 rk2=new Refkeyword2();
            int x = 6;
            int y = 1;
            rk2.fact(x, ref y);
            Console.WriteLine($"factorial of {x} is {y}");


        }
    }
}
