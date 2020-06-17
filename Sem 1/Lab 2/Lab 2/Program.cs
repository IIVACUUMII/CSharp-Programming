using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double mult = 1.0;
            int nn, nk;
            bool a, b;

            do
            {
                Console.WriteLine("Enter nn: ");
                a = int.TryParse(Console.ReadLine(), out nn);
                Console.WriteLine("Enter nk: ");
                b = int.TryParse(Console.ReadLine(), out nk);
                if (!(a & b) || (nn < 0 || nk < nn))
                    Console.WriteLine("Error");
            } while (!(a & b) || (nn < 0 || nk < nn));

            for (int k = nn; k < nk; k++)
            {
                mult *= (Math.Pow(k, 2) + Math.Pow(-1, (Math.Pow(k, 3) + Math.Pow(-1, k) * k)) * k) / (3 * Math.Pow(k, 2) + 5);
            }

            Console.WriteLine($"Result: {mult}");
        }
    }
}
