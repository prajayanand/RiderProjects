using System;

namespace ConsoleAppArrays4
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

            Console.WriteLine("Enter the number of rotations:");
            int k = int.Parse(Console.ReadLine());

            int[] sumArray = new int[array.Length];

            for (int r = 1; r <= k; r++)
            {
                int[] rotatedArray = RotateRight(array, r);

                // Sum the rotated array into sumArray
                for (int i = 0; i < array.Length; i++)
                {
                    sumArray[i] += rotatedArray[i];
                }

                // Display the rotated array for debugging purposes
                Console.WriteLine("Rotated " + r + ": " + string.Join(" ", rotatedArray));
            }

            Console.WriteLine("Sum array:");
            Console.WriteLine(string.Join(" ", sumArray));
        }

        static int[] RotateRight(int[] array, int rotations)
        {
            int n = array.Length;
            int[] rotatedArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                rotatedArray[(i + rotations) % n] = array[i];
            }

            return rotatedArray;
        }
    }
}    