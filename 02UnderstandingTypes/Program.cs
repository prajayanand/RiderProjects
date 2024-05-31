// See https://aka.ms/new-console-template for more information

using System;

namespace _02UnderstandingTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0,-10} {1,-10} {2,30} {3,30}", "Type", "Bytes", "Min Value", "Max Value");

            DisplayTypeInfo("sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
            DisplayTypeInfo("byte", sizeof(byte), byte.MinValue, byte.MaxValue);
            DisplayTypeInfo("short", sizeof(short), short.MinValue, short.MaxValue);
            DisplayTypeInfo("ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
            DisplayTypeInfo("int", sizeof(int), int.MinValue, int.MaxValue);
            DisplayTypeInfo("uint", sizeof(uint), uint.MinValue, uint.MaxValue);
            DisplayTypeInfo("long", sizeof(long), long.MinValue, long.MaxValue);
            DisplayTypeInfo("ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
            DisplayTypeInfo("float", sizeof(float), float.MinValue, float.MaxValue);
            DisplayTypeInfo("double", sizeof(double), double.MinValue, double.MaxValue);
            DisplayTypeInfo("decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
        }

        static void DisplayTypeInfo(string typeName, int bytes, object minValue, object maxValue)
        {
            Console.WriteLine("{0,-10} {1,-10} {2,30} {3,30}", typeName, bytes, minValue, maxValue);
        }
    }
}
