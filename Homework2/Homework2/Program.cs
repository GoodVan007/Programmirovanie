using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
            public static double FunctionValue(string x)
            {
                double i = Double.Parse(x);
                return Math.Sqrt(Math.Pow(2, Math.Pow(i, i)) + Math.Pow(i, Math.Pow(2, i)) + Math.Pow(i, Math.Pow(i, 2)));
            }
            static void Main(string[] args)
            {
                string x = Console.ReadLine();
                Console.WriteLine(FunctionValue(x));
                Console.ReadKey();
            }
    }
}
