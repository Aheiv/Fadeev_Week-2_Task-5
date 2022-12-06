using System;

namespace ЛАБ5_УП
{
    class Program
    {

        static double f(double x)
        {
            try
            {
                if (x == 1 || x == 0.25) throw new Exception();
                else return (1 / (x - 1)) + (2 / (1 - 4 * x));
            }
            catch
            {
                throw;
            }
        }
        static void Main(string[] args)
        {
            double a;
            double b;
            double h;
            Console.Write("Введите начало диапазона: ");
            while (!double.TryParse(Console.ReadLine(), out a))
                Console.Write("Некорректный ввод данных!\nВведите начало диапазона: ");
            Console.Write("Введите конец диапазона: ");
            while (!double.TryParse(Console.ReadLine(), out b) || a > b)
                Console.Write("Некорректный ввод данных!\nВведите конец диапазона: ");
            Console.Write("Введите шаг диапазона: ");
            while (!double.TryParse(Console.ReadLine(), out h) || h <= 0)
                Console.Write("Некорректный ввод данных!\nВведите шаг диапазона: ");
            for (double i = a; i <= b; i += h)
                try
                {
                    Console.WriteLine("y({0})={1:f4}", i, f(i));
                }
                catch
                {
                    Console.WriteLine("y({0})=Ошибка!", i);
                }
        }
    }
}
