using NUnit.Framework;

namespace KentBeckTDD_CurrencyExchange_20210407
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //5美元*2 = 10美元
        [Test]
        public void TestMultiplication()
        {
            var five = new Dollar(5);
            five.Time(2);
            Assert.AreEqual(10, five.Amount);
        }
    }
}