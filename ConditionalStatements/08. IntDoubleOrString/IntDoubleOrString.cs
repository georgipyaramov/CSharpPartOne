/*Write a program that, depending on the user's choice inputs int, double or string variable. 
 * If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. 
 * The program must show the value of that variable as a console output. Use switch statement.*/

using System;

class IntDoubleOrString
{
    static void Main()
    {
        Console.Write("Enter int, double or string variable: ");
        string userInput = Console.ReadLine();
        int intInput;
        bool isInt = int.TryParse(userInput, out intInput);
        double doubleInput;
        bool isDouble = double.TryParse(userInput, out doubleInput);


        if (isInt)
        {
            intInput = intInput + 1;
            Console.WriteLine(intInput);
        }
        else if (isDouble)
        {
            doubleInput = doubleInput + 1;
            Console.WriteLine(doubleInput);
        }
        else
        {
            Console.WriteLine(userInput + "*");
        }      
        

         
    }
}

