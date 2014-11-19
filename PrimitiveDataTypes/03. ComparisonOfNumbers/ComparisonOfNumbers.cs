using System;

class ComparisonOfNumbers
{
    static void Main()
    {
        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());

        double differNum = firstNum - secondNum;

        if (differNum < 0.000001)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }




    }
}

