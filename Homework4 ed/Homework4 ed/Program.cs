using System;

namespace Homework4_ed
{
    class Program
    {
        static double Metod(double q, double w)
        {
            return ((q + Math.Sin(q)) / (w + Math.Cos(w)));

        }
        static void Main(string[] args)
        {
            double x = Metod(2, 5) + Metod(3, 5) + Metod(5, 11);
            Console.WriteLine($"x = {x:F3}");
            Console.ReadKey();

        }
    }
}
