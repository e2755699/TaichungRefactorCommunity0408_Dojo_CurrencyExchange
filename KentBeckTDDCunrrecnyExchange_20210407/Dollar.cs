namespace KentBeckTDD_CurrencyExchange_20210407
{
    public class Dollar
    {
        public int Amount;

        public Dollar(int amount)
        {
            Amount = amount;
        }

        public Dollar Time(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            return Amount == ((Dollar) obj).Amount;
        }
    }
}