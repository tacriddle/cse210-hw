using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureApp
{
    public class Scripture
    {
        private List<ScriptureWord> words;

        public ScriptureReference Reference { get; private set; }

        public Scripture(ScriptureReference reference, string text)
        {
            Reference = reference;
            words = text.Split().Select(word => new ScriptureWord(word)).ToList();
        }

        public void HideRandomWord()
        {
            var visibleWords = words.Where(word => !word.Hidden).ToList();
            if (visibleWords.Count > 0)
            {
                var wordToHide = visibleWords[new Random().Next(visibleWords.Count)];
                wordToHide.Hide();
            }
        }

        public bool AllWordsHidden()
        {
            return words.All(word => word.Hidden);
        }

        public void Display()
        {
            Console.Clear();
            Console.WriteLine(Reference);
            Console.WriteLine(string.Join(" ", words));
        }
    }
}
