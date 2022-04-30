using System;

namespace MathematicalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                FindVol();
            }
        }
        static void FindVol()
        {
            Console.WriteLine("Объём какой фигуры вы хотите получить ?");
            Console.WriteLine("1.)Квадрат");
            Console.WriteLine("2.)Цилиндр");
            Console.WriteLine("0.)Выход");
            string str = Console.ReadLine();
            if (str == "1")
            {
                Console.Clear();
                Console.WriteLine("Введите сторону квадрата:");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine($"Объём квадрата равен:{Volumes.VolSquare(a)}");
            }
            else if (str == "2")
            {
                Console.Clear();
                Console.WriteLine("Введите высоту:");
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите радиус окружности:");
                double r = double.Parse(Console.ReadLine());
                Console.WriteLine($"Объём цилиндра равен:{Volumes.VolCilinder(h, r)}");
            }
            else if (str == "0")
            {
                Environment.Exit(0);
            }
        }
    }
    class MathFunc
    {
    }
    class Volumes : MathFunc
    {
        public static int VolSquare(int a)
        {
            return a * a * a;
        }
        public static double VolCilinder(double h, double r)
        {
            return Math.Round(2d * Math.PI * Math.Pow(r, 2d) * h);
        }
    }
}