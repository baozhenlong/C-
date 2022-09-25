namespace Strategy
{
    public interface ICash
    {
        public abstract double AcceptCash(double money);
    }

    public class CashNormal : ICash
    {
        public double AcceptCash(double money)
        {
            return money;
        }
    }

    public class CashRebate : ICash
    {

        private double rebate = 1d;
        public CashRebate(string rebate)
        {
            this.rebate = double.Parse(rebate);
        }

        public double AcceptCash(double money)
        {
            return money * this.rebate;
        }
    }

    public class CashReturn : ICash
    {
        private double condition = 0d;
        private double @return = 0d;
        public CashReturn(string condition, string @return)
        {
            this.condition = double.Parse(condition);
            this.@return = double.Parse(@return);
        }
        public double AcceptCash(double money)
        {
            double result = money;
            if (money >= condition)
            {
                result = money - Math.Floor(money / condition) * @return;
            }
            return result;
        }
    }

    public class Context
    {
        private ICash cash;
        public Context(ICash cash)
        {
            this.cash = cash;
        }
        public double AcceptCash(double money)
        {
            return this.cash.AcceptCash(money);
        }
    }
}