namespace StrategyDesignPattern.Model
{
    public class Ticket
    {
        private IPromoteStrategy _promoteStrategy { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public IPromoteStrategy PromoteStrategy
        {
            get => _promoteStrategy;
            set => _promoteStrategy = value;
        }


        public Ticket()
        {
        }

        public double GetPromotedPrice()
        {
            return _promoteStrategy.DoDisount(Price);
        }
    }
}
