
namespace AbstractFactoryPattern.Model
{
    public class Duck : TwoLegsAnimal
    {
        public override string GetName()
        {
            return "This is Duck";
        }
    }
}
