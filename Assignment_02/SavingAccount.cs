using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02
{
    /*Inheritance: The classe SavingsAccount inherit from the BankAccount class. 
     * This represents an inheritance relationship where the derived classes inherit the properties and methods of the base class.*/
    public class SavingAccount : BankAccount, ITransaction
    {
        private decimal InterestRate;

        public SavingAccount(int accountnumber, string accountholdername,  decimal interestrate) : base(accountnumber, accountholdername)
        {
            InterestRate = interestrate;
        }

        public override decimal CalculateInterest()
        {
            decimal interest = InterestRate * getBalance;
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
