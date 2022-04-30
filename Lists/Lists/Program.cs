using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string>();
            List<int> numbers = new List<int>();
            while (true)
            {
                FillList(strings, numbers);
            }
        }
        static void FillList(List<string> strings, List<int> numbers)
        {
            Console.WriteLine("Введите значение:");
            var a = Console.ReadLine();
            int b = 0;
            try
            {
                b = int.Parse(a);
                numbers.Add(b);
                Console.WriteLine("Список чисел:");
                foreach (int i in numbers)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine($"Тип Данных:{b.GetType()}");
            }
            catch
            {
                strings.Add(a.ToString());
                Console.WriteLine("Список строк:");
                foreach (string i in strings)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine($"Тип Данных:{a.GetType()}");
            }
        }
    }
}

