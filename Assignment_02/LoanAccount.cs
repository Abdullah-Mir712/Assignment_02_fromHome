using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02
{
    /*Inheritance: The classes LoanAccount inherit from the BankAccount class. This represents an 
     * inheritance relationship where the derived classes inherit the properties and methods of the base class.*/
    class LoanAccount : BankAccount, ITransaction
    {
        public decimal InterestRate {get; private set;}

        public LoanAccount(int accountnumber, string accountholdername, decimal interestRate):base(accountnumber,accountholdername)
        {
            InterestRate = interestRate;
        }
        public override decimal CalculateInterest()
        {
            decimal interest =getBalance* InterestRate;
            return interest;
        }

        public void ExecuteTransaction(decimal amount)
        {
            Deposit(amount);
        }

        public void PrintTransaction()
        {
            PrintTransactionHistory();
        }
    }
}
