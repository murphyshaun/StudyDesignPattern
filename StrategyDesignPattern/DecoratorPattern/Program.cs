
using DecoratorPattern.Decorators;
using DecoratorPattern.Model;

namespace DecoratorPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var milkTea1 = new EggPudding(
                            new FruitPudding(
                                new BlackSugar(
                                    new Bubble(
                                        new MilkTea()))));

            System.Console.WriteLine(milkTea1.Cost());

            var milkTea2 = new EggPudding(
                            new BlackSugar(
                                new WhiteBuddle(
                                    new MilkTea())));

            System.Console.WriteLine(milkTea2.Cost());

            System.Console.ReadLine();

        }
    }
}
