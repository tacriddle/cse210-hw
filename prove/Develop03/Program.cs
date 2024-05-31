using System;
//
//I went above and beyond for this assignment by adding the ability to see how long it 
//takes you to memorize the scripture.
namespace ScriptureApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var scriptureManager = new ScriptureManager();
            var randomScripture = scriptureManager.GetRandomScripture();
            var scriptureRef = new ScriptureReference(randomScripture.Key);
            var scriptureText = randomScripture.Value;

            var scripture = new Scripture(scriptureRef, scriptureText);

            scripture.StartMemorization();

            while (!scripture.AllWordsHidden())
            {
                scripture.Display();
                Console.WriteLine("\nPress Enter to continue or type 'quit' to exit: ");
                var userInput = Console.ReadLine();
                if (userInput.ToLower() == "quit")
                    break;
                scripture.HideRandomWord();
            }

            scripture.StopMemorization();
            Console.WriteLine($"You memorized the scripture in {scripture.MemorizationTime.TotalSeconds} seconds.");
        }
    }
}
