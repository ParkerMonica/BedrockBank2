using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank2
{
    public static class BankFactory
    {
        public static Account CreateAccount(string name, int ssn)
        {
            var account = new Account(name);
            return account;
        }
        public static Account CreateAccount(string name, int ssn, decimal amount)
        {
            var account = CreateAccount(name);
            
            //var account = new Account(name, amount);
            //account.Name = name;
            //account.Deposit(amount);
            return account;
        }
    }
}
