//Sort 3 real values in descending order using nested if statements.

using System;

class SortThreeNumbers
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        float firstNum = float.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        float secNum = float.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        float thirdNum = float.Parse(Console.ReadLine());

        if (firstNum > secNum && firstNum > thirdNum)
        {
            if (secNum > thirdNum)
            {
                Console.WriteLine(firstNum);
                Console.WriteLine(secNum);
                Console.WriteLine(thirdNum);
            }
            else
            {
                Console.WriteLine(firstNum);
                Console.WriteLine(thirdNum);
                Console.WriteLine(secNum);
            }
        }

        if (secNum > firstNum && secNum > thirdNum)
        {
            if (firstNum > thirdNum)
            {
                Console.WriteLine(secNum);
                Console.WriteLine(firstNum);
                Console.WriteLine(thirdNum);
            }
            else
            {
                Console.WriteLine(secNum);
                Console.WriteLine(thirdNum);
                Console.WriteLine(firstNum);
            }
                       
        }

        if (thirdNum > firstNum && thirdNum > secNum)
        {
            if (firstNum > secNum)
            {
                Console.WriteLine(thirdNum);
                Console.WriteLine(firstNum);
                Console.WriteLine(secNum);
            }
            else
            {
                Console.WriteLine(thirdNum);
                Console.WriteLine(secNum);
                Console.WriteLine(firstNum);
            }
        }



    }
}

