//Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2  value=1.

using System;

class WhatIsTheGivenBit
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int i = int.Parse(Console.ReadLine());
        Console.Write("Enter the position of the bit: ");
        int b = int.Parse(Console.ReadLine());
        int mask = 1 << b;
        int iAndMask = i & mask;
        int bit = iAndMask >> b;
        Console.WriteLine("i={0}; b={1} -> value={2}", i, b, bit);

    }
}

