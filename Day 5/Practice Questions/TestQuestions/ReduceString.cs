using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQustions
{
    internal class ReduceString
    {
        static void Main()
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();

            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine());

            bool found = true;
            while (found)
            {
                found = false;
              
                for (int i = 0; i < str.Length; i++)
                {
                    
                    string target = new string(str[i], k);

                    if (str.Contains(target))
                    {
                        str = str.Replace(target, "");
                        found = true; 
                        break;
                    }
                }
            }

            Console.WriteLine("Output: " + str);
        }
    }
}
