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
            if (double.TryParse(Console.ReadLine(), out double x))
            {
                double result = CalculateFunction(x);
                Console.WriteLine(result);
            }

            Console.ReadKey();
        }

        static double CalculateFunction(double x)
        {
            return 4 * Math.Sin(x) * 5 * Math.Cos(x);
        }
    }
}
