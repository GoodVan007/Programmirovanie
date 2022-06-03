using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commodity
{ 

    public class Commoditys
    {
        
        public readonly string ItemNumber; // артикул
        public string ProductName; // наименование
        public string WholesalePrise; // розничная цена товара
        public string RetailsalePrise; // оптовая цена товара
        public string NumberOfGoods; // Количество товара на складе
        public readonly GoodsType Type;

        public Commoditys(string item, string product, string wholePrise, string retailPrise, string numb, GoodsType type)
        {
            ItemNumber = item;
            ProductName = product;
            WholesalePrise = wholePrise;
            RetailsalePrise = retailPrise;
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
                case GoodsType.kilo:
                    type = "килограмм";
                    break;
                case GoodsType.ton:
                    type = "тонн";
                    break;
                case GoodsType.Pack:
                    type = "Упаковок";
                    break;
            }

            Console.WriteLine($"Наименование товара: {ProductName}. Артикул: {ItemNumber}. Количество Товара{NumberOfGoods}{type}" +
                $" \n Оптовая Цена Товара: {RetailsalePrise} \n Розничная цена товара {WholesalePrise}");
        }

        public virtual string [] GetInfo()
        {
            //Random rnd = new Random();
            //    int value = rnd.Next(0, 1000);

            var info = new string[2];
            info[0] = ToString();
            string type;
            if (Type == GoodsType.Pack)
                type = "Упаковок";
            if (Type == GoodsType.kilo)
                type = "Килограмм";
            else
                type = "Тонн";
            

            info[1] = $"Наименование товара: {ProductName}. Артикул {ItemNumber}. Количество  товара {type}. " +
                $" Оптовая Цена Товара: {RetailsalePrise}. Розничная цена товара {WholesalePrise}.";
            return info;
            
        }

        
    }
}
