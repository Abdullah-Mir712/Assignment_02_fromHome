using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02
{
    //Abstraction: This is a BankAccount class which serves as an abstraction of a bank account.
    //The class  encapsulate the basic properties of a bank account like accountNumber, accountHolderName,
    //and balance, along with methods that operate on these properties.
    public abstract class BankAccount
    {
        // Encapsulation: Declaring attributes private to ensure data security
        private int AccountNumber { get; set; }
        // Encapsulation: Declaring attributes private to ensure data security
        private string AccountHolderName { get; set; }
        // Encapsulation: Declaring attributes private to ensure data security
        private decimal Balance { get; set; }

        public List<Transaction> TransactionHistory;

        


        public BankAccount(int accountnumber, string accountholdername)
        {

            AccountNumber = accountnumber;
            AccountHolderName = accountholdername;
            Balance = 0;
            TransactionHistory = new List<Transaction>();


        }
        //below are public methods provided  for accessing and modifying these properties out of this class
        //to uphold encapsulation.

        public int getAccountNumber    // Encapsulation - Private data accessed through public property
        {
            get { return AccountNumber; }
            set { AccountNumber = value; }
        }
        public string getAccountHolderName   // Encapsulation - Private data accessed through public property
        {
            get { return AccountHolderName; }
            set { AccountHolderName = value; }
        }
        public decimal getBalance            // Encapsulation - Private data accessed through public property
        {
            get { return Balance; }
            set { Balance = value; }
        }

        // Polymorphism - Method to be overridden by subclasses
        public virtual decimal CalculateInterest() 
        {
            return 0;
        }

        //Polymorphism - method overloading in the same class

        public virtual void Deposit(decimal amount)
        {
            Deposit(amount, "Regular Deposit");
        }

        // Polymorphism - Method can be overloaded with different parameters
        public virtual void Deposit(decimal amount, string description)   
        {
            if (amount > 0)
            {
                Balance = Balance + amount;
                TransactionHistory.Add(new Transaction("Deposit", amount, description));
            }
            else
            {
                Console.WriteLine("Deposit amount should be greater than zero");
            }
        }
        //Polymorphism - method overloading in the same class
        public virtual void Withdraw(decimal amount)
        {
            Withdraw(amount, "Regular withdraw");
        }
        public virtual void Withdraw(decimal amount, string description)   // Polymorphism - Method can be overloaded with different parameters
        {
            if(amount <= 0)
            {
                Console.WriteLine("withdrawal amount should be greate than zero");
            }
            if (amount > Balance)
            {
                Console.WriteLine("Insuficent Balance");
            }

            Balance = Balance - amount;
            TransactionHistory.Add(new Transaction("withdrawal", amount, description));
        }
        public void PrintTransactionHistory()
        {
            Console.WriteLine($"Transaction History for account {AccountNumber}");
            foreach (Transaction transaction in TransactionHistory)
            {
                Console.WriteLine(transaction);

            }
        }






    }
}
