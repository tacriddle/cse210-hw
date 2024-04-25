using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name?");
        string tacFirstName= Console.ReadLine();
        Console.Write("What is your last name?");
        string tacLastName=Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"Your name is {tacLastName}, {tacFirstName} {tacLastName}.");
    }
}