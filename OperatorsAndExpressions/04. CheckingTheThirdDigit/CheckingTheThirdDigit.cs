//Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.

using System;

class CheckingTheThirdDigit
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        if ((num / 100) % 10 == 7)
        {
            Console.WriteLine("The third digit IS 7");
        }
        else
        {
            Console.WriteLine("The third digit IS NOT 7");
        }
    }
}

