using System;

namespace FacadePattern.Model
{
    internal class SecurityCodeChecker
    {
        private string _securityCode;

        public SecurityCodeChecker(string pin)
        {
            _securityCode = pin;
        }

        internal bool IsValid(string pin)
        {
            return _securityCode == pin;
        }
    }
}