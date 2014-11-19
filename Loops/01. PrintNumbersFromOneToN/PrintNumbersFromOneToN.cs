//Write a program that prints all the numbers from 1 to N.

using System;

class PrintNumbersFromOneToN
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int numN = int.Parse(Console.ReadLine());
        Console.WriteLine();
        for (int i = 1; i <= numN; i++)
        {            
            Console.WriteLine(i);
        }
    }
}

