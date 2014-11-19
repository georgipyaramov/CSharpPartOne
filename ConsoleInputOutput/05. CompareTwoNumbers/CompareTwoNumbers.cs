//Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

using System;

class CompareTwoNumbers
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int secondNum = int.Parse(Console.ReadLine());

        int biggerNum = Math.Max(firstNum, secondNum);
        Console.WriteLine("The bigger number is: {0}",biggerNum);
    }
}

