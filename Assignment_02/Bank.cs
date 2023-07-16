using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02
{
    /*Aggregation: The Bank class contains a dictionary (accounts) that maintains a collection of BankAccount objects. 
     * This represents an aggregation relationship, where the Bank class is associated with multiple BankAccount objects.
     
     Dependency: The BankAccount objects depend on the Bank object, as the Bank object is responsible for managing the accounts. 
    The Bank class is used to add accounts, retrieve accounts, and print account information.


     */
    public class Bank
    {
        //creating dictional for all bank accounts in which account number will
        //be key and corresponding bankaccount object will be value
        private Dictionary<int, BankAccount> accounts;

        public Bank()
        {
            accounts = new Dictionary<int, BankAccount>();
        }

        public void AddAccount(BankAccount account)
        {
            accounts.Add(account.getAccountNumber, account);
        }

        public BankAccount GetAccount(int accountnumber)
        {
            if (accounts.ContainsKey(accountnumber))
            {
                return accounts[accountnumber];
            }
            else
            {
                return null;
            }
        }

        public void DisplayAllAccounts()
        {
            Console.WriteLine("Bank Accounts");
            foreach(var account in accounts.Values)  //used .value to print values of accouts dictionary 
            {
                Console.WriteLine($"Account Number: {account.getAccountNumber}, Account Holder Name: {account.getAccountHolderName}");
            }
        }




        
    }
}
