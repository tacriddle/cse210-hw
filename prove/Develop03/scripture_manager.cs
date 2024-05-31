using System;
using System.Collections.Generic;

namespace ScriptureApp
{
    public class ScriptureManager
    {
        private Dictionary<string, string> scriptureLibrary;
        private Random random;

        public ScriptureManager()
        {
            scriptureLibrary = new Dictionary<string, string>();
            random = new Random();
            InitializeScriptureLibrary();
        }

        private void InitializeScriptureLibrary()
        {
            scriptureLibrary.Add("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
            scriptureLibrary.Add("Proverbs 3:5-6", "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");
        }

        public KeyValuePair<string, string> GetRandomScripture()
        {
            var index = random.Next(scriptureLibrary.Count);
            var keyValue = new List<KeyValuePair<string, string>>(scriptureLibrary)[index];
            return keyValue;
        }
    }
}
