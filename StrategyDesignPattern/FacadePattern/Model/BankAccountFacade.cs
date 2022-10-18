using System;

namespace FacadePattern.Model
{
    internal class BankAccountFacade
    {
        private string _acount;
        private string _pin;

        private AccountChecker _accountChecker;
        private SecurityCodeChecker _securityCodeChecker;
        private CashManager _cashManager;

        public BankAccountFacade(string account, string pin)
        {
            _acount = account;
            _pin = pin;

            _accountChecker = new AccountChecker(account);
            _securityCodeChecker = new SecurityCodeChecker(pin);
            _cashManager = new CashManager(1000.00);
        }

        internal void DepositCash(double cashAmount)
        {
            if (_accountChecker.IsValid(_acount) && _securityCodeChecker.IsValid(_pin))
            {
                _cashManager.Deposit(cashAmount);
                Console.WriteLine("Done");
            }
            else
            {
                Console.WriteLine("Error deposit");
            }
        }

        internal void WithDrawCash(double cashAmount)
        {
            if (_accountChecker.IsValid(_acount)
                && _securityCodeChecker.IsValid(_pin)
                && _cashManager.HaveEnoughMoney(cashAmount))
            {
                _cashManager.WithDraw(cashAmount);
                Console.WriteLine("Done withdraw");
            }
            else
            {
                Console.WriteLine("Error withdraw");
            }
        }
    }

}