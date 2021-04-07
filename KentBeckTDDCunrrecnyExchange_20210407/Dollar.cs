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
            Amount = Amount * multiplier;
            return null;
        }
    }
}