using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TestQustions
{
    internal class FirstNonRepeatingChar
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string s= Console.ReadLine();

            int[] charCount = new int[256];
            for (int i = 0; i < s.Length; i++)
            {
                charCount[s[i]]++;
            }

            char result = '$';
            for (int i = 0;i < s.Length;i++)
            {
                if (charCount[s[i]]==1)
                {
                    result = s[i];
                    break;
                }
            }
            Console.WriteLine("Output:" + result);
         
        }
    }
}
