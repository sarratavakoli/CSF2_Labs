using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block3LabLibrary
{
    public class CreditCardAccount
    {

        //fields
        private int _accountNumber;
        private Customer _customerInfo;
        private decimal _balance;
        private bool _isPastDue;
        private decimal _annualInterestRate;

        //properties
        public int AccountNumber
            { get { return _accountNumber; } set { _accountNumber = value; } }
        public Customer CustomerInfo
            { get { return _customerInfo; } set { _customerInfo = value; } }
        public decimal Balance
            { get { return _balance; } set { _balance = value; } }
        private bool IsPastDue
            { get { return _isPastDue; } set { _isPastDue = value; } }
        private decimal AnnualInterestRate
            { get { return _annualInterestRate; } set { _annualInterestRate = value;} }

        //constructors
        public CreditCardAccount(int accountNumber, Customer customerInfo, decimal balance, 
            bool isPastDue, decimal annualInterestRate)
        {
            AccountNumber = accountNumber;
            CustomerInfo = customerInfo;
            Balance = balance;
            IsPastDue = isPastDue;
            AnnualInterestRate = annualInterestRate;
        }

        //methods
        public override string ToString()
        {
            return String.Format($"{CustomerInfo}\n" +
                $"Account: {AccountNumber}\n" +
                $"Balance: {Balance:c} {(IsPastDue ? "PAST DUE" : "Current account - not past due")}\n" +
                $"Annual Interest: {AnnualInterestRate:P}");
                
        }

    }
}
