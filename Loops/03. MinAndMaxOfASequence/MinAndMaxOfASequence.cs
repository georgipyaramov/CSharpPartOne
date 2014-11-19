/*Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.*/

using System;

class MinAndMaxOfASequence
{
    static void Main()
    {
        Console.Write("Enter number N : ");
        int numN = int.Parse(Console.ReadLine());
        int[] sequenceOfInts = new int[numN];
        int maxNum = 0;
        int minNum = 0;

        Console.WriteLine();
        for (int i = 0; i < numN; i++)
        {
            sequenceOfInts[i] = int.Parse(Console.ReadLine());
            
        }
        for (int j = 0; j < numN; j++)
        {
            if (maxNum < sequenceOfInts[j])
            {
                maxNum = sequenceOfInts[j];
            }                        
        }
        
        for (int k = 0; k < numN; k++)
        {
            minNum = maxNum;
            if (minNum > sequenceOfInts[k])
            {
                minNum = sequenceOfInts[k];
            }
        }
        Console.WriteLine();
        Console.WriteLine("The biggest number is: {0}", maxNum);
        Console.WriteLine("The smallest number is: {0}", minNum);
    }
}

