namespace KentBeckTDD_CurrencyExchange_20210407
{
    public class Money
    {
        protected string _currency;
        protected int _amount;

        public Money(int amount, string currency)
        {
            _amount = amount;
            _currency = currency;
        }

        public override bool Equals(object obj)
        {
            return _amount == ((Money)obj)._amount && _currency == ((Money) obj)._currency;
        }


        public Money Time(int multiplier)
        {
            return new Money(_amount * multiplier, _currency);
        }


        public string Currency()
        {
            return _currency;
        }

        public override string ToString()
        {
            return $"{_amount}:{_currency}";
        }

        public static Money Dollar(int account)
        {
            return new Money(account, "USD");
        }

        public static Money Franc(int account)
        {
            return new Money(account, "CHF");
        }
    }
}