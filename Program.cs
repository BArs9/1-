using System;

namespace _1лабараторка
{
    class Program
    {
        static void Main(string[] args)
        {
            double g, m;
            int d; string D, s1, s2, s3;
            Console.WriteLine("Привет");
            Console.Write("Как тебя зовут? "); D = Console.ReadLine();
            Console.Write("В каком году ты родился? "); s1 = Console.ReadLine();
            g = int.Parse(s1);
            while (g > 2020)
            {
                Console.WriteLine("Ошибка. Введите год заново");
                s1 = Console.ReadLine();
                g = int.Parse(s1);
            }
            while (g <= 0)
            {
                Console.WriteLine("Ошибка. Введите год заново");
                s1 = Console.ReadLine();
                g = int.Parse(s1);
            }
            Console.Write("В каком месяце ты родился? "); s2 = Console.ReadLine();
            m = int.Parse(s2);
            while (m > 12)
            {
                Console.WriteLine("Ошибка. Введите месяц заново");
                s2 = Console.ReadLine();
                m = int.Parse(s1);
            }
            while (m < 0)
            {
                Console.WriteLine("Ошибка. Введите месяц заново");
                s2 = Console.ReadLine();
                m = int.Parse(s2);
            }
            Console.Write("В какой день ты родился? "); s3 = Console.ReadLine();
            d = int.Parse(s3);
            while (d > 31)
            {
                Console.WriteLine("Ошибка. Введите день заново");
                s3 = Console.ReadLine();
                d = int.Parse(s1);
            }
            while (d < 0)
            {
                Console.WriteLine("Ошибка. Введите день заново");
                s3 = Console.ReadLine();
                d = int.Parse(s2);
            }

            Console.WriteLine("Привет" + D);
            Console.WriteLine("Ваш возраст равен" + (2020 - g) );
            Console.WriteLine("Приятно познакомится"); 
        }
    }
}
