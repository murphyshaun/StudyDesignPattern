
using FacadePattern.Model;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccountFacade bankAccountFacade = new BankAccountFacade("nametest", "pintest");

            bankAccountFacade.DepositCash(1000000.00);
            bankAccountFacade.WithDrawCash(900000.00);

            System.Console.ReadKey();

        }
    }
}
