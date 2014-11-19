//A company has name, address, phone number, fax number, web site and manager. 
//The manager has first name, last name, age and a phone number. 
//Write a program that reads the information about a company and its manager and prints them on the console.

using System;

class CommpanyAndManagerInfo
{
    static void Main()
    {
        Console.Write("Enter the commpany's name: ");
        string commName = Console.ReadLine();
        Console.Write("Enter the commpany's address: ");
        string commAdrress = Console.ReadLine();
        Console.Write("Enter the commpany's phone number: ");
        string commPhoneNum = Console.ReadLine();
        Console.Write("Enter the commpany's fax number: ");
        string commFaxNum = Console.ReadLine();
        Console.Write("Enter the commpany's web site: ");
        string commWebSite = Console.ReadLine();
        Console.Write("Enter the manager's first name: ");
        string manFirstName = Console.ReadLine();
        Console.Write("Enter the manager's last name: ");
        string manLastName = Console.ReadLine();
        Console.Write("Enter the manager's age: ");
        string manAge = Console.ReadLine();
        Console.Write("Enter the manager's phone number: ");
        string manPhoneNum = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Commpany's information:");
        Console.WriteLine(commName);
        Console.WriteLine(commAdrress);
        Console.WriteLine(commPhoneNum);
        Console.WriteLine(commFaxNum);
        Console.WriteLine(commWebSite);
        Console.WriteLine();
        Console.WriteLine("Manager's information:");
        Console.WriteLine(manFirstName);
        Console.WriteLine(manLastName);
        Console.WriteLine(manAge);
        Console.WriteLine(manPhoneNum);
    }
}

