
namespace AbstractFactoryPattern.Model
{
    public class Dog : FourLegsAnimal
    {
        public override string GetName()
        {
            return "This is Dog";
        }
    }
}
