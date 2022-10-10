
namespace StrategyDesignPattern.Model
{
    class HalfDiscountStrategy : IPromoteStrategy
    {
        public double DoDisount(double price)
        {
            return price * 0.5;
        }
    }
}
