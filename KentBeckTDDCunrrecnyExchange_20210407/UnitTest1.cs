﻿using NUnit.Framework;

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
        //    Assert.AreEqual(10, five.Amount);
        //}

        //處理副作用
        //[Test]
        //public void TestMultiplication()
        //{
        //    var five = new Dollar(5);
        //    var product = five.Time(2);
        //    Assert.AreEqual(new Dollar(10).Amount, product.Amount);
        //    product = five.Time(3);
        //    Assert.AreEqual(new Dollar(15).Amount, product.Amount);
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

        //Amount private
        [Test]
        public void TestMultiplication()
        {
            var five = new Dollar(5);
            Assert.AreEqual(new Dollar(10), five.Time(2));
            Assert.AreEqual(new Dollar(15), five.Time(3));
        }

        //5法朗*2=10法朗
        [Test]
        public void TestFrancMultiplication()
        {
            Franc five = new Franc(5);
            Assert.AreEqual(new Franc(10), five.Time(2));
            Assert.AreEqual(new Franc(15), five.Time(3));
        }

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
            //Assert.IsTrue(new Dollar(5).Equals(new Dollar(5)));
            //Assert.IsFalse(new Dollar(5).Equals(new Dollar(6)));
            //Assert.IsTrue(new Franc(5).Equals(new Franc(5)));
            //Assert.IsFalse(new Franc(5).Equals(new Franc(6)));
            Assert.IsFalse(new Franc(5).Equals(new Dollar(5)));
        }
    }
}