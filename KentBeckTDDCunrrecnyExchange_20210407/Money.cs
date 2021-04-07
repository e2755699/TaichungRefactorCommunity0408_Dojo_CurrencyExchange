namespace KentBeckTDD_CurrencyExchange_20210407
{
    public abstract class Money
    {
        protected int Amount;

        public override bool Equals(object obj)
        {
            return Amount == ((Money)obj).Amount && GetType() == obj.GetType();
        }


        public static Dollar Dollar(int amount)
        {
            return new Dollar(amount);
        }

        public abstract Money Time(int multiplier);

        public static Money Franc(int amount)
        {
            return new Franc(amount);
        }
    }
}