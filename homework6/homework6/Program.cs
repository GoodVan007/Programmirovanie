using System;


namespace homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения m, n");
            var m = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            if (m % 2 == 0)
            {
                Console.WriteLine("Переменная М не соответствует условию,F=0");
            }
            else
            { if (n % 2 == 0)
                {
                    Console.WriteLine("Переменная N не соответствует условию, F=0");
                }else Console.WriteLine("Переменные M и N Соответствуют условию, F=1");
            }
            Console.ReadKey();
        } 
    }
}
