using AbstractFactoryPattern.Model;
using System;

namespace AbstractFactoryPattern.Factory
{
    class RandomAnimalFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal()
        {
            Random random = new Random();

            var type = random.Next(0, 3);

            switch (type)
            {
                case 1:
                    {
                        return new Dog();
                    }
                case 2:
                    {
                        return new Cat();
                    }
                default:
                    {
                        return new Duck();
                    }
            }
        }
    }
}
