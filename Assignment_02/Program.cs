using System;
using System.Collections.Generic;

namespace Assignment_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            // Create instances of different bank account types
            //Suffix m tells the compiler to treat the literal as a decimal value.
            SavingAccount Saving = new SavingAccount(4850, "Abdullah Mir", 0.02m);
            CheckingAccount Checking = new CheckingAccount(4851, "Junaid Zafar", 1000m);
            LoanAccount Loan = new LoanAccount(4852, "Fahim Sheikh", 0.05m);

            // Add accounts to the bank
            bank.AddAccount(Saving);
            bank.AddAccount(Checking);
            bank.AddAccount(Loan);

            // Perform transactions on the accounts
            Saving.Deposit(700);
            Saving.Withdraw(300);
            Checking.Deposit(1000, "Salary deposit");
            Checking.Withdraw(500);
            Loan.Deposit(2000);
            Loan.Withdraw(500);

            // Calculate and print interest for savings and loan accounts
            decimal savingsInterest = Saving.CalculateInterest();
            decimal loanInterest = Loan.CalculateInterest();
            Console.WriteLine($"Savings Account Interest: {savingsInterest}");
            Console.WriteLine($"Loan Account Interest: {loanInterest}");

            // Print transaction history for all accounts
            Console.WriteLine();
            Saving.PrintTransaction();
            Console.WriteLine();
            Checking.PrintTransaction();
            Console.WriteLine();
            Loan.PrintTransaction();

            // Print all bank accounts
            Console.WriteLine();
            bank.DisplayAllAccounts();

            Console.Read();


        }
    }
}



