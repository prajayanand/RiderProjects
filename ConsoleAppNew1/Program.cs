using System;
// Byte overflow
//What happens if we run given code - 
// When running this code it will enter into an infinite loop. 
// Because a byte data type can only hold values from 0 to 255.
// Once it reaches 255, it will overflow and reset to 0 and loop the same again and again.
// To warn, we can add if condition as a check by example : max>byte then print warning
namespace ConsoleAppNew1
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 500;
            for (byte i = 0; i < max; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}