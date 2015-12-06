using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank2
{
    class Program
    {
        static void Main(string[] args)
        {
            //va factory = new BankFactory();

            var account = BankFactory.CreateAccount("Kal Checking", 500)

            ////Crate an instance of an account == object
            //var account = new Account();
            ////account.AccountNumber = 123;
            //account.Name = "Kal Checking";
            ////account.Balance = 10000000000;
            //account.Deposit(500);
            Console.WriteLine(
                account.Name, account.Account
                account.Balance
                );

            var savingsAccount = BankFactory
                //Exception handling
                }
    }
}
