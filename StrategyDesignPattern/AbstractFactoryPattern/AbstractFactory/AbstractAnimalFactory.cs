using AbstractFactoryPattern.Factory;
using AbstractFactoryPattern.Model;

namespace AbstractFactoryPattern.AbstractFactory
{
    abstract class AbstractAnimalFactory : IAnimalFactory
    {
        public abstract IAnimal CreateAnimal();
    }
}
