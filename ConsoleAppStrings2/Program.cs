using System;
using System.Text;

namespace ConsoleAppStrings2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a sentence:");
            string input = Console.ReadLine();
            
            string reversedSentence = ReverseWords(input);
            
            Console.WriteLine("Reversed sentence:");
            Console.WriteLine(reversedSentence);
        }

        static string ReverseWords(string input)
        {
            StringBuilder word = new StringBuilder();
            StringBuilder result = new StringBuilder();
            StringBuilder separator = new StringBuilder();
            
            bool inWord = char.IsLetterOrDigit(input[0]);
            
            foreach (char c in input)
            {
                if (IsSeparator(c))
                {
                    if (inWord)
                    {
                        result.Insert(0, word.ToString() + separator.ToString());
                        word.Clear();
                        separator.Clear();
                    }
                    separator.Append(c);
                    inWord = false;
                }
                else
                {
                    if (!inWord)
                    {
                        result.Insert(0, separator.ToString());
                        separator.Clear();
                    }
                    word.Append(c);
                    inWord = true;
                }
            }
            
            if (word.Length > 0)
            {
                result.Insert(0, word.ToString());
            }
            
            if (separator.Length > 0)
            {
                result.Append(separator.ToString());
            }

            return result.ToString();
        }

        static bool IsSeparator(char c)
        {
            return " .,;=()&[]\"'\\/!?".IndexOf(c) >= 0;
        }
    }
}    