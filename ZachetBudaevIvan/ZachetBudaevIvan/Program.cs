using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ZachetBudaevIvan
{
    class program
    {
        static void Main()
        {
            Console.WriteLine("Введите номер перестановки");
            var N = int.Parse(Console.ReadLine());
            List<string> letters = new List<string>() { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L" }; // List - массив без конкретной длины
        }

        static int СountingPermutations(int n)
        {
            var factorial = 1;
            for (int i = 2; i <= n; i++)
                factorial = factorial * i;
            return factorial;
        }

        static int SearchNumber(int n, int N)
        {
            int number;
            if (N > СountingPermutations(n - 1))
            {
                number = N % n;
                N = N / n;
            }

        }
    }
}
