using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab_4
{
    internal class StackExample
    {
        public static void Main()
        {
            Stack st = new Stack();
            st.Push("TVS");
            st.Push("KTM");
            st.Push("BAJAJ");
            st.Push("ROYAL ENFIELD");
            st.Push("SUZUKI");
            Console.WriteLine("Stack after adding the data:  ");
            foreach(var item in st)
            {
                Console.WriteLine(item);
            }
            st.Pop();
            st.Pop();
            Console.WriteLine("Stack after removing the data:  ");
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }


        }
    }
}
