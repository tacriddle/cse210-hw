using System;

class Program
{
    static string getUserName(){
        Console.Write("Please enter your name. ");
        string userName;
        userName=Console.ReadLine();
        return userName;
    }

    static int getFavoriteNumber(){
        Console.Write("Please enter your favorite number:");
        int number=0;
        number=int.Parse(Console.ReadLine());
        return number;
    }

    static int squareNumber(int number){
        number=(number*number);
        return number;
    }

    static void displayWelcome(){

        Console.WriteLine("Welcome to the program");
    }
    static void displayResults(string name, int numberSquared){
        Console.WriteLine($"{name}, your favorite number squared is {numberSquared}");
    }
    static void Main(string[] args)
    {
        displayWelcome();
        string name;
        name=getUserName();
        int favoriteNumber=0;
        favoriteNumber=getFavoriteNumber();
        int doubleNumber=0;
        doubleNumber=squareNumber(favoriteNumber);
        displayResults(name, doubleNumber);
    }
}