using System;

namespace FacadePattern.Model
{
    internal class AccountChecker
    {
        private string _accountName;

        public AccountChecker(string account)
        {
            _accountName = account;
        }

        internal bool IsValid(string acount)
        {
            return _accountName == acount;
        }
    }
}