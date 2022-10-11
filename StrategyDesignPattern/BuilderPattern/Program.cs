
using BuilderPattern.Model;

namespace BuilderPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var car = new Car(4,
                              new SeatBelt("Shaun"),
                              "red",
                              new Windscreen("Foot"),
                              engine: new Engine("Shaun foot")
                              );

            var carByBuilder = new CarBuilder()
                                    .AddWheels(4)
                                    .AddSeatBelts(new SeatBelt("Shaun seat belt"))
                                    .AddWindscreen(new Windscreen("Shaun wind screen"))
                                    .AddEngine(new Engine("Shaun foot"))
                                    .Paint("red")
                                    .Build();

            System.Console.WriteLine(car);
            System.Console.WriteLine("======================");
            System.Console.WriteLine(carByBuilder);

            System.Console.ReadLine();
        }
    }
}
