/*Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci:
 * 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.*/

using System;

class SumOfFibonaccisNums
{
    static void Main()
    {
        Console.Write("Enter number N: ");
        int n = int.Parse(Console.ReadLine());
        decimal firstMem = 0;
        decimal nextMem = 1;
        decimal[] fibArr = new decimal[n];
        decimal sumOfFirstNMem = 0;
        for (int i = 0; i < n - 2; i++)
        {
            decimal tempMem;
            tempMem = firstMem;
            firstMem = nextMem;
            nextMem = tempMem + nextMem;
            fibArr[0] = 0;
            fibArr[1] = 1;
            fibArr[i + 2] = nextMem;                       
        }
        
        for (int j = 0; j < n; j++)
        {
            sumOfFirstNMem = sumOfFirstNMem + fibArr[j];
        }
        Console.WriteLine(sumOfFirstNMem);
        
    }
}

