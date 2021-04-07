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
        //[Test]
        //public void TestMultiplication()
        //{
        //    var five = new Dollar(5);
        //    five.Time(2);
        //    Assert.AreEqual(10, five._amount);
        //}

        //處理副作用
        //[Test]
        //public void TestMultiplication()
        //{
        //    var five = new Dollar(5);
        //    var product = five.Time(2);
        //    Assert.AreEqual(new Dollar(10)._amount, product._amount);
        //    product = five.Time(3);
        //    Assert.AreEqual(new Dollar(15)._amount, product._amount);
        //}

        //equal
        //[Test]
        //public void TestEquality()
        //{
        //    Assert.IsTrue(new Dollar(5).Equals(new Dollar(5)));
        //    Assert.IsFalse(new Dollar(5).Equals(new Dollar(6)));       
        //    Assert.IsTrue(new Franc(5).Equals(new Franc(5)));
        //    Assert.IsFalse(new Franc(5).Equals(new Franc(6)));
        //    Assert.IsFalse(new Franc(5).Equals(new Dollar(5)));
        //}

        //_amount private
        //[Test]
        //public void TestMultiplication()
        //{
        //    var five = new Dollar(5);
        //    Assert.AreEqual(new Dollar(10), five.Time(2));
        //    Assert.AreEqual(new Dollar(15), five.Time(3));
        //}


        //共用Equal
        //[Test]
        //public void TestEquality()
        //{
        //    Assert.IsTrue(new Dollar(5).Equals(new Dollar(5)));
        //    Assert.IsFalse(new Dollar(5).Equals(new Dollar(6)));       
        //    Assert.IsTrue(new Franc(5).Equals(new Franc(5)));
        //    Assert.IsFalse(new Franc(5).Equals(new Franc(6)));
        //    Assert.IsFalse(new Franc(5).Equals(new Dollar(5)));
        //}

        //比較不同幣別
        [Test]
        public void TestEquality()
        {
            Assert.IsTrue(Money.Dollar(5).Equals(Money.Dollar(5)));
            Assert.IsFalse(Money.Dollar(5).Equals(Money.Dollar(6)));
            Assert.IsTrue(Money.Franc(5).Equals(Money.Franc(5)));
            Assert.IsFalse(Money.Franc(5).Equals(Money.Franc(6)));
            Assert.IsFalse(Money.Franc(5).Equals(Money.Dollar(5)));
        }

        //Money建立回傳Dollar and Franc的工廠方法
        [Test]
        public void TestMultiplication()
        {
            Money five = Money.Dollar(5);
            Assert.AreEqual(Money.Dollar(10), five.Time(2));
            Assert.AreEqual(Money.Dollar(15), five.Time(3));
        }

        //5法朗*2=10法朗
        [Test]
        public void TestFrancMultiplication()
        {
            Money five = Money.Franc(5);
            Assert.AreEqual(Money.Franc(10), five.Time(2));
            Assert.AreEqual(Money.Franc(15), five.Time(3));
        }

        //引入貨幣概念
        [Test]
        public void TestCurrency()
        {
            Assert.AreEqual("USD",Money.Dollar(5).Currency());
            Assert.AreEqual("CHF",Money.Franc(5).Currency());
        }
    }
}