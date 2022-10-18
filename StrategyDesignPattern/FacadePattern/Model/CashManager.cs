using System;

namespace FacadePattern.Model
{
    internal class CashManager
    {
        private double _cashAmount;

        public CashManager(double cashAmount)
        {
            _cashAmount = cashAmount;
        }

        internal void Deposit(double cashAmount)
        {
            _cashAmount += cashAmount;
            Console.WriteLine("Cash in account: " + _cashAmount);
        }

        internal bool HaveEnoughMoney(double cashAmount)
        {
            return _cashAmount >= cashAmount;
        }

        internal void WithDraw(double cashAmount)
        {
            _cashAmount -= cashAmount;
            Console.WriteLine("Cash in account: " + _cashAmount);
        }
    }
}