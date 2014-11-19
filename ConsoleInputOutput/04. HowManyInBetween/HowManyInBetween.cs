//Write a program that reads two positive integer numbers and prints how many numbers p exist 
//between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

using System;

class HowManyInBetween
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        uint firstNum = uint.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        uint secNum = uint.Parse(Console.ReadLine());

        
        uint addedNum = 0;

        if (firstNum % 5 == 0)
        {
            addedNum++;
        }

        if (secNum % 5 == 0)
        {
            addedNum++;
        }
        uint maxNum = Math.Max(firstNum, secNum);
        uint minNum = Math.Min(firstNum, secNum);
        uint minAndMax = maxNum - (minNum + 1);
        uint tempNum = minAndMax / 5;
        uint p = addedNum + tempNum;


        Console.WriteLine("p({0},{1}) = {2}", firstNum, secNum, p);

        
        

    }
}

