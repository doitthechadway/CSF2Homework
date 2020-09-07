using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesLibrary
{
    public class CreditCardAccount

    {
        public int AccountNumber { get; set; }
        public Customer CustomerInfo { get; set; }
        public decimal Balance { get; set; }
        public bool IsPastDue { get; set; }
        public decimal AnnualInterestRate { get; set; }

        public CreditCardAccount(int accountNumber, Customer customerInfo, decimal balance, bool isPastDue, decimal annualInterestRate)
        {
            CustomerInfo = customerInfo;
            AccountNumber = accountNumber;
            Balance = balance;
            IsPastDue = isPastDue;
            AnnualInterestRate = annualInterestRate;
        }

        public override string ToString()
        {
            return CustomerInfo + string.Format("Account Number: {0}\nBalance: {1:c}\nAnnual Interest Rate: {2:p}\nPast Due: {3}", AccountNumber, Balance, AnnualInterestRate, IsPastDue);
        }        
    }
}
