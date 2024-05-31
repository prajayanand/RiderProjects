using System;

namespace ConsoleAppArray5
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

            int[] longestSequence = FindLongestSequenceOfEqualElements(array);

            Console.WriteLine("Longest sequence of equal elements:");
            Console.WriteLine(string.Join(" ", longestSequence));
        }

        static int[] FindLongestSequenceOfEqualElements(int[] array)
        {
            int maxLength = 1;
            int currentLength = 1;
            int maxElement = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    currentLength = 1;
                }

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    maxElement = array[i];
                }
            }

            int[] longestSequence = new int[maxLength];
            for (int i = 0; i < maxLength; i++)
            {
                longestSequence[i] = maxElement;
            }

            return longestSequence;
        }
    }
}    