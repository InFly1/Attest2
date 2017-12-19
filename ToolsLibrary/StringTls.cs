using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsLibrary
{
    public class StringTls
    {

        public string Str { get; set; }
        public StringTls(string Str)
        {
            this.Str = Str;
        }
        public bool CheckOnWord(string Word)
        {
            char[] temp = Str.ToArray();
            for (int i = 0; i < Word.Length; i++)
            {
                if (Word[i] != ' ' && Array.IndexOf(temp, char.ToLower(Word[i])) == -1 && Array.IndexOf(temp, char.ToUpper(Word[i])) == -1)
                    return false;
            }
            return true;
        }
    }
}
