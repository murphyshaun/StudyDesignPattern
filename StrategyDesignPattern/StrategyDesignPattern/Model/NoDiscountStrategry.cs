

namespace StrategyDesignPattern.Model
{
    class NoDiscountStrategry : IPromoteStrategy
    {
        public double DoDisount(double price)
        {
            return price;
        }
    }
}
