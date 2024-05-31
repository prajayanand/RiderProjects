using System;

namespace ConsoleAppStrings1
{
    class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
        
            // 1: Using char array reversal
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);
            Console.WriteLine(reversedString);

            // 2: Using for loop
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
            Console.WriteLine();
        }
    }

}    