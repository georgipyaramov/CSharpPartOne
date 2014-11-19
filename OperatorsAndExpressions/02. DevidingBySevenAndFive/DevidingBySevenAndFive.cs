//Write a boolean expression that checks for given integer if it can be divided 
//(without remainder) by 7 and 5 in the same time.

using System;


class DevidingBySevenAndFive
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        if (num % 5 == 0 && num % 7 == 0)
        {
            Console.WriteLine("The number CAN be devided by 5 and by 7");            
        }
        else
        {
            Console.WriteLine("The number CANNOT be devidet by 5 and by 7");
        }
    }
}

