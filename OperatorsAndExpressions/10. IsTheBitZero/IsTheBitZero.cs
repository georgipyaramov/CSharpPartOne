//Write a boolean expression that returns if the bit at position p (counting from 0) in a given 
//integer number v has value of 1. Example: v=5; p=1  false.

using System;

class IsTheBitZero
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int v = int.Parse(Console.ReadLine());
        Console.Write("Enter a position of the bit: ");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int vAndMask = v & mask;
        int bit = vAndMask >> p;
        if (bit == 1)
        {
            Console.WriteLine("v={0}, p={1} -> True", v, p);
        }
        else
        {
            Console.WriteLine("v={0}, p={1} -> False", v, p);
        }
 
    }
}

