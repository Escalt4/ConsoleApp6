using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение для x:");

            if (double.TryParse(Console.ReadLine(), out double x))
            {
                double result = CalculateFunction(x);
                Console.WriteLine($"Результат вычисления функции 4Sin(x) * 5Cos(x) при x = {x} равен: {result}");
            }
            else
            {
                Console.WriteLine("Ошибка ввода, вы ввели не числовое значение.");
            }

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }

        static double CalculateFunction(double x)
        {
            return 4 * Math.Sin(x) * 5 * Math.Cos(x);
        }
    }
}
