//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

    class TrapezoidArea
    {
        static void Main()
        {
            Console.Write("Enter the first side A :");
            float trapezA = float.Parse(Console.ReadLine());
            Console.Write("Enter the first side B :");
            float trapezB = float.Parse(Console.ReadLine());
            Console.Write("Enter the height H :");
            float trapezHeightH = float.Parse(Console.ReadLine());

            float trapezArea = ((trapezA + trapezB) * trapezHeightH) / 2;

            Console.WriteLine("The trapezoid's area is: {0}", trapezArea);
        }
    }

