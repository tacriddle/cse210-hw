using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ScriptureApp
{
    public class Scripture
    {
        private List<ScriptureWord> words;
        private Stopwatch stopwatch;

        public ScriptureReference Reference { get; private set; }
        public TimeSpan MemorizationTime { get; private set; }

        public Scripture(ScriptureReference reference, string text)
        {
            Reference = reference;
            words = text.Split().Select(word => new ScriptureWord(word)).ToList();
            stopwatch = new Stopwatch();
        }

        public void StartMemorization()
        {
            stopwatch.Start();
        }

        public void StopMemorization()
        {
            stopwatch.Stop();
            MemorizationTime = stopwatch.Elapsed;
        }

        public void HideRandomWord()
        {
            var visibleWords = words.Where(word => !word.IsHidden()).ToList();
            if (visibleWords.Count > 0)
            {
                var wordToHide = visibleWords[new Random().Next(visibleWords.Count)];
                wordToHide.Hide();
            }
        }

        public bool AllWordsHidden()
        {
            return words.All(word => word.IsHidden());
        }

        public void Display()
        {
            Console.Clear();
            Console.WriteLine(Reference);
            Console.WriteLine(string.Join(" ", words));
        }
    }
}

