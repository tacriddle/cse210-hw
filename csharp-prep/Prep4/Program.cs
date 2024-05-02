using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers;
        numbers=new List<int>();
        int guess=1;
        while (guess != 0){
            Console.Write("Please enter a number, enter 0 when finished. ");
            guess=int.Parse(Console.ReadLine());
            numbers.Add(guess);
        }
        int numbersSum=numbers.Sum();
        int average=(numbersSum/(numbers.Count));
        int largest=0;
        foreach (int num in numbers)
        {
            if (num > largest)
            {
                largest = num;
            }
        }
        Console.WriteLine($"The sum is {numbersSum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {largest}");


    }
}