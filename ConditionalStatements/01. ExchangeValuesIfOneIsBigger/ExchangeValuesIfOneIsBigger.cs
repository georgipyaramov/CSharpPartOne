//Write an if statement that examines two integer variables and exchanges their values 
//if the first one is greater than the second one.

using System;

class ExchangeValuesIfOneIsBigger
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int secNum = int.Parse(Console.ReadLine());
        int temp;

        if (firstNum > secNum)
        {
            temp = secNum;
            secNum = firstNum;
            firstNum = temp;
            Console.WriteLine(firstNum + " " + secNum);

        }
        else
        {
            Console.WriteLine(firstNum + " " + secNum);
        }

    }
}

