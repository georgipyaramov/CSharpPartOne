//Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 
//and solves it (prints its real roots).

using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter a: ");
        double varA = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double varB = double.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        double varC = double.Parse(Console.ReadLine());
        Console.WriteLine("Your equation is: {0}x^2 + {1}x + {2} = 0", varA, varB, varC);
        double varD = (varB * varB) - (4 * (varA) * (varC));
        double varX1;
        double varX2;
        double varX;

        if (varA != 0 && varD > 0)
        {
            varX1 = (-1 * (varB) + Math.Sqrt(varD)) / (2 * (varA));
            varX2 = (-1 * (varB) - Math.Sqrt(varD)) / (2 * (varA));
            Console.WriteLine("D = {0}", varD);
            Console.WriteLine("The equation has two real roots.");
            Console.WriteLine("x1 = {0}", varX1);
            Console.WriteLine("X2 = {0}", varX2);
        }
        else if (varA != 0 && varD == 0)
        {
            varX = (-1 * (varB)) / (2 * (varA));
            Console.WriteLine("D = {0}", varD);
            Console.WriteLine("The equation has only one real root.");
            Console.WriteLine("x = {0}", varX);
            
        }

        else if (varA == 0 || varD < 0)
        {          
            Console.WriteLine("There are NOT any real roots.");
        }
        
        

    }
}

