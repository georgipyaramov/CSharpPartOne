//Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3)
//and out of the rectangle R(top=1, left=-1, width=6, height=2).
using System;

class CoordinatesCheck
{
    static void Main()
    {

        Console.Write("Enter the coordnate x : ");
        float coordX = float.Parse(Console.ReadLine());
        Console.Write("Enter the coordnate y : ");
        float coordY = float.Parse(Console.ReadLine());
        float circleStartCoordX = 1;
        float circleStartCoordy = 1;
        float radius = 3;
        //coordinates if the rectangle
        float rectangleX = -1;
        float rectangleY = 1;
        float rectangleHeight = 2;
        float rectangleWidth = 6;
        bool inCircle = (Math.Sqrt(((coordX - circleStartCoordX) * (coordX - circleStartCoordX))
             + (coordY - circleStartCoordy) * (coordY - circleStartCoordy))) < radius; //-1 to the coordinates because the circle is at x=1 , y=1
        bool outRect = ((coordX < rectangleX) || (coordX > rectangleX + rectangleWidth) || (coordY > rectangleY) || (coordY < rectangleY - rectangleHeight));
        if (inCircle && outRect)
        {
            Console.WriteLine("The coordinates are in the circle and out of the rectangle. -> {0}", (inCircle && outRect));
        }
        else
        {
            Console.WriteLine("The coordinates are in the circle and out of the rectangle. -> {0}", (inCircle && outRect));
        }
    }
}
