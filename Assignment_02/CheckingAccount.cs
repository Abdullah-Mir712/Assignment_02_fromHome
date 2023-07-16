using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02
{
    public class CheckingAccount : BankAccount, ITransaction
    {
        /*Inheritance: The class CheckingAccount inherit from the BankAccount class. 
         * This represents an inheritance relationship where the derived classes inherit the properties and methods of the base class.*/


        //OverDraft specifies the amount of funds that the account holder is allowed
        //  to withdraw beyond their available balance.
        public decimal OverDraftLimit { get; private set; }
        public CheckingAccount(int accountnumber, string accountholdername, decimal overdraftlimit) : base(accountnumber, accountholdername)
        {

            OverDraftLimit = overdraftlimit;
        }

        public override void Withdraw(decimal amount, string description)
        {
            if (amount < 0)
            {
                Console.WriteLine("Withdrawal amount should be greater than zero");
            }
            if(amount >0 && amount <= getBalance + OverDraftLimit)
            {
                getBalance -= amount;
                TransactionHistory.Add(new Transaction("Withdrawal", amount, description));
            }
            else
            {
                Console.WriteLine("Amount has exceeded the limit of over draft.");
            }
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
