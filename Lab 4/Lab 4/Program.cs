using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int N, counterUp = 0, counterDown = 0, interval = 0;
            
            Console.Write("Enter N: ");
            bool a = int.TryParse(Console.ReadLine(), out N);

            for (int i = 0; i < N * 3.5; i++)
                Console.Write("-");
            Console.WriteLine(" ");
            
            if (!a)
                Console.WriteLine("ERROR!");
            else
            {
                int[] Array = new int[N];
                for (int i = 0; i < N; i++)
                {
                    /*int.TryParse(Console.ReadLine(), out Array[i]);
                                                       Ввод вручную*/
                    Array[i] = random.Next(0, 100);
                }

                Console.Write("Array: ");
                for (int i = 0; i < N; i++)
                {
                    Console.Write($"{Array[i]} ");
                }

                for (int i = 1; i < N; i++)
                {
                    if (Array[i-1] < Array[i])
                        counterUp++;
                    else
                    {
                        if (counterUp > 1)
                            interval++;
                        counterUp = 0;
                    }

                    if (Array[i-1] > Array[i])
                        counterDown++;
                    else
                    {
                        if (counterDown > 1)
                            interval++;
                        counterDown = 0;
                    }

                    if (i + 1 == N)
                    {
                        if (counterDown > 1 || counterUp > 1)
                            interval++;
                    }
                }
                
                Console.WriteLine(" ");
                for (int i = 0; i < N * 3.5; i++)
                    Console.Write("-");
                
                Console.WriteLine(" ");
                Console.WriteLine($"Count of intervals: {interval}");
                Console.ReadKey();
            }
        }
    }
}
