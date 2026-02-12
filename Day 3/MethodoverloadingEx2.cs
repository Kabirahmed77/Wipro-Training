using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    internal class MethodoverloadingEx2
    {
        public int Sum()
        {
            return 10;
        }
        public int Sum(int x)
        {
            return x+10; 
        }
        public int Sum(int x,int y)
        {
            return x+y; 
        }
        public static void Main()
        {
            MethodoverloadingEx2 methodoverloadingEx2 = new MethodoverloadingEx2();
            Console.WriteLine("sum with Zero args " +methodoverloadingEx2.Sum());
            Console.WriteLine("Sum with one args " + methodoverloadingEx2.Sum(22));
            Console.WriteLine("Sum with two args " + methodoverloadingEx2.Sum(22, 22));
        }
    }
}
