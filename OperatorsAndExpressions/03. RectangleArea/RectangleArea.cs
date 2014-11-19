//Write an expression that calculates rectangle’s area by given width and height.

using System;

class RectangleArea
{
    static void Main()
    {
        Console.Write("Enter the rectangle\'s width: ");
        float width = float.Parse(Console.ReadLine());
        Console.Write("Enter the rectangle\'s height: ");
        float height = float.Parse(Console.ReadLine());

        float area = width * height;

        Console.WriteLine("The rectangle\'s area is: {0}", area);

    }
}

