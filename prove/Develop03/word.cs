namespace ScriptureApp
{
    public class ScriptureWord
    {
        private string word;
        private bool hidden;

        public ScriptureWord(string word)
        {
            this.word = word;
            hidden = false;
        }

        public void Hide()
        {
            hidden = true;
        }

        public void Reveal()
        {
            hidden = false;
        }

        public bool IsHidden()
        {
            return hidden;
        }

        public override string ToString()
        {
            return hidden ? "______" : word;
        }
    }
}
