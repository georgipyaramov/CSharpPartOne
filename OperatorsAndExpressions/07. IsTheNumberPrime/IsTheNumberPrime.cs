//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

using System;

class IsTheNumberPrime
{
    static void Main()
    {
        Console.Write("Enter a positive number: ");
        int num = int.Parse(Console.ReadLine());

        if ((num % 2 != 0) && (num % 2 == 0) || (num % 3 != 0) && (num % 3 == 0) || (num % 5 != 0) && (num % 5 == 0) || (num % 7 != 0) && (num % 7 == 0))
        {
            Console.WriteLine("The number is NOT prime");
        }
        else
        {
            Console.WriteLine("The number IS prime");
        }
    }
}

