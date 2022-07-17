using System;

namespace Interesting_Functions_For_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase = "  I am you !             ";
            Console.WriteLine(phrase);

            //Remove spaces at the beginning and end of the sentence
            Console.WriteLine(phrase.Trim());

            //Exchange something for something
            Console.WriteLine(phrase.Replace("I", "YOU"));
        }
    }
}
