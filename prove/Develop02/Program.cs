using System;
//added some error handling to ensure the files are .txt and the file exisits to 
//exceed the requirments. 
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        int loop = 6;
        while (loop != 0)
        {
            Console.WriteLine("Welcome to the Journal Program");
            Console.WriteLine("Please select one of the following:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Create File");
            Console.WriteLine("0. Quit");
            loop = int.Parse(Console.ReadLine());
            switch (loop)
            {
                case 1:
                    journal.GetPromptAndEntry();
                    break;
                case 2:
                    journal.DisplayJournal();
                    break;
                case 3:
                    Console.Write("Enter the filename to load: ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadJournal(loadFileName);
                    break;
                case 4:
                    Console.Write("Enter the filename to save: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveJournal(saveFileName);
                    break;
                case 5:
                    Console.Write("Enter the filename to create: ");
                    string createFileName = Console.ReadLine();
                    journal.CreateJournal(createFileName);
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }
}
