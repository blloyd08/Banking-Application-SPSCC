using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/*
 * Author:      Brian Lloyd
 * Date:        03/2014
 * Project:     Homework 8 Banking (BankingCIS166)
 * Description: Calculate user bank account balance after transactions and adds to listbox using a class.
 *              Use a collection class to manage transactions
 *              Load and save transactions using a txt file       
 */

namespace BankingCIS166
{
    public partial class BankingForm : Form
    {
        //private BankBalance AccountBalance = new BankBalance(STARTINGBALANCE);
        private TransactionType SelectedType; //Hold selected Transaction Type
        private Transactions Transactions;//Collection of transactions

        //Error messages string format
        private const string AMOUNTINPUTERROR = "Amount must be a number greater than zero";//Parsed amount is <= 0
        private const string DATEINPUTERROR = "Can't identify date {0}"; //Failed to parse date
        private const string PAYEEINPUTERROR = "Payee must be entered"; //Payee required when type is withdraw

        private const decimal STARTINGBALANCE = 0.00M;//Starting balance set at form load
        private string[] HEADING = new string[] { "Date", "Type", "Amount"};

        public BankingForm()
        {
            InitializeComponent();
        }

        //Initialize variables at program launch
        private void BankingForm_Load(object sender, EventArgs e)
        {
            Transactions = new Transactions(STARTINGBALANCE);
            UpdateBalanceLabel(); //Update balance label text to current balance amount
            DatePicker.Value = DateTime.Today;

            //Assign radio button tag to transaction type
            DepositRadioButton.Tag = TransactionType.Deposit;
            WithdrawRadioButton.Tag = TransactionType.Withdraw;
            FeeRadioButton.Tag = TransactionType.ServiceFee;
            DepositRadioButton.Checked = true;

            TransListBox.Font = new Font(FontFamily.GenericMonospace, AmountTextBox.Font.Size);//Font must be monospace
            BalanceLabel.ForeColor = Color.Black;

            ApplyListBoxHeading();//Add text to heading label that matches columns in listbox

            //Add all transaction details from collection into listbox
            Transactions.FileOpen();
            foreach (Transaction trans in Transactions)
            {
                TransListBox.Items.Add(trans.ToString());
            }
            UpdateBalanceLabel();
        }

        //Format heading label to match columns
        private void ApplyListBoxHeading()
        { 
            HeadingLabel.Font = new Font(FontFamily.GenericMonospace, AmountTextBox.Font.Size);
            
            HeadingLabel.Text = Transaction.FormatToColumns(HEADING);
        }

        #region Validation Functions

        //Check validity of important fields
        private bool UserInputCompleted()
        {
            bool InputComplete = true;//Flag

            if (!Transaction.IsDate(DatePicker.Text))//Date can be parsed
            {
                InputComplete = false;
                ValidationErrorProvider.SetError(DatePicker, string.Format(DATEINPUTERROR, DatePicker.Text));
            }
            if (!Transaction.IsDecimal(AmountTextBox.Text)) //Parsed as decimal
            {
                InputComplete = false;
                ValidationErrorProvider.SetError(AmountTextBox, AMOUNTINPUTERROR);
            }
            if (WithdrawRadioButton.Checked)//Payee entered if withdraw type selected
            {
                if (PayeeTextBox.Text == string.Empty)
                {
                    InputComplete = false;
                    ValidationErrorProvider.SetError(PayeeTextBox, PAYEEINPUTERROR);
                }
            }
            return InputComplete;
        }
        #endregion

        #region EventHandlers
        //Clear all text boxes and errors messages
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearUserInput();
        }

        //Exit Program
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Collect user input, validate input, update balance if validation passed, clear form
        private void AddTransButton_Click(object sender, EventArgs e)
        {
            ValidationErrorProvider.Clear(); //Clear previous errors

            if (UserInputCompleted())//User input is in correct format
            {
                decimal TempAmount = decimal.Parse(AmountTextBox.Text);
                if (Transaction.DecimalExcedeZero(TempAmount))//Amount is greater than Zero
                {
                    //Create Transaction
                    Transaction NewTransaction = new Transaction(DatePicker.Value, TempAmount, SelectedType, PayeeTextBox.Text,
                        CheckTextBox.Text);
                    Transactions.Add(NewTransaction);//Add Transaction to TransactionList
                    UpdateBalanceLabel();//Display new balance

                    TransListBox.Items.Add(NewTransaction.ToString());//Add transaction to listbox
                }
            }
        }

        //Save selected type from newly checked radio button tag
        private void RadioButton_CheckedChanged(object CheckedButton, EventArgs e)
        {
            RadioButton MyRadioButton = (RadioButton)CheckedButton;
            if (MyRadioButton.Checked)
                SelectedType = (TransactionType)MyRadioButton.Tag;
        }

        //remove selected item from listbox, remove from array, move items to prevent empty spaces in array
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int SelectedIndex = TransListBox.SelectedIndex;
            if (SelectedIndex != -1)//if item is selected
            {
                Transactions.RemoveAt(SelectedIndex);
                TransListBox.Items.RemoveAt(SelectedIndex);
                UpdateBalanceLabel();//Display new balance in label
            }
        }

        //Display transaction details when user selects item in listbox
        private void TransListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SelectedIndex = TransListBox.SelectedIndex; //Used to reduce coding
            if (SelectedIndex != -1)
            {
                //Assign form controls values to controls
                Transaction SelectedTrans = Transactions[SelectedIndex];
                AmountTextBox.Text = SelectedTrans.Amount.ToString();
                FindAndCheckType(SelectedTrans.Type);//Select the apporiate radio button
                DatePicker.Value = SelectedTrans.Date;
                PayeeTextBox.Text = SelectedTrans.Payee;
                CheckTextBox.Text = SelectedTrans.Check;
            }
        }

        #endregion

        //Update balance label to reflect current balance, used to gurrantee currancy format
        private void UpdateBalanceLabel()
        {
            decimal Balance = Transactions.AccountBalance;
            BalanceLabel.Text = Balance.ToString("C");
            Color LabelColor = BalanceLabel.ForeColor;
            if (Balance >= 0 && LabelColor == Color.Red)
            {
                BalanceLabel.ForeColor = Color.Black;
            }
            else if(Balance < 0 && LabelColor == Color.Black)
            {
                BalanceLabel.ForeColor = Color.Red;
            }
        }

        //Clear text boxes and errors, send focus back to Date
        private void ClearUserInput()
        {
            DatePicker.Value = DateTime.Today;
            DepositRadioButton.Checked = true;
            AmountTextBox.Text = "";
            PayeeTextBox.Text = "";
            CheckTextBox.Text = "";
            ValidationErrorProvider.Clear();
            DepositRadioButton.Focus();
        }

        //Check the radio box that matches the supplied Transaction Type
        private void FindAndCheckType(TransactionType SelectedType)
        {
            switch (SelectedType)
            {
                case TransactionType.Deposit:
                    DepositRadioButton.Checked = true;
                    break;
                case TransactionType.ServiceFee:
                    FeeRadioButton.Checked = true;
                    break;
                case TransactionType.Withdraw:
                    WithdrawRadioButton.Checked = true;
                    break;
            }
        }

        //Save transactions for future use
        private void BankingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Transactions.FileSave();
        }

        //Change the save file path
        private void changeSaveLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transactions.SetFileName();    
        }
    }
}
