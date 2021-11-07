using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace homework5._2
{
    class Program
    {
        static void Main()
        {
            //    Слово апельсин,  пень и спаниель
            string str = "";
            
            str = "Апельсин"; //а-0 п-1 е-2 л-3 ь-4 с-5 и-6 н-7
            Console.WriteLine(str);
           
            string result = str.Substring(1, 2)
                + str.Substring(7)
                + str.Substring(4, 1);

            
            Console.WriteLine(result);
            string resalt = str.Substring(5, 1)
                + str.Substring(1, 1)
                + str.Substring(0, 1).ToLower()
                + str.Substring(7)
                + str.Substring(6, 1)
                + str.Substring(2, 3);

            Console.WriteLine(resalt); // у resAlt специально сменил букву, тк надо было поменять переменную
            Console.ReadKey();

        }
    }
}
