/** Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. 
 * Examples:
	0  "Zero"
	273  "Two hundred seventy three"
	400  "Four hundred"
	501  "Five hundred and one"
	711  "Seven hundred and eleven" */

using System;

class ConvertingNumberToText
{
    static void Main()
    {
        Console.WriteLine("Please enter a number: ");
        string and = "and ";
        string num = Console.ReadLine();

        string firstDig = Convert.ToString(num[0]);
        int? firstDigit = int.Parse(firstDig);

        int? secDigit = 0;

        if (num.Length >= 2)
        {
            string secDig = Convert.ToString(num[1]);
            secDigit = int.Parse(secDig);
        }
        int? thirdDigit = 0;

        if (num.Length == 3)
        {
            string thirdDig = Convert.ToString(num[2]);
            thirdDigit = int.Parse(thirdDig);
        }
        if (num.Length == 2)
        {

            thirdDigit = secDigit;
            secDigit = firstDigit;
            firstDigit = null;

        }
        if (num.Length == 1)
        {
            thirdDigit = firstDigit;
            secDigit = null;
            firstDigit = null;

        }


        Console.Write("{0}{1}{2}  ->   ", firstDigit, secDigit, thirdDigit);

        string firstDigOutput;
        string secDigitOutput;
        string thirdDigitOutput;
        string teensOutput;

        switch (firstDigit)
        {
            case 1:
                firstDigOutput = "One hundred ";
                Console.Write(firstDigOutput);
                break;
            case 2:
                firstDigOutput = "Two hundred ";
                Console.Write(firstDigOutput);
                break;
            case 3:
                firstDigOutput = "Three hundred ";
                Console.Write(firstDigOutput);
                break;
            case 4:
                firstDigOutput = "Four hundred ";
                Console.Write(firstDigOutput);
                break;
            case 5:
                firstDigOutput = "Five hundred ";
                Console.Write(firstDigOutput);
                break;
            case 6:
                firstDigOutput = "Six hundred ";
                Console.Write(firstDigOutput);
                break;
            case 7:
                firstDigOutput = "Seven hundred ";
                Console.Write(firstDigOutput);
                break;
            case 8:
                firstDigOutput = "Eight hundred ";
                Console.Write(firstDigOutput);
                break;
            case 9:
                firstDigOutput = "Nine hundred ";
                Console.Write(firstDigOutput);
                break;
            default:
                break;
        }

        if (thirdDigit != 0)
        {
            switch (secDigit)
            {
                case 1:
                    switch (thirdDigit)
                    {

                        case 0:
                            teensOutput = "ten";
                            Console.WriteLine(and + teensOutput);
                            break;
                        case 1:
                            teensOutput = "eleven ";
                            Console.WriteLine(and + teensOutput);
                            break;
                        case 2:
                            teensOutput = "twelve ";
                            Console.WriteLine(and + teensOutput);
                            break;
                        case 3:
                            teensOutput = "thirteen ";
                            Console.WriteLine(and + teensOutput);
                            break;
                        case 4:
                            teensOutput = "fourteen ";
                            Console.WriteLine(and + teensOutput);
                            break;
                        case 5:
                            teensOutput = "fifteen ";
                            Console.WriteLine(and + teensOutput);
                            break;
                        case 6:
                            teensOutput = "sixteen ";
                            Console.WriteLine(and + teensOutput);
                            break;
                        case 7:
                            teensOutput = "seventeen ";
                            Console.WriteLine(and + teensOutput);
                            break;
                        case 8:
                            teensOutput = "eighteen ";
                            Console.WriteLine(and + teensOutput);
                            break;
                        case 9:
                            teensOutput = "ninteen ";
                            Console.WriteLine(and + teensOutput);
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    secDigitOutput = "twenty ";
                    Console.Write(secDigitOutput);
                    break;
                case 3:
                    secDigitOutput = "thrity ";
                    Console.Write(secDigitOutput);
                    break;
                case 4:
                    secDigitOutput = "fourty ";
                    Console.Write(secDigitOutput);
                    break;
                case 5:
                    secDigitOutput = "fifty ";
                    Console.Write(secDigitOutput);
                    break;
                case 6:
                    secDigitOutput = "sixty ";
                    Console.Write(secDigitOutput);
                    break;
                case 7:
                    secDigitOutput = "seventy ";
                    Console.Write(secDigitOutput);
                    break;
                case 8:
                    secDigitOutput = "eighty ";
                    Console.Write(secDigitOutput);
                    break;
                case 9:
                    secDigitOutput = "ninty ";
                    Console.Write(secDigitOutput);
                    break;
                default:
                    break;
            }
        }
        else
        {
            switch (secDigit)
            {
                case 1:
                    switch (thirdDigit)
                    {

                        case 0:
                            teensOutput = "ten";
                            Console.WriteLine(and + teensOutput);
                            break;
                        case 1:
                            teensOutput = "eleven ";
                            Console.WriteLine(and + teensOutput);
                            break;
                        case 2:
                            teensOutput = "twelve ";
                            Console.WriteLine(and + teensOutput);
                            break;
                        case 3:
                            teensOutput = "thirteen ";
                            Console.WriteLine(and + teensOutput);
                            break;
                        case 4:
                            teensOutput = "fourteen ";
                            Console.WriteLine(and + teensOutput);
                            break;
                        case 5:
                            teensOutput = "fifteen ";
                            Console.WriteLine(and + teensOutput);
                            break;
                        case 6:
                            teensOutput = "sixteen ";
                            Console.WriteLine(and + teensOutput);
                            break;
                        case 7:
                            teensOutput = "seventeen ";
                            Console.WriteLine(and + teensOutput);
                            break;
                        case 8:
                            teensOutput = "eighteen ";
                            Console.WriteLine(and + teensOutput);
                            break;
                        case 9:
                            teensOutput = "ninteen ";
                            Console.WriteLine(and + teensOutput);
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    secDigitOutput = "twenty ";
                    Console.Write(and + secDigitOutput);
                    break;
                case 3:
                    secDigitOutput = "thrity ";
                    Console.Write(and + secDigitOutput);
                    break;
                case 4:
                    secDigitOutput = "fourty ";
                    Console.Write(and + secDigitOutput);
                    break;
                case 5:
                    secDigitOutput = "fifty ";
                    Console.Write(and + secDigitOutput);
                    break;
                case 6:
                    secDigitOutput = "sixty ";
                    Console.Write(and + secDigitOutput);
                    break;
                case 7:
                    secDigitOutput = "seventy ";
                    Console.Write(and + secDigitOutput);
                    break;
                case 8:
                    secDigitOutput = "eighty ";
                    Console.Write(and + secDigitOutput);
                    break;
                case 9:
                    secDigitOutput = "ninty ";
                    Console.Write(and + secDigitOutput);
                    break;
                default:
                    break;
            }
        }
        if (secDigit != 1)
        {
            switch (thirdDigit)
            {

                case 1:
                    thirdDigitOutput = "one ";
                    Console.WriteLine(thirdDigitOutput);
                    break;
                case 2:
                    thirdDigitOutput = "two ";
                    Console.WriteLine(thirdDigitOutput);
                    break;
                case 3:
                    thirdDigitOutput = "three ";
                    Console.WriteLine(thirdDigitOutput);
                    break;
                case 4:
                    thirdDigitOutput = "four ";
                    Console.WriteLine(thirdDigitOutput);
                    break;
                case 5: thirdDigitOutput = "five ";
                    Console.WriteLine(thirdDigitOutput);
                    break;
                case 6: thirdDigitOutput = "six ";
                    Console.WriteLine(thirdDigitOutput);
                    break;
                case 7:
                    thirdDigitOutput = "seven ";
                    Console.WriteLine(thirdDigitOutput);
                    break;
                case 8:
                    thirdDigitOutput = "eight ";
                    Console.WriteLine(thirdDigitOutput);
                    break;
                case 9:
                    thirdDigitOutput = "nine ";
                    Console.WriteLine(thirdDigitOutput);
                    break;
                default:
                    break;
            }
        }
        if (thirdDigit == 0 && num.Length == 1)
        {
            Console.WriteLine("Zero");
        }
    }
}

