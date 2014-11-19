//Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix
using System;

class PrintAMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter number N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        for (int i = 1; i <= n; i++)
        {
            for (int j = 0 + i; j < n + i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}

