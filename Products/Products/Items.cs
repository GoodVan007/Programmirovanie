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
        public string RetailPrice; // розничная цена товара
        public int NumberOfGoods; // Количество товара на складе
        public readonly Goods Type;

        public Items(string item, string product, string wholesale, string retail, Goods type)
        {
            ItemNumber = item;
            ProductName = product;
            WholesalePrise = wholesale;
            RetailPrice = retail;
            Type = type;
            
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
                case Goods.Kilo:
                    type = "Килограмм";
                    break;
                case Goods.Pack:
                    type = "Упаковок";
                    break;
                case Goods.ton:
                    type = "Тонн";
                    break;

            }

            Console.WriteLine($"Наименование товара: {ProductName}. Артикул: {ItemNumber}. Количество Товара{NumberOfGoods}{type}" +
                $" \nОптовая цена Товара: {WholesalePrise}. \nРозничная цена товара{RetailPrice}");
        }

    }
    
}
