using System;


class ExchangingValues
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c;
        c = a;
        a = b;
        b = c;

        Console.WriteLine(a);
        Console.WriteLine(b);


    }
}

