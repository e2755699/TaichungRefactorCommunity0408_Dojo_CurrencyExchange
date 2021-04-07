namespace KentBeckTDD_CurrencyExchange_20210407
{
    public class Dollar : Money
    {

        public Dollar(int amount)
        {
            Amount = amount;
        }

        public override Money Time(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }

    }
}