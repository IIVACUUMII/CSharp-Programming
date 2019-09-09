using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            double result = 2 * Math.Pow(x, 4) - 3 * Math.Pow(x, 3) + 4 * Math.Pow(x, 2) - 5 * x + 6;
            Console.WriteLine($"Result: {result}");
            Console.ReadKey();
        }
    }
}
