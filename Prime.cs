
namespace ConsoleApp3
{
    class Program
    {
        static bool Prime(int number)
        {
            if (number == 2)
            {
                return true;
            }
            if (number == 0 || number == 1)
            {
                return false;
            }
            bool P = false;
            for (int f = 2; f <= Math.Ceiling(Math.Sqrt(number)); f++)
            {
                P = true;
                if (number % f == 0)
                {
                    P = false;
                    break;
                }
            }
            return P;
        }

        }
}
