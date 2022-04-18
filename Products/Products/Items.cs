using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commodity
{ 

    public class Items
    {
        
        public readonly string ItemNumber; // артикул
        public string ProductName; // наименование
        public string WholesalePrise; // оптовая цена товара
        public string RetailPrise; // розничная цена товара
        public string NumberOfGoods; // Количество товара на складе
        public readonly GoodsType Type;

        public Items(string item, string product, string wholesale, string retail, string numb, GoodsType type)
        {
            ItemNumber = item;
            ProductName = product;
            WholesalePrise = wholesale;
            RetailPrise = retail;
            Type = type;
            NumberOfGoods = numb;
            
        }

        

        public override string ToString()
        {
            return $"{ProductName} {ItemNumber}";
        }
        public void PrintInfo()
        {
            Console.WriteLine(this);

            var type = "";
            switch (Type)
            {
                case GoodsType.Kilo:
                    type = "Килограмм";
                    break;
                case GoodsType.Pack:
                    type = "Упаковок";
                    break;
                case GoodsType.ton:
                    type = "Тонн";
                    break;

            }

            Console.WriteLine($"Наименование товара: {ProductName}. Артикул: {ItemNumber}. Количество Товара{NumberOfGoods}{type}" +
                $" \nОптовая цена Товара: {WholesalePrise}. \nРозничная цена товара{RetailPrise}");
        }

    }
    // в Файле тестов 33 и 35 строчки выдают ошибку "CS0118", никак не могу ее исправить
    // и из-за этого не могу запустить тесты
    // "Ошибка CS0118 "Commodiry" является пространство имен, но используется как тип"
    // Все делал по Примеру задания
}
