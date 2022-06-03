using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DataStracture
{
    class Program
    {
        static void Main(string[] args)
        {
            // проверка расшифровки из примеров в задании

            string text_1 = "wwstdaadierfflitzzz";
            Console.WriteLine($"{text_1} --> {Decrypt(text_1)}");

            string text_2 = "rrasspplzzitlqqeeebyyggeccbb";
            Console.WriteLine($"{text_2} --> {Decrypt(text_2)}");

            Console.WriteLine("\nВведите текст для шифровки\n"); 
    
            string text_3 = Console.ReadLine(); //Запрашиваем текст у пользователя

            string text_3Encripted = Encript(text_3);
            Console.WriteLine($"encrypted text:\n{text_3Encripted}\n");

            string text_3Decrypted = Decrypt(text_3Encripted);
            Console.WriteLine($"dencrypted text:\n{text_3Decrypted}\n");

            Console.WriteLine($"\noriginal text:\n{text_3}\n");

            Console.ReadKey();
        }

        public static string Encript(string text)
        {            
            text = text.ToLower(); //Буквы приводятся к одному регистру            

            text = Regex.Replace(text, @"[^a-z]", ""); //1.Убирает все символы, отличные от букв, включая пробелы.
            
            text = Regex.Replace(text, @"([a-z])\1", @"$1"); //2.Заменяет все подряд идущие одинаковые буквы на одну такую букву.
            
            int n = text.Length * 3; //Количество вставок — случайно число от n до 3n, где n— длина строки.            
            
            Random rand = new Random(); //3.Многократно вставляет в произвольное место текста две случайные одинаковых буквы.
            StringBuilder stringBuilder = new StringBuilder(text); //Место каждой вставки выбирается случайно.

            for (int i = 0; i < n; i++)
            {
                stringBuilder.Insert(index: rand.Next(stringBuilder.Length),
                    value: ((char)rand.Next('a', 'z')).ToString(), count: 2);
            }
            return stringBuilder.ToString();
        }
        
        public static string Decrypt(string text) //Метод дешифровки с использованием подходящей структуры данных
        {
            StringBuilder stringBuilder = new StringBuilder(text);

            Match doubleMatch = Regex.Match(text, @"([a-z])\1");
            while (doubleMatch.Success)
            {
                stringBuilder.Remove(doubleMatch.Index, 2);
                doubleMatch = Regex.Match(stringBuilder.ToString(), @"([a-z])\1");
            }
            return stringBuilder.ToString();
        }
    }
}
