//Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

using System;

class CalulatingNNumbers
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        float firstN = float.Parse(Console.ReadLine());
        float sumOfManyN;
        Console.Write("Enter a number: ");
        float moreN = float.Parse(Console.ReadLine());
        sumOfManyN = firstN + moreN;
       
        do
        
        {
            Console.Write("Enter a number: ");
            moreN = float.Parse(Console.ReadLine());
            sumOfManyN = sumOfManyN + moreN;
            Console.WriteLine("Please press the \"+\" button to enter another number \nor press the \"spacebar\" to get the result.");


        } while (Console.ReadKey(true).Key != ConsoleKey.Spacebar);         /*There is a delay because the program asks for a key 
                                                                              and check if it is the spacebar key.*/
        Console.WriteLine();
        Console.WriteLine("The sum of the numbers is: {0}", sumOfManyN);

        /*I wanted to write a program that can gather infinite number of numbers, without limitations.
          It surly can be done better, but I think it's OK.*/

    }
}

