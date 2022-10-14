using AbstractFactoryPattern.AbstractFactory;
using AbstractFactoryPattern.Factory;
using System;


namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimalFactory factory;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                var type = random.Next(0, 2);
                if (type == 0)
                {
                    factory = new FourLegsAnimalFactory();
                }
                else
                {
                    factory = new TwoLegsAnimalFactory();
                }

                Console.WriteLine(factory.CreateAnimal().GetName());
            }

            Console.ReadLine();
        }
    }
}
