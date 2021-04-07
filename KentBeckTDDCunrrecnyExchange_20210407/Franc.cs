namespace KentBeckTDD_CurrencyExchange_20210407
{
    public class Franc
    {
        private readonly int _amount;

        public Franc(int amount)
        {
            _amount = amount;
        }

        public Franc Time(int multiplier)
        {
            return new Franc(_amount * multiplier);
        }

        public override bool Equals(object? obj)
        {
            return _amount == ((Franc) obj)._amount;
        }
    }
}