//Write a program that reads 3 integer numbers from the console and prints their sum.

using System;

class ReadNumsFromTheConsole
{
    static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int thirdNum = int.Parse(Console.ReadLine());

        Console.WriteLine(firstNum + secondNum + thirdNum);

    }
}

