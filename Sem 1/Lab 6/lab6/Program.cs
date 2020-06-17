using System;
using System.Collections.Generic;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            //task
            Console.WriteLine("Створити ліст чарових змінних, дозволити можливість заповнення з калвіатури. Вивести індекси змінних рівних перевірочній(теж ввести з клавіатури). Скопіювати ліст в масив.");
            //creating a list
            var chars = new List<char>();
            int input = 1;
            while (input == 1)
            {
                Console.WriteLine("Press 1 to add an item or 0 to start.");
                input = Convert.ToInt32(Console.ReadLine());
                if (input == 1) chars.Add(Convert.ToChar(Console.ReadLine()));
            }
            //program
            char test;
            Console.WriteLine("\nEnter test char : ");
            test = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Your list : ");
            for (int i = 0; i < (chars.Count); i++)
            {
                if (chars[i] == test) Console.WriteLine(chars[i] + " is " + i);
                else Console.WriteLine(chars[i]);
            }
            char[] array = chars.ToArray();
            Console.WriteLine("Your array is : ");
            for (int i = 0; i < (chars.Count); i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
