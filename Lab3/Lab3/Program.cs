using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        delegate void Show();
        static void Main(string[] args)
        {
            Show show;
            Horoscope horoscope = new Horoscope();
            show = horoscope.Print;
            show();
        }
    }
    enum Zodiak
    {
        Козерог,
        Водолей,
        Рыбы,
        Овен,
        Телец,
        Близнецы,
        Рак, 
        Лев,
        Дева,
        Весы,
        Скорпион,
        Стрелец
    }
    class Astrology
    {
        public virtual void Print()
        {
            Console.WriteLine("Гороскоп");
        }
    }
    class Horoscope : Astrology
    {
        Dictionary<int, string> dict = new Dictionary<int, string>()
        
        {
            [1] = "Январь",
            [2] = "Февраль",
            [3] = "Март",
            [4] = "Апрель",
            [5] = "Май",
            [6] = "Июнь",
            [7] = "Июль",
            [8] = "Август",
            [9] = "Сентябрь",
            [10] = "Октябрь",
            [11] = "Ноябрь",
            [12] = "Декабрь"
        };
        public override void Print()
        {
            Console.WriteLine("Выберите месяц(нужно указать цифру):");
            foreach (var str in dict)
            {
                Console.WriteLine($"{str.Key}.) {str.Value}");
            }
            string month = Console.ReadLine();
            base.Print();
            switch (month)
            {
                case "1":
                    Console.WriteLine($"Ваш знак:{Zodiak.Козерог}");
                    break;
                case "2":
                    Console.WriteLine($"Ваш знак:{Zodiak.Водолей}");
                    break;
                case "3":
                    Console.WriteLine($"Ваш знак:{Zodiak.Рыбы}");
                    break;
                case "4":
                    Console.WriteLine($"Ваш знак:{Zodiak.Овен}");
                    break;
                case "5":
                    Console.WriteLine($"Ваш знак:{Zodiak.Телец}");
                    break;
                case "6":
                    Console.WriteLine($"Ваш знак:{Zodiak.Близнецы}");
                    break;
                case "7":
                    Console.WriteLine($"Ваш знак:{Zodiak.Рак}");
                    break;
                case "8":
                    Console.WriteLine($"Ваш знак:{Zodiak.Лев}");
                    break;
                case "9":
                    Console.WriteLine($"Ваш знак:{Zodiak.Дева}");
                    break;
                case "10":
                    Console.WriteLine($"Ваш знак:{Zodiak.Весы}");
                    break;
                case "11":
                    Console.WriteLine($"Ваш знак:{Zodiak.Скорпион}");
                    break;
                case "12":
                    Console.WriteLine($"Ваш знак:{Zodiak.Стрелец}");
                    break;
            }
            Console.ReadKey();
        }
    }
}
