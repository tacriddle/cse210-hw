namespace ScriptureApp
{
    public class ScriptureWord
    {
        public string Word { get; private set; }
        public bool Hidden { get; private set; }

        public ScriptureWord(string word)
        {
            Word = word;
            Hidden = false;
        }

        public void Hide()
        {
            Hidden = true;
        }

        public void Reveal()
        {
            Hidden = false;
        }

        public override string ToString()
        {
            return Hidden ? "______" : Word;
        }
    }
}
