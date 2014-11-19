//Write a program that finds the greatest of given 5 variables.

using System;

    class FindTheGreatestValue
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int firstValue = int.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int secValue = int.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int thirdValue = int.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int fourthValue = int.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int fifthValue = int.Parse(Console.ReadLine());
            int greatestValue = firstValue;

            if (greatestValue < secValue)
            {
                greatestValue = secValue;
            }
            if (greatestValue < thirdValue)
            {
                greatestValue = thirdValue;
            }
            if (greatestValue < fourthValue)
            {
                greatestValue = fourthValue;
            }
            if (greatestValue < fifthValue)
            {
                greatestValue = fifthValue;
            }
            Console.WriteLine("The greatest of the values is: " + greatestValue);

        }
    }

