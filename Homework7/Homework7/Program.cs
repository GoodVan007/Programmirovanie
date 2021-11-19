using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение X : ");
            var x = double.Parse(Console.ReadLine());
            Console.WriteLine($"Значение функции f(x) = {Metod(x)}");
            Console.ReadKey();
        }
        static double Metod(double x)
        {
            double f;
            if ((Math.Abs(Math.Sin(x)) < x))
                f = -Math.Sin(x);
            else
            {
                if ((Math.Abs(Math.Sin(x)) == x))
                    f = 0;
                else
                    f = Math.Sin(x);
            }
            return f;
        }
    }
}
