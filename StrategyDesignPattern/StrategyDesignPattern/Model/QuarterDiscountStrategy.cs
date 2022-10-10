

namespace StrategyDesignPattern.Model
{
    class QuarterDiscountStrategy : IPromoteStrategy
    {
        public double DoDisount(double price)
        {
            return price * 0.75;
        }
    }
}
