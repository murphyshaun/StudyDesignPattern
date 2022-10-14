
using FactoryMethodPattern.Factory;
using System;

namespace FactoryMethodPattern
{
    public class Program
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
                    factory = new BasicAnimalFactory();
                }
                else
                {
                    factory = new RandomAnimalFactory();
                }

                Console.WriteLine(factory.CreateAnimal().GetName());
            }

            Console.ReadLine();
        }
    }
}
