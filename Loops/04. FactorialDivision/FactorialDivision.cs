/*Write a program that calculates N!/K! for given N and K (1<K<N).*/

using System;

class FactorialDivision
{
    static void Main()
    {
        decimal numK;
        decimal numN;
        do
        {
            Console.Write("Enter number K: (must be bigger then 1) ");
            numK = decimal.Parse(Console.ReadLine());

        } while (numK < 1);

        do
        {
            Console.Write("Enter number N: (must be bigger then K) : ");
            numN = decimal.Parse(Console.ReadLine());

        } while (numN < numK);
        decimal numNFact = 1;
        decimal numKFact = 1;
        for (int i = 1; i <= numN; i++)
        {
            numNFact = numNFact * i;
            
        }
       
        for (int i = 1; i <= numK; i++)
        {
            numKFact = numKFact * i;
        }

        decimal result = numNFact / numKFact;
        Console.WriteLine("N! / K! = " + result);
    }
}

