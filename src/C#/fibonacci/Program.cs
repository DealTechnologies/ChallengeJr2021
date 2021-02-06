using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int last = 0;
            int first = 1;

            Header();

            while (n < 30)
            {
                n++;
                int fibonacci = last + first;

                //bool positive = first % 2 == 0;
                //if (positive)
                Line(n, first);

                last = first;
                first = fibonacci;

            }

            Console.ReadLine();
        }

        static void Header()
        {
            Console.Write("{0,-5}", "N");
            Console.Write("{0,12}", "Tamanho");
        }

        static void Line(int n, int result)
        {
            Console.WriteLine("");
            Console.Write("{0,-5}", n);
            Console.Write("{0,12}", result);
        }
    }
}
