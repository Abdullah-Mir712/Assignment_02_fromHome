using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02
{
    /*Interface Implementation: The SavingsAccount, CheckingAccount, and LoanAccount classes implement the ITransaction interface. This establishes
     * a relationship between the classes and the interface, indicating that they fulfill the contract defined by the interface.*/
    public class Transaction
    {
        public string TransactionType { get; private set; }
        public decimal Amount { get; private set; }
        public string Description { get; private set; }

        public Transaction(string transactiontype, decimal amount, string description)
        {
            TransactionType = transactiontype;
            Amount = amount;
            Description = description;

        }
        public override string ToString()
        {
            return $"{TransactionType} - {Amount} - {Description}";
        }
    }
}
