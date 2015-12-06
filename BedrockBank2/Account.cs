using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
   public class Account 
    {
        /// <summary>
        /// This class provides 
        /// definition for a 
        /// Bedrock accoutnt
        /// </summary

        #region Variables
            ///<summary>
            ///shared memory for storing
            ///the last account number
            ///</summary>
        private static int lastAccountNumber = 0;

        #endregion


        #region Properties
        /// <summary>
        /// Name of the account holder
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Account number for the account
        /// </summary>
        public int AccountNumber { get; set; }
        /// <summary>
        /// Balance in the account
        /// </summary>
        public decimal Balance {
            get;
            private set; }

        public int SSN { get; set; }
        #endregion

        #region Constructors

        //Deafault Constructor
        public Account()
        {
            //lastAccountNumber = lastAccountNumber + 1;
            Account = ++lastAccountNumber
        }

        public Account(string name)
            :this()
        {
           this.Name = name;
        }

        public Account(string name, decimal amount)
            :this(name)
        {
            //Name = name;
            Deposit(amount);
        }
        #endregion

        #region Methods
        /// <summary>
        /// Deposit money into your account
        /// </summary>
        /// <param name="amount">Money to deposit</param>
        /// <returns>New balance</returns>
        public decimal Deposit(decimal amount)
        {
            //Balance = Balance + amount;
            Balance += amount;
            return Balance;
        }

        public decimal withdraw(decimal am)
        {
            Balance -= amount;
            return Balance;
        }
        #endregion
    }

