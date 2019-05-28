using System;
using System.Collections.Generic;

namespace dictionary_of_words
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
    Create a dictionary with key value pairs to
    represent words (key) and its definition (value)
*/
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add("Lame", "Seeing John try to code");
            wordsAndDefinitions.Add("Book", "The reason to live in this boring world allowing you to explore other worlds.");
            wordsAndDefinitions.Add("Zelda", "Dope");
            /*
                Use square bracket lookup to get the definition two
                words and output them to the console
            */
            Console.WriteLine(wordsAndDefinitions["Zelda"]);
            Console.WriteLine(wordsAndDefinitions["Book"]);
            /*
                Loop over dictionary to get the following output:
                    The definition of [WORD] is [DEFINITION]
                    The definition of [WORD] is [DEFINITION]
                    The definition of [WORD] is [DEFINITION]
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"The definition of {word.Key} is {word.Value}");
                Console.WriteLine();
            }
        }
    }
}
