//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

using System;

class TheThirdBit
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int givenNum = int.Parse(Console.ReadLine());
        int p = 3;
        int mask = 1 << p;
        int numAndMask = givenNum & mask;
        int bit = numAndMask >> p;

        Console.WriteLine(bit == 1);
    }
}

