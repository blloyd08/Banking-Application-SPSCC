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
    //Acceptable transaction Types
    enum TransactionType
    {
        Deposit,
        Withdraw,
        ServiceFee
    }    

    class Transaction
    {

        #region Class Variables

        //Exeception Error Messages
        const string AMOUNTEXPT = "Amount must be greater than 0";
        //Used on ToString to space text as columns
        public const int COLUMNWIDTH = 21;

        //Hold Transaction Date
        private DateTime _date;
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        //Transaction type
        private TransactionType _type;
        public TransactionType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        //Transaction amount
        private Decimal _amount;
        public Decimal Amount
        {
            get { return _amount; }
            set 
            {
                if (DecimalExcedeZero(value))
                {
                    _amount = value;
                }
                else
                {
                    throw new ApplicationException(AMOUNTEXPT);
                }
            }
        }

        //Transaction payee 
        private string _payee;
        public string Payee
        {
            get { return _payee; }
            set { _payee = value; }
        }

        //Transaction check number
        private string _check;
        public string Check
        {
            get { return _check; }
            set { _check = value; }
        }

        #endregion

        #region Constructors
        public Transaction() { }

        public Transaction(DateTime Date, decimal Amount, TransactionType Type, string Payee, string Check)
        {
            this.Date = Date;
            this.Amount = Amount;
            this.Type = Type;
            this.Payee = ValidPayee(Type, Payee);
            this.Check = Check;
        }

        #endregion

        #region Public Methods

        //Return Date, Type, and amount of transaction as a string formatted with spacing to give the appearance of collumns
        public override string ToString()
        {
            //return Date.ToShortDateString() + " " + Type.ToString() + " " + Amount.ToString("c");
            string[] ValuesArray = new string[] { Date.ToShortDateString(), Type.ToString(), Amount.ToString("C") };
            return FormatToColumns(ValuesArray);
        }

        //Add spaces after each string in an array to give the appearance of collumns
        public static string FormatToColumns(string[] WordArray)
        {
            string RowText = "";
            string NewWord = "";
            int SpacesNeeded;

            for (int i = 0; i < WordArray.Length; i++)
            {
                NewWord = WordArray[i];//Column Heading Word
                SpacesNeeded = COLUMNWIDTH - NewWord.Length;//How many spaces need to be added to space columns
                RowText += NewWord;

                for (int Spaces = SpacesNeeded; Spaces >= 0; Spaces--)
                {
                    RowText += " ";
                }
            }
            return RowText;
        }

        //Tests to make sure decimal is greater than zero. Intended to test transaction amount
        public static bool DecimalExcedeZero(decimal TestAmount)
        {
            return TestAmount > 0;
        }

        //Determine if string can be parsed as decimal
        public static bool IsDecimal(string DecimalString)
        {
            decimal Results;
            return decimal.TryParse(DecimalString, out Results);
        }

        //Determine if string can be parsed as  DateTime
        public static bool IsDate(string DateString)
        {
            DateTime ParsedDate;
            return DateTime.TryParse(DateString,out ParsedDate);
        }

        //Determine if string can be parsed as Integer
        public static bool IsInteger(string IntegerString)
        {
            int Results;
            return int.TryParse(IntegerString, out Results);
        }

        public string ValidPayee(TransactionType Type, string Payee)
        {
            string ValidPayee;

            if (Type == TransactionType.Withdraw)
            {
                if (string.IsNullOrEmpty(Payee))
                {
                    throw new ApplicationException("Must be payee during withdraw");
                }
                else
                {
                    ValidPayee = Payee;
                }
            }
            else
            {
                ValidPayee = "No Payee";
            }

            return ValidPayee;
        }
        #endregion

    }
}
