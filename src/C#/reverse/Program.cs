using System;

namespace reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "STEVE JOBS";

            Console.WriteLine(value);

            string valueReverse = Reverse(value);

            Console.WriteLine(valueReverse);
        }

        public static string Reverse(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
