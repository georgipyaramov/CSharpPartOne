using System;


class TriangleOfCopyrightSymbols
{
    static void Main()
    {
        char copyrightsym = '\u00A9';
        Console.WriteLine("   {0}", copyrightsym);
        Console.WriteLine("  {0} {0} {0}", copyrightsym);
        Console.WriteLine(" {0} {0} {0} {0} {0}", copyrightsym);

    }
}
