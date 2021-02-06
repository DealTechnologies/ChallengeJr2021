using System;
using System.Linq;

namespace fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6;

            int result = Enumerable.Range(1, n).Aggregate(1, (p, item) => p * item);

            Console.WriteLine(result);
        }
    }
}
