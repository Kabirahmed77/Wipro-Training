using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    static class StaticClassEx
    {
        public static void Show()
        {
            Console.WriteLine("Wipro training.......");
        }
        public static void Student()
        {
            Console.WriteLine("Kabir is the Student.....");
        }
        internal class StaticEx
        {
            public static void Main()
            {
                StaticClassEx.Show();
                StaticClassEx.Student();
            }
        }
    }
}
