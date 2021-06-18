using System;
using System.Text.RegularExpressions;

namespace Exercise2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            SearchWord();
        }

        private static void SearchWord()
        {
            int count = 0;
            Console.WriteLine("Enter a String");
            string srt = Console.ReadLine();
            Console.WriteLine("Enter a word to search");
            string word = Console.ReadLine();
            string[] c = srt.Split();
            for (int i = 0; i < c.Length; i++)
            {
                if (word != null && word.Equals(c[i]))
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"Word found {count} time in the string");
        }
    }
}
