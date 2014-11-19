using System;


class StringAndObject
{
    static void Main()
    {
        string a = "Hallo";
        object b = "World";
        Console.WriteLine(a + " " + (string)b);

    }
}

