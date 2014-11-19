/*Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).*/

using System;

class FactorialProduct
{
    static void Main()
    {
        decimal numK;
        decimal numN;
        do
        {
            Console.Write("Enter number N: (must be bigger then 1) ");
            numN = decimal.Parse(Console.ReadLine());

        } while (numN < 1);
        
        do
        {
            Console.Write("Enter number K (must be bigger then N) : ");
            numK = decimal.Parse(Console.ReadLine());
                      
        } while (numK < numN);
        
        Console.WriteLine();
        decimal numNFact = 1;
        decimal numKFact = 1;
        decimal numKNFact = 1;
        for (int i = 1; i <= numN; i++)
        {
            numNFact = numNFact * i;

        }

        for (int i = 1; i <= numK; i++)
        {
            numKFact = numKFact * i;
        }

        for (int i = 1; i <= (numK - numN); i++)
        {
            numKNFact = numKNFact * i;
        }

        decimal result = (numNFact * numKFact) / numKNFact;
        Console.WriteLine("N!*K! / (K-N)! = {0}", result);


    }
}

