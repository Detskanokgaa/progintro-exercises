using System;

class Program
{
    static void Main()
    {
        byte max = byte.MaxValue;   // 255
        Console.WriteLine("Max value: " + max);

        byte overflow = (byte)(max + 1);
        Console.WriteLine("After adding 1: " + overflow);
    }
}
