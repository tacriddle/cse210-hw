using System;
using System.Diagnostics;
//Added the counting activity for exceeding requirements
class Program
{
    static void Main(string[] args)
    {
        int quit=1;
        while (quit!=0){
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start reflecting activity");
            Console.WriteLine("2. Start listing activity");
            Console.WriteLine("3. Start breathing activity");
            Console.WriteLine("4. Start counting activity");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu:");
            quit=int.Parse(Console.ReadLine());
            int duration;
            switch(quit){
                case 1:
                Console.Write("What would like the duration of the activity to be: ");
                duration=int.Parse(Console.ReadLine());
                string reflectTitle="Reflection";
                string reflectionDesc="This activity will help you reflect on times in your life when you have shown strength and resiliencce. This will help you recogniz ethe power you have and how youu can use it in other aspects of your life.";
                Reflection reflection=new(reflectTitle,reflectionDesc,duration);
                reflection.DisplayIntroMessage();
                reflection.PopulateLists();
                reflection.ReflectionActivity();
                break;
                case 2:
                Console.Write("What would like the duration of the activity to be: ");
                duration=int.Parse(Console.ReadLine());
                string listingTitle="Listing";
                string listingDesc="This activity will hlep you reflect on theh good things in your life by having you list as many things as you can in a certain area.";
                Listing listing=new(listingTitle,listingDesc,duration);
                listing.DisplayIntroMessage();
                listing.PopulatePrompts();
                listing.ListingActivity();
                break;
                case 3:
                Console.Write("What would like the duration of the activity to be: ");
                duration=int.Parse(Console.ReadLine());
                string breathingTitle="Breathing";
                string breathingDesc="This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
                Breathing breathing=new(breathingTitle, breathingDesc, duration);
                breathing.DisplayIntroMessage();
                breathing.BreathingActivity();
                break;
                case 4:
                Console.Write("What would like the duration of the activity to be: ");
                duration=int.Parse(Console.ReadLine());
                string countingTile="Counting";
                string countingDesc="You will be couting outloud with a counter to help you relax";
                Counting counting=new(countingTile,countingDesc,duration);
                counting.DisplayIntroMessage();
                counting.CountingActivity();
                break;
                case 5:
                quit=0;
                Console.WriteLine("Thanks for using the mindfulness app!");
                break;
            }
        }
    }
}