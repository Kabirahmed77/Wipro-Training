using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    internal class RefKeyword1
    {
      public void Show(ref int z)
        {
            z++;
        }
        public static void Main()
        {
            RefKeyword1 rk=new RefKeyword1();
            int z = 15;
            rk.Show(ref z);
            Console.WriteLine(z);
        }


        
    }
}
