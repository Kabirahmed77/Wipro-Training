using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExQuestions
{
    internal class PalindromeWordCount
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentence:");
            string input = Console.ReadLine();

            
            string[] words = input.Split(' ');

            int count = 0;

            
            foreach (string word in words)
            {
                
                string lowerWord = word.ToLower();

                
                string reversedWord = "";
                for (int i = lowerWord.Length - 1; i >= 0; i--)
                {
                    reversedWord = reversedWord + lowerWord[i];
                }

                
                if (lowerWord == reversedWord)
                {
                    count++;
                }
            }

            
            Console.WriteLine("Total Count of Palindrome Words : " + count);

            Console.ReadLine(); 
        }
    }
}
