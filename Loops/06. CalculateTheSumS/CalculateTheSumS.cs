/*Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X^2 + … + N!/X^N */

using System;

class CalculateTheSumS
{
    static void Main()
    {
        Console.Write("Enter number N: ");
        int numN = int.Parse(Console.ReadLine());
        Console.Write("Enter number X: ");
        int numX = int.Parse(Console.ReadLine());
        int[] nominator = new int[numN];
        int nominatorFact = 1;
        int k = 0;
        decimal sumS = 1;
        decimal[] nomAndDenom = new decimal[numN];

        for (int i = 1; i <= numN; i++)
        {
            nominator[(i - 1)] = i;
        }
        

        decimal[] nominatorFactArr = new decimal[numN];

        for (int i = 1; i <= numN; i++)
        {

            nominatorFact = nominatorFact * i;
            nominatorFactArr[k] = nominatorFact;
            k++;
            
        }
        
        for (int i = 0; i < numN; i++)
        {
            nomAndDenom[i] = (decimal)(nominatorFactArr[i]) / (decimal)Math.Pow(numX, nominator[i]);
           
           
        }
        for (int i = 0; i < numN; i++)
        {
            sumS = sumS + nomAndDenom[i];
        }
        Console.WriteLine();
        Console.WriteLine("The sum S = " + sumS);
    }
}

