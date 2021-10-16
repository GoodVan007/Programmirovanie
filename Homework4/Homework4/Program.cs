using System;

namespace Homework4
{
    class Program
    {
        static void Main()

        {
            double x;
            

            double sin2 = Math.Sin(2);
            double sin3 = Math.Sin(3);
            double sin5 = Math.Sin(5);

            double cos5 = Math.Cos(5);
            double cos11 = Math.Cos(11);

            Console.WriteLine(Math.Round(x = ((2 + sin2 / 5 + cos5) + (3 + sin3 / 7 + cos5) + (5 + sin5 / 11 + cos11)), 3));

            

            Console.ReadKey();       
        }

    }

}
