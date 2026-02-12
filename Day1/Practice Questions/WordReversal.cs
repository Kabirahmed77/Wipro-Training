using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExQuestions
{
    internal class WordReversal
    {
        public WordReversal()
        {

        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentence:");
            string input=Console.ReadLine();

            if (string.IsNullOrEmpty(input))
                return;
            string[]words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if(i%2!=0)
                {
                    char[] charArray = words[i].ToCharArray();
                    Array.Reverse(charArray);
                    words[i] = new string(charArray);
                }
            }
            string result = string.Join(" ", words);
            Console.WriteLine(result);
            Console.ReadLine(); 

        }
    }
}
