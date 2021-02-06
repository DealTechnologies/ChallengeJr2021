using System;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("write an word: ");

            var value = Console.ReadLine();

            string first = value.Substring(0, value.Length / 2);
            char[] arr = value.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);

            var msg = first.Equals(second) ? "palindrome: true" : "palindrome: false";

            Console.WriteLine(msg);
        }
    }
}
