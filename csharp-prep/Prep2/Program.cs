using System;

class Program
{
    static void Main(string[] args)
    {
        string tacLetter;
        Console.Write("What is your persentage in the class?");
        string tacGradePercentString=Console.ReadLine();
        float tacGradePercent= int.Parse(tacGradePercentString);
        if (tacGradePercent>= 90){
            tacLetter="A";
        }
        else if (tacGradePercent >= 80){
            tacLetter="B";
        }
        else if (tacGradePercent>=70){
            tacLetter="C";
        }
        else if (tacGradePercent>=60){
            tacLetter="d";
        }
        else{
            tacLetter="F";
        }
        Console.WriteLine($"Your grade is {tacLetter}.");
        if (tacGradePercent>=70){
            Console.WriteLine("Congrats you passed the class");
        }
        if (tacGradePercent<70){
            Console.WriteLine("Sorry you failed the class");
        }
    }
}