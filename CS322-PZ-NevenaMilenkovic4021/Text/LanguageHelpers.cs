using System.Text;

namespace Gork
{
    public partial class Language
    {
        private readonly StringBuilder _sb = new();

        public virtual string JoinedWordList(string[] words, string conjugation)
        {
            _sb.Clear();

            for (var i = 0; i < words.Length; i++)
            {
                if (i > 0)
                    _sb.Append(words.Length > 2 ? Comma + Space : Space);

                if (i == words.Length - 1 && words.Length > 1)
                    _sb.Append(conjugation + Space);

                _sb.Append(words[i]);
            }

            return _sb.ToString();
        }
    }
}