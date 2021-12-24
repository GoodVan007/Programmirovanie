using System;

namespace homework8
{
    class Program
    {//Задание 4
        static void MainFour()
        {
            var count = 0;
            Console.WriteLine("Введите натуральное число n");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите натуральное число k(0 <= k <= 8");
            var k = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                var a = n % 10;
                if (a > k)
                    count += a;
                n /= 10;
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
        //задание 1
        static void MainOne()
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0.0;
            for (double i = 1; i <= n; i++)
            {
                sum += i / (i + 1);
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }

}
