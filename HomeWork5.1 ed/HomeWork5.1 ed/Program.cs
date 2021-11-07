using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5._1_ed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write Eng. text");

            string text = Console.ReadLine();
            text = text.Replace("a", "4");
            text = text.Replace("e", "3");
            text = text.Replace("i", "!");
            text = text.Replace("q", "9");
            text = text.Replace("b", "6");
            text = text.Replace("f", "|=");
            text = text.Replace("j", ")");
            text = text.Replace("r", "|2");
            text = text.Replace("z", "2");
            text = text.Replace("c", "(");
            text = text.Replace("g", "9");
            text = text.Replace("k", "|<");
            text = text.Replace("o", "0");
            text = text.Replace("s", "5");
            text = text.Replace("d", "|)");
            text = text.Replace("h", "|-|");
            text = text.Replace("p", "|>");
            text = text.Replace("l", "1");
            text = text.Replace("t", "7");
            text = text.Replace("x", "><");
            text = text.Replace("u", "|_|");
            text = text.Replace("v", @"\/"); 
            text = text.Replace("m", @"|\/|");
            text = text.Replace("w", @"\/\/");
            text = text.Replace("n", @"|\|");
            text = text.Replace("y", "'/");

            Console.WriteLine(text);

            Console.ReadKey();
        }

    }
}
