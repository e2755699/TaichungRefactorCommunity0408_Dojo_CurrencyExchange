namespace KentBeckTDD_CurrencyExchange_20210407
{
    public class Franc : Money
    {

        public Franc(int amount)
        {
            Amount = amount;
        }

        public Franc Time(int multiplier)
        {
            return new Franc(Amount * multiplier);
        }
    }
}