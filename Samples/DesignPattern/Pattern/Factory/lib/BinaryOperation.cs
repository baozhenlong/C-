namespace Factory
{
    public abstract class BinaryOperation
    {
        protected float num1;
        protected float num2;
        public void SetOperand(float num1, float num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public abstract float GetResult();
    }

    public class Plus : BinaryOperation
    {
        public override float GetResult()
        {
            return this.num1 + this.num2;
        }
    }

    public class Multiply : BinaryOperation
    {
        public override float GetResult()
        {
            return this.num1 * this.num2;
        }
    }

    public class BinaryOperationFactory
    {
        public static BinaryOperation Create(string @operator)
        {
            if (@operator == "+")
            {
                return new Plus();
            }
            else if (@operator == "*")
            {
                return new Multiply();
            }
            throw new SystemException("未定义的操作符");
        }
    }
}