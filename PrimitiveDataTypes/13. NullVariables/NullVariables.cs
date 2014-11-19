using System;


class NullVariables
{
    static void Main()
    {
        int? i = null;
        float? f = null;
        Console.WriteLine(i);
        Console.WriteLine(f);

        i = 10;
        f = 20;
        Console.WriteLine(i);
        Console.WriteLine(f);

    }
}

