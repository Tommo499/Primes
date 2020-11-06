using System;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(">>> ");
            string a = Console.ReadLine();
            int limit = Convert.ToInt32(a);
            int primes = 1;
            bool P = false;
            Console.WriteLine("Prime: 2");
            for (int i = 3; i < limit; i++)
            {
                for (int f = 2; f < Math.Ceiling(Math.Sqrt(i)) + 1; f++)
                {
                    P = false;
                    if (i % f == 0)
                    {
                        P = true;
                        break;
                    }
                }
                if (P == false)
                {
                    Console.WriteLine("Prime: " + i);
                    primes++;
                }
                else
                {
                    Console.WriteLine("Composite: " + i);
                }
            }
            Console.WriteLine(primes);
            Console.ReadKey();
        }
    }
}
