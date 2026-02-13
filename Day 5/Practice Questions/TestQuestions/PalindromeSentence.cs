using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQustions
{
    internal class PalindromeSentence
    {
        static void Main()
        {
            Console.Write("Enter a sentence: ");

            string s = Console.ReadLine().ToLower();

            string cleaned = "";

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                if ((c >= 'a' && c <= 'z') || (c >= '0' && c <= '9'))
                {
                    cleaned += c;
                }
            }

            bool isPalindrome = true;

            int left = 0;

            int right = cleaned.Length - 1;

            while (left < right)
            {
                if (cleaned[left] != cleaned[right])
                {
                    isPalindrome = false;

                    break;

                }
                left++;

                right--;
            }

            Console.WriteLine("Output: " + isPalindrome.ToString().ToLower());
        }
    }
}
        