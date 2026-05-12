namespace recap;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string lyrics = "I got, got, got I-I-I You got a death wish Got a death wish Someone said Someone said, 'Hey, you got a death wish";

        string[] words = lyrics.Split(' ');

        // Loop over every word 
        foreach(string word in words)
        {
            // Lets create new words without capitals and in lower case
            string cleanedWord = RemoveSymbols(word);
            Console.WriteLine(cleanedWord);
        }
    }

    public string RemoveSymbols(string _word)
    {
        string cleanedWord = "";
        foreach(char c in _word)
        {
            if (Char.IsLetter(c))
            {
                cleanedWord += c;
            }
        }

        return cleanedWord;
    }
}
