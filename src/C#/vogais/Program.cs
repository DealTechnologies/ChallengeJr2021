using System;
using System.Collections.Generic;
using System.Linq;

namespace vogais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skip a sentence: ");

            var value = Console.ReadLine();

            Console.WriteLine("");

            value.Split(" ").ToList().ForEach(PrintVowel);
        }

        static void PrintVowel(string word)
        {
            string @char = word.Substring(0, 1);

            if (@char.Count(x => (x == 'a') || (x == 'e') || (x == 'i') || (x == 'o') || (x == 'u')) > 0)
                Console.WriteLine(word);
        }
    }
}
