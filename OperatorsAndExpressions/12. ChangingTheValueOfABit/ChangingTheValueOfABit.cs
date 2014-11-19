//We are given integer number n, value v (v=0 or 1) and a position p. 
//Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.

using System;

class ChangingTheValueOfABit
{
    static void Main()
    {
        Console.Write("Enter a number n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the position of the bit: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter the value of the bit: ");
        int v = int.Parse(Console.ReadLine());
        if (v == 0)
        {
            int mask = ~(1 << p);
            int result = n & mask;
            Console.WriteLine(n + " " + "(" + Convert.ToString(n, 2).PadLeft(8, '0') + ")");
            Console.WriteLine(result + " " + "(" + Convert.ToString(result, 2).PadLeft(8, '0') + ")");
        }
        else
        {
            int secMask = 1 << p;
            int secResult = n | secMask;
            Console.WriteLine(n + " " + "(" + Convert.ToString(n, 2).PadLeft(8, '0') + ")");
            Console.WriteLine(secResult + " " + "(" + Convert.ToString(secResult, 2).PadLeft(8, '0') + ")");
        }
       


    }
}

