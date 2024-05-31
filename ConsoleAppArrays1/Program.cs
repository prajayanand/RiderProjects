using System;

namespace ConsoleAppArrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an initial array with 10 items
            int[] originalArray = new int[10];

            // Populate the original array with some values
            for (int i = 0; i < originalArray.Length; i++)
            {
                originalArray[i] = i + 1; // Example: 1, 2, 3, ..., 10
            }

            // Print the original array
            Console.WriteLine("Original Array:");
            PrintArray(originalArray);

            // Create a second array with the same length as the original array
            int[] copiedArray = new int[originalArray.Length];

            // Copy values from the original array to the new array
            for (int i = 0; i < originalArray.Length; i++)
            {
                copiedArray[i] = originalArray[i];
            }

            // Print the copied array
            Console.WriteLine("\nCopied Array:");
            PrintArray(copiedArray);
        }

        // Method to print the contents of an array
        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}