//Write a program to print the first 100 members of the sequence of Fibonacci:
//0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;

class SequenceOfFibonacci
{
    static void Main()
    {
        decimal firstMember = 0;
        decimal nextMember = 1;
        Console.WriteLine(firstMember);
        Console.WriteLine(nextMember);
        for (decimal i = 0; i < 100; i++)
        {
            decimal temp = firstMember;
            firstMember = nextMember;
            nextMember = temp + nextMember;
            Console.WriteLine(nextMember);
                        
        }
    }
}

