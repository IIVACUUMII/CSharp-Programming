using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool a = int.TryParse(Console.ReadLine(), out num);
            int a1, a2, a3;
            if ((num >= 1000) || (num <= 99) || !a)
                Console.WriteLine("ERROR! Please enter number from 100 to 999");
            else
            {
                a1 = num / 100;
                a2 = num / 10 - (num / 100) * 10;
                a3 = num % 10;
                Console.WriteLine($"{a1} {a2} {a3}");

                if ((a2 - a1) == (a3 - a2))
                    Console.WriteLine("True");
                else
                    Console.WriteLine("False");
            }
            Console.ReadLine();
        }
    }
}
