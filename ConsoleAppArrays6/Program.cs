using System;

namespace ConsoleAppArrays6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the array of integers (space separated):");
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ');
            int[] array = new int[inputArray.Length];
            
            for (int i = 0; i < inputArray.Length; i++)
            {
                array[i] = int.Parse(inputArray[i]);
            }

            int mostFrequent = FindMostFrequentNumber(array);
            
            Console.WriteLine($"The number {mostFrequent} is the most frequent.");
        }

        static int FindMostFrequentNumber(int[] array)
        {
            int[] uniqueNumbers = new int[array.Length];
            int[] frequencies = new int[array.Length];
            int uniqueCount = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int num = array[i];
                int index = Array.IndexOf(uniqueNumbers, num, 0, uniqueCount);

                if (index == -1)
                {
                    uniqueNumbers[uniqueCount] = num;
                    frequencies[uniqueCount] = 1;
                    uniqueCount++;
                }
                else
                {
                    frequencies[index]++;
                }
            }

            int maxFrequency = 0;
            int mostFrequent = uniqueNumbers[0];

            for (int i = 0; i < uniqueCount; i++)
            {
                if (frequencies[i] > maxFrequency)
                {
                    maxFrequency = frequencies[i];
                    mostFrequent = uniqueNumbers[i];
                }
            }

            return mostFrequent;
        }
    }
}    