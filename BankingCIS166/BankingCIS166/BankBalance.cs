using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author:      Brian Lloyd
 * Date:        03/2014
 * Project:     Homework 6 Banking (BankingCIS166)
 * Description: Calculate user bank account balance after transactions and adds to listbox using a class
 */

namespace BankingCIS166
{
    class BankBalance
    {
        #region Class Variables
        //Starting balance with no argument constructor
        const decimal STARTINGBALANCE = 0.00M;

        public bool Overdrawn { get; set; }

        //Total Balance Property
        private decimal _balance;
        public decimal Balance
        {
            get { return _balance; }
        }
        #endregion

        #region Constructors
        //Set balance to 0.00
        public BankBalance()
        {
            _balance = STARTINGBALANCE;
        }

        //Assign balance based on argument
        public BankBalance(decimal StartingBalance)
        {
            _balance = StartingBalance;
        }

        #endregion

        #region Public Methods

        //Add amount to balance (Negative numbers are used to subract)
        public void AdjustBalance(decimal Amount, TransactionType Type)
        {
            decimal TransactionAmount= CalculateTransactionAmount(Amount, Type);//Calculate amount with consideration of transaction type
            CalculateBalance(TransactionAmount);
        }

        public void AdjustBalance(decimal Amount, TransactionType Type, bool Removal)
        {
            decimal TransactionAmount = CalculateTransactionAmount(Amount, Type, Removal);
            CalculateBalance(TransactionAmount);
        }

        private void CalculateBalance(decimal TransactionAmount)
        {
            _balance += TransactionAmount;

            CheckOverdraw();
        }


        private void CheckOverdraw()
        {
            //Handle overdrawn property based on new balance
            if (_balance >= 0 && Overdrawn)
            {
                Overdrawn = false;
            }
            else if (_balance < 0 && !Overdrawn)
            {
                Overdrawn = true;
            }
        }
        //Calculate amount for transaction based of transaction type
        public static decimal CalculateTransactionAmount(decimal Amount, TransactionType Type)
        {
            decimal amount = Amount;
            if (Type != TransactionType.Deposit)//make amount negative to subtract if not deposit
                amount = -amount;
            return amount;
        }

        //Invert amount to undo a transaction
        public static decimal CalculateTransactionAmount(decimal Amount, TransactionType Type, bool Removal)
        {
            return -(CalculateTransactionAmount(Amount, Type));
        }


        public override string ToString() 
        {
            return Balance.ToString("C");
        }

        #endregion
    }
}
