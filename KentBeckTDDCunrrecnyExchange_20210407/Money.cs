namespace KentBeckTDD_CurrencyExchange_20210407
{
    public class Money
    {
        protected int Amount;

        public override bool Equals(object obj)
        {
            return Amount == ((Money)obj).Amount;
        }


    }
}