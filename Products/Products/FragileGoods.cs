using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commodity;

namespace Products
{
    public abstract class FragileGoods : Commoditys
    {
        
        //Хрупкий товар
        //максимальное количество единиц товара в стопке
        public double ValueGoods;

        public FragileGoods() : base("Sand", "123987456", "60", "50", "1000", GoodsType.ton) { }

        //public abstract double CalculateValue();
        public abstract double CalculateValue();

       
            
    }
}
