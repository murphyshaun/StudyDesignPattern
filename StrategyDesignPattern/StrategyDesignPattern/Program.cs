using StrategyDesignPattern.Model;
using System;

namespace StrategyDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start getting tickets!");
            var random = new Random();
            var ticket = new Ticket();

            for (int i = 0; i < 5; i++)
            {
                var strategyIndex = random.Next(0, 2);
                ticket.Name = "Ticket " + i;
                ticket.Price = 50 * (i + 1);
                switch (strategyIndex)
                {
                    case 0:
                        ticket.PromoteStrategy = new NoDiscountStrategry();
                        break;
                    case 1:
                        ticket.PromoteStrategy = new QuarterDiscountStrategy();
                        break;
                    case 2:
                        ticket.PromoteStrategy = new HalfDiscountStrategy();
                        break;
                    default:
                        break;
                }

                Console.WriteLine($"Promoted price of {ticket.Name} is {ticket.GetPromotedPrice()} {ticket.PromoteStrategy.GetType().Name}");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
