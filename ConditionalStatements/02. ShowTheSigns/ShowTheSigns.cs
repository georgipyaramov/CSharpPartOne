//Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. 
//Use a sequence of if statements.

using System;

class ShowTheSigns
{
    static void Main()
    {
        float firstNum = float.Parse(Console.ReadLine());
        float secNum = float.Parse(Console.ReadLine());
        float thirdNum = float.Parse(Console.ReadLine());
        bool firstNumIsNeg = firstNum < 0;
        bool secNumIsNeg = secNum < 0;
        bool thirdNumIsNeg = thirdNum < 0;
        bool firstNumIsPos = firstNum > 0;
        bool secNumIsPos = secNum > 0;
        bool thirdNumIsPos = thirdNum > 0;

        if (firstNumIsNeg  && secNumIsNeg && thirdNumIsNeg)
        {
            Console.WriteLine("The sign of the product is \"-\"");
        }
        else if (firstNumIsPos && secNumIsPos && thirdNumIsPos)
        {
            Console.WriteLine("The sign of the product is \"+\"");
        }
        else if (firstNumIsNeg && secNumIsPos && thirdNumIsPos)
        {
            Console.WriteLine("The sign of the product is \"-\"");

        }
        else if (firstNumIsPos && secNumIsNeg && thirdNumIsPos)
        {
            Console.WriteLine("The sign of the product is \"-\"");
        }
        else if (firstNumIsPos && secNumIsPos && thirdNumIsNeg)
        {
            Console.WriteLine("The sign of the product is \"-\"");
        }
        else if (firstNumIsNeg && secNumIsNeg && thirdNumIsPos)
        {
            Console.WriteLine("The sign of the product is \"+\"");
        }
        else if (firstNumIsNeg && secNumIsPos && thirdNumIsNeg)
        {
            Console.WriteLine("The sign of the product is \"+\"");
        }
        else if (firstNumIsPos && secNumIsNeg && thirdNumIsNeg)
        {
            Console.WriteLine("The sign of the product is \"+\"");
        }
    }
}

