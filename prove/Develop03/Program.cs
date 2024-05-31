using System;

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

            while (!scripture.AllWordsHidden())
            {
                scripture.Display();
                Console.WriteLine("\nPress Enter to continue or type 'quit' to exit: ");
                var userInput = Console.ReadLine();
                if (userInput.ToLower() == "quit")
                    break;
                scripture.HideRandomWord();
            }
        }
    }
}
