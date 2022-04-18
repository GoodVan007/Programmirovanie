using System;
using Commodity;
using NUnit.Framework;


namespace Commodity.UnitTests 
{
    [TestFixture]
    public class CommodityUnitTests 
    {
        [Test]
        public void ConstructorTest()
        {
            var cement = CreateTestItems();

            Assert.AreEqual("Cement", cement.ProductName);
            Assert.AreEqual("123456789", cement.ItemNumber);
            Assert.AreEqual("100$", cement.WholesalePrise);
            Assert.AreEqual("90$", cement.RetailPrise);
            Assert.AreEqual("None", cement.NumberOfGoods);
            Assert.AreEqual(GoodsType.Pack, cement.Type);
            
        }
        [Test]
        public void ToString_Items_ProductNameSpaceItemNumber()
        {
            var cement = CreateTestItems();
            Assert.AreEqual("Cement 123456789", cement.ToString());
        }
        private Items CreateTestItems()
        {           
            return new Items("Cement", "123456789", "100", "90", "None", GoodsType.Pack);      
        }
        // 33 и 35 строчки выдают ошибку "CS0118", никак не могу ее исправить
        // и из-за этого не могу запустить тесты
        // "Ошибка CS0118 "Commodiry" является пространство имен, но используется как тип"
        // Все делал по Примеру задания
    }
}
