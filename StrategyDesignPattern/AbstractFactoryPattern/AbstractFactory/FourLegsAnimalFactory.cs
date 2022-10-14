using AbstractFactoryPattern.Model;
using System;

namespace AbstractFactoryPattern.AbstractFactory
{
    class FourLegsAnimalFactory : AbstractAnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            Random random = new Random();

            var type = random.Next(0, 2);

            switch (type)
            {
                case 1:
                    {
                        return new Dog();
                    }
                default:
                    {
                        return new Cat();
                    }
            }
        }
    }
}
