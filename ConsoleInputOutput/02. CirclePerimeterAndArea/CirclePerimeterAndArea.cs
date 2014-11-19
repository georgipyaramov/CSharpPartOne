//Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter the radius r: ");
        float r = float.Parse(Console.ReadLine());

        float p = 2 * (float)Math.PI * r;
        float s = (float)Math.PI * (r * r);

        Console.WriteLine("The perimeter of the circle is: {0}", p);
        Console.WriteLine("The area of the circle is: {0}", s);
    }
}

