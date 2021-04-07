namespace KentBeckTDD_CurrencyExchange_20210407
{
    public class Dollar
    {
        private readonly int _amount;

        public Dollar(int amount)
        {
            _amount = amount;
        }

        public Dollar Time(int multiplier)
        {
            return new Dollar(_amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            return _amount == ((Dollar) obj)._amount;
        }
    }
}