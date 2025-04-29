using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamOfTwo
{
    internal class LanguageFunctions
    {
        public int GetWordCountInSentence(string sentence)

        {
            int wordCount = 0;
            string[] words = sentence.Split(' ');

            wordCount = words.Length;

            return wordCount;
        }
    }
}
