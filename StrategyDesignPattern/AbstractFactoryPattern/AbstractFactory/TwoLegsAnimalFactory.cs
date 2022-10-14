
using AbstractFactoryPattern.Model;
using System;

namespace AbstractFactoryPattern.AbstractFactory
{
    class TwoLegsAnimalFactory : AbstractAnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            Random random = new Random();

            var type = random.Next(0, 2);

            switch (type)
            {
                case 1:
                    {
                        return new Chicken();
                    }
                default:
                    {
                        return new Duck();
                    }
            }
        }
    }
}
