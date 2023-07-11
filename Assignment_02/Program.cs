﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02
{


    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public int Balance{ get; set; }

        public BankAccount(int accountnumber, string accountholdername, int balance)
        {

            AccountNumber = accountnumber;
            AccountHolderName = accountholdername;
            Balance = balance;

        }
        public virtual void Deposit(int amount)
        {
            Balance = Balance + amount;
            Console.WriteLine($"{amount } is deposited to account number {AccountNumber} under name {AccountHolderName}. Your total Balance is {Balance}");
        }
        public virtual void Withdraw(int amount)
        {
            Balance = Balance - amount;
            Console.WriteLine($"{amount} has been withdrawn from account number {AccountNumber} under name {AccountHolderName}. Your remaining balance is {Balance}");
        }
        public virtual void DisplayAccountInfo()
        {
            Console.WriteLine($"Customer {AccountHolderName} with account number {AccountNumber} has balance {Balance}");
        }



    }

    public class SavingAccount : BankAccount
    {
        int Interest;
        public SavingAccount(int accountnumber, string accountholdername, int balance, int interestrate) : base(accountnumber, accountholdername, balance)
        {
            Interest = interestrate;
        }
        public override void Deposit(int amount)
        {

            Balance = Balance+  amount + ((amount * Interest) / 100);
            Console.WriteLine($"Your deposited amount is {amount}. Your total balance with interset rate {Interest}% is {Balance}");
        }
    }

    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(int accountnumber, string accountholdername, int balance) : base(accountnumber, accountholdername, balance)
        {
            
        }

        public override void Withdraw(int amount)
        {
            if(amount < Balance)
            {
                Balance -= amount;
                Console.WriteLine($"You have witdrawn amount {amount}. Your remaining balance is {Balance}");

            }
            else
            {
                Console.WriteLine("Error Message: withdraw amount exceeds balance in the account");

            }
               
                   
        }
    }

    public class Bank
    {
        public List<BankAccount> bankAccounts { get; set; }
        public Bank()
        {
            bankAccounts = new List<BankAccount>();
        }
        public void AddAccount(BankAccount bankAccount)
        {
            bankAccounts.Add(bankAccount);
            //Console.WriteLine($"Bank account with name {bankAccount.AccountHolderName} with {bankAccount.AccountNumber} account number has been added to the Bank");
        }
        public void DepositToAccount(int accountnumber, int amount)
        {
            BankAccount account = bankAccounts.Find(a => a.AccountNumber == accountnumber);
            if(account!= null)
            {
                account.Deposit(amount);
            }
            else
            {
                Console.WriteLine("account not found");
            }
        }

        public void WithDrawFromAccount(int accountnumber, int amount)
        {
            BankAccount account = bankAccounts.Find(a => a.AccountNumber == accountnumber);
            if (account != null)
            {
                account.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("account not found");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Bank bank = new Bank();
                SavingAccount savingAccount = new SavingAccount(1234, "kabir", 50000, 3);
                CheckingAccount checkingAccount = new CheckingAccount(5678, "laraib", 1987);

                bank.AddAccount(savingAccount);
                bank.AddAccount(checkingAccount);

                bank.DepositToAccount(1234, 999);
                bank.WithDrawFromAccount(5678, 67);

                


                Console.Read();
            }
        }
    }
}
