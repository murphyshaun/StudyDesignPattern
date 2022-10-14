
namespace AbstractFactoryPattern.Model
{
    public class Chicken : TwoLegsAnimal
    {
        public override string GetName()
        {
            return "This is Chicken";
        }
    }
}
