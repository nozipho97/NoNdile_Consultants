using System;

namespace TeamOfTwo
{
    internal class program
    {
        static void Main(string[] args)
        {

            string sentence = Console.ReadLine();

            LanguageFunctions LanguageFunctions = new LanguageFunctions();
            int numberWords =LanguageFunctions.GetWordCountInSentence(sentence);


            Console.WriteLine($"The amount of words in the sentence is {numberWords} ");

            int numberOfLetters = LanguageFunctions.GetLetersInSentence(sentence);
            Console.WriteLine($"The amount of words in the sentence is {numberOfLetters} ");
        }
    }
}