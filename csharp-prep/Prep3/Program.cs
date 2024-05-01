using System;

class Program
{
    static void Main(string[] args)
    {
        int magicWord;
        Console.Write("What is the magic number: ");
        magicWord=int.Parse(Console.ReadLine());
        int guess=(0);
        while (guess != magicWord){
            Console.Write("Please guess the magic word: ");
            guess=int.Parse(Console.ReadLine());
            if (guess>magicWord){
                Console.WriteLine("Lower.");
            }
            else if (guess<magicWord){
                Console.WriteLine("Higher");
            }
            else{
                Console.WriteLine("Congrats you guessed the word!");
            }
        }
        
    }
}