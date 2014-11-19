//Write a program that finds the biggest of three integers using nested if statements.

using System;

class TheBiggestOfThree
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int secNum = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        int thirdNum = int.Parse(Console.ReadLine());
        bool allAreEqu = firstNum == secNum && secNum == thirdNum;
        if (allAreEqu)
        {
            Console.WriteLine();
            Console.WriteLine("The numbers are equal");

        }
        else
        {
            if (firstNum > secNum && firstNum > thirdNum)
            {
                Console.WriteLine();
                Console.WriteLine("The biggest numer is {0}", firstNum);
            }
            else if (secNum > firstNum && secNum > thirdNum)
            {
                Console.WriteLine();
                Console.WriteLine("The biggest numer is {0}", secNum);
            }
            else if (thirdNum > firstNum && thirdNum > secNum)
            {
                Console.WriteLine();
                Console.WriteLine("The biggest numer is {0}", thirdNum);
            }
        }

    }
}

