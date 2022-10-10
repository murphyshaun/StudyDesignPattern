
using DecoratorPattern.Model;

namespace DecoratorPattern.Decorators
{
    public class WhiteBuddle : MilkTeaDecorator
    {
        public WhiteBuddle(IMilkTea milkTea) : base(milkTea)
        {
        }

        public override double Cost()
        {
            return 1.5d + base.Cost();
        }
    }
}
