using System;
using System.Collections.Generic;

namespace ConsoleAppStrings3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a sentence:");
            string input = Console.ReadLine();

            string[] palindromes = ExtractPalindromes(input);

            Console.WriteLine("Palindromes:");
            Console.WriteLine(string.Join(", ", palindromes));
        }

        static string[] ExtractPalindromes(string input)
        {
            HashSet<string> uniquePalindromes = new HashSet<string>();
            List<string> words = new List<string>();
            char[] delimiters = { ' ', ',', '.', ';', ':', '(', ')', '&', '[', ']', '\"', '\'', '\\', '/', '!', '?' };

            string[] parts = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in parts)
            {
                if (IsPalindrome(word))
                {
                    uniquePalindromes.Add(word);
                }
            }

            words.AddRange(uniquePalindromes);
            words.Sort();

            return words.ToArray();
        }

        static bool IsPalindrome(string word)
        {
            int length = word.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (word[i] != word[length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}    