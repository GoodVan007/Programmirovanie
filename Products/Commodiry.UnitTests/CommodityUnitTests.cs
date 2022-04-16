using System;
using Commodiry;
using NUnit.Framework;


namespace Commodiry.UnitTests 
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
            Assert.AreEqual("100$", cement.WholesalePrice);
            Assert.AreEqual("90$", cement.Retai.Price);
            Assert.AreEqual("1000", cement.Type);
            
        }
        [Test]
        public void ToString_Items_NameSpaceItemNumber()
        {
            var cement = CreateTestItems();
            Assert.AreEqual("Cement 123456789", cement.ToString());
        }
        private Items CreateTestItems()
        {           
            return new Items("Cement", "123456789", "1000");      
        }
        // 33 и 35 строчки выдают ошибку "CS0118", никак не могу ее исправить
        // и из-за этого не могу запустить тесты
        // "Ошибка CS0118 "Commodiry" является пространство имен, но используется как тип"
        // Все делал по Примеру задания
    }
}
