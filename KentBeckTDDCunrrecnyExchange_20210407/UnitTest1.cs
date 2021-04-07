using System.Collections.Generic;
using NUnit.Framework;

namespace KentBeckTDD_CurrencyExchange_20210407
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void dollar_five_add_dollar_five()
        {
            var dollar = new Dollar(5);
            dollar.Plus(new Dollar(5));
            Assert.AreEqual(10, dollar.Amount);
        }

        [Test]
        public void dollar_ten_add_dollar_five()
        {
            var dollar = new Dollar(10);
            dollar.Plus(new Dollar(5));
            Assert.AreEqual(15, dollar.Amount);
        }

        [Test]
        public void one_dollar_transfer_two_franc()
        {
            var dollar = new Dollar(1);
            var transform = new Transform();
            var actual = transform.Transfer(dollar, Currency.Franc);
            var expected = new Franc(2);
            Assert.AreEqual(expected.Amount, actual.Amount);
        }

        [Test]
        public void two_franc_transfer_one_dollar()
        {
            var franc = new Franc(2);
            var transform = new Transform();
            var actual = transform.Transfer(franc, Currency.Dollar);
            var expected = new Dollar(1);
            Assert.AreEqual(expected.Amount, actual.Amount);
        }

        [Test]
        public void one_dollar_plus_two_franc_transfer_to_two_dollar()
        {
            var dollar = new Dollar(1);
            var franc = new Franc(2);
            dollar.Plus(franc);
            Assert.AreEqual(new Dollar(2).Amount, dollar.Amount);

        }

    }

    public class Transform
    {
        public Money Transfer(Money money, Currency currency)
        {
            var exchangeRateMapping = new Dictionary<Currency, Dictionary<Currency, decimal>>
            {
                {
                    Currency.Dollar, new Dictionary<Currency, decimal>()
                    {
                        {Currency.Franc, 2},
                        {Currency.Dollar, 1}
                    }
                },
                {
                    Currency.Franc, new Dictionary<Currency, decimal>()
                    {
                        {Currency.Dollar, 0.5m},
                        {Currency.Franc, 1}
                    }
                }
            };
            var exchangeRate = exchangeRateMapping[money.Currency][currency];

            return new Money(money.Amount * exchangeRate, currency);
        }
    }

    public class Franc : Money
    {
        public Franc(decimal amount):base(amount,Currency.Franc)
        {
        }
        
    }

    public class Money
    {
        public Money(decimal amount, Currency currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public Currency Currency { get; set; }

        public decimal Amount { get; set; }
    }

    public class Dollar : Money
    {

        public Dollar(decimal amount): base(amount, Currency.Dollar)
        {
        }

        public void Plus(Money money)
        {
            var transferMoney = new Transform().Transfer(money, Currency);

            Amount += transferMoney.Amount;
        }
    }
}