//In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
//Cn = (2 * n)! / ((n + 1)! * n!)
//Write a program to calculate the Nth Catalan number by given N.

using System;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter number N: ");
        double n = double.Parse(Console.ReadLine());
        double nFact = 1;
        for (int i = 0; i < n; i++)
        {
            nFact = nFact * (i + 1);
        }
        double nByTwo = (n * 2);
        double nByTwoFact = 1;
        for (int i = 0; i < nByTwo; i++)
        {
            nByTwoFact = nByTwoFact * (i + 1);                        
        }
        double nMinusOne = (n - 1);
        double nMinusOneFact = 1;
        for (int i = 0; i < nMinusOne; i++)
        {
            nMinusOneFact = nMinusOneFact * (i + 1);
        }
        
        double cN = nByTwoFact / (nMinusOneFact * nFact);
        Console.WriteLine("Cn = {0}",cN);
        
    }
}

