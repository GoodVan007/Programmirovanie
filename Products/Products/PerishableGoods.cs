using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    class PerishableGoods : FragileGoods
    {
        //скоропортящийся товар
        //максимальный срок хранения
        public double Goods;
        public double PeriodOfValidity;

        public FragileGoods(string ProductName, string ItemNumber, string RetailsalePrise, string WholesalePrise, string numb, double period) : base
            (ProductName, ItemNumber, RetailsalePrise, WholesalePrise, numb)
        {
            PeriodOfValidity = period; 
            
        }
        public override double CalculateValue()
        {
            return Math.Round(ValueGoods + DateTime.Now);
        }

        //($"Наименование товара: {ProductName}. Артикул: {ItemNumber}. Количество Товара{NumberOfGoods}{type}" +
        //  $" \n Оптовая Цена Товара: {RetailsalePrise} \n Розничная цена товара {WholesalePrise}");
    }
}
