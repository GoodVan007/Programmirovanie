using System;
using System.Activities;
using System.Activities.Statements;
using System.Linq;

namespace Homework3
{
    class Program
    {
            public static double TetrahedronVolume(string x)
            {
                double i = Double.Parse(x);
                return (i * i) / (6 * Math.Sqrt(2));
            }

            public static double SurfaceAreaTetrahedron(string x)
            {
                double i = Double.Parse(x);
                return i * i * Math.Sqrt(3);
            }
            static void Main(string[] args)
            {
                string x = Console.ReadLine();
                Console.WriteLine(TetrahedronVolume(x));
                Console.WriteLine(SurfaceAreaTetrahedron(x));

                Console.ReadKey();
            }
    }
}
