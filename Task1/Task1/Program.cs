using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Есенин Сергей Письмо Женщине...");
            {
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Yellow;
                {
                    Console.WriteLine("Вы помните, Вы всё, конечно, помните, как я стоял, Приблизившись к стене,");
                    Console.ReadKey();
                    Console.WriteLine("Взволновано ходили вы по комнате И что-то резкое в лицо бросали мне");
                    Console.ReadKey();
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Есенин Сергей Письмо Женщине...");
                        Console.WriteLine("Вы помните, Вы всё, конечно, помните, Как я стоял, Приблизившись к стене");
                        Console.WriteLine("Взволновано ходили вы по комнате И что-то резкое в лицо бросали мне");
                    }

                }

            }

            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
        }
    }
}
