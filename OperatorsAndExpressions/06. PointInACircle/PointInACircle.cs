//Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

using System;

class PointInACircle
{
    static void Main()
    {
        Console.WriteLine("Enter the coordinates X and Y: ");
        float coordX = float.Parse(Console.ReadLine());
        float coordY = float.Parse(Console.ReadLine());
        float radiusR = 5;

        if (Math.Sqrt((coordX * coordX) + (coordY * coordY)) < radiusR)
        {
            Console.WriteLine("The coordinates ({0},{1}) are IN the circle (0,{2})", coordX, coordY, radiusR);
        }
        else
        {
            Console.WriteLine("The coordinates ({0},{1}) are NOT in the circle (0,{2})", coordX, coordY, radiusR);
        }
    }
}

