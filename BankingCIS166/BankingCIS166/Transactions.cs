using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace BankingCIS166
{
    class Transactions : System.Collections.CollectionBase
    {
        #region Variables and Properties
        BankBalance Balance;//Holds all transaction balance

        public decimal AccountBalance
        {
            get { return Balance.Balance; }
        }

        public bool Overdrawn
        {
            get { return Balance.Overdrawn; }
        }

        public string FileName
        {
            get { return Properties.Settings.Default.SaveFilePath; ; }
            set
            { 
                Properties.Settings.Default.SaveFilePath = value;
                Properties.Settings.Default.Save();
            }
        }

        #endregion

        public Transactions()
        {
            Balance = new BankBalance();// Holds balance
            if (FileNameMissing())
                SetFileName();
        }

        public Transactions(decimal StartingBalance)
        {
            Balance = new BankBalance(StartingBalance);
            if (FileNameMissing())
                SetFileName();
        }

        #region Public Procedures
        //Add Transaction to Collection
        public void Add(Transaction NewTransaction)
        {
            List.Add(NewTransaction);
            Balance.AdjustBalance(NewTransaction.Amount, NewTransaction.Type);
        }

        //Indexer
        public Transaction this[int Index]
        {
            get
            {
                if (IndexIsValid(Index))
                    return (Transaction)List[Index];
                else
                    throw new ApplicationException("Index out of range");
            }
            set
            {
                if (IndexIsValid(Index))
                    this[Index] = value;
                else
                    throw new ApplicationException("Index out of range");
            }
        }

        //Remove transaction from list at given index and update the balance
        public void RemoveAt(int Index)
        {
            if (IndexIsValid(Index))//index must refer to an item in the list
            {
                Transaction RemoveTransaction = this[Index];//holds values of transaction

                List.RemoveAt(Index);//Remove transaction from list
                Balance.AdjustBalance(RemoveTransaction.Amount,RemoveTransaction.Type,true); //Undo the transaction
            }
            else
            {
                throw new ApplicationException("Index is out of range, can't remove transaction");
            }
        }

        //Remove the transaction in the list at the given index and add a new transaction at the same position
        public void UpdateTransaction(int Index, Transaction NewTransaction)
        {
            if (IndexIsValid(Index))
            {
                decimal NewAmount = BankBalance.CalculateTransactionAmount(NewTransaction.Amount, NewTransaction.Type);

                RemoveAt(Index);//This will update balance as well
                List.Insert(Index, NewTransaction);
                Balance.AdjustBalance(NewAmount,NewTransaction.Type);
            }
            else
            {
                throw new ApplicationException("Index is out of range, can't update transaction");
            }
        }


        //Read values from file
        public void FileOpen()
        {
            if (FileNameMissing())//Check if file name is entered
            {
                throw new ApplicationException("File name is empty, can't read file");
            }
            else
            {
                if (File.Exists(FileName))
                {
                    StreamReader reader = new StreamReader(FileName);

                    while (reader.Peek() != -1)
                    {
                        //read line
                        string data = reader.ReadLine();

                        //Store data
                        string[] values = data.Split(',');//(new char[] { ',' });

                        //Create new transaction from data
                        try
                        {
                            //Collect and format data from array
                            DateTime TransDate = DateTime.Parse(values[0]);
                            decimal TransAmount = decimal.Parse(values[1]);
                            TransactionType TransType = (TransactionType)Enum.Parse(typeof(TransactionType), values[2], true);
                            string TransPayee = values[3];
                            string TransCheck = values[4];

                            //Create and add transaction
                            this.Add(new Transaction(TransDate, TransAmount, TransType, TransPayee, TransCheck));
                            
                        }
                        catch
                        {
                            Console.WriteLine("Error reading data" + Environment.NewLine +
                                data);
                        }
                    }
                    reader.Close();
                }
            }

            
        }
        public void SetFileName()
        {
            SaveFileDialog SaveDialog = new SaveFileDialog();
            SaveDialog.Filter = "text files (*.txt)|*.txt|all files|*.*";
            SaveDialog.CheckPathExists = true;
            SaveDialog.Title = "Select save location";

            if (SaveDialog.ShowDialog() == DialogResult.OK)
            {
                this.FileName = SaveDialog.FileName;
            }
            else
            {
                SetFileName();
            }
        }

        //Save transactions to file
        public void FileSave()
        {
            if (FileNameMissing())
            {
                Console.WriteLine("File name not specified, transactions could not be saved");
            }
            else //Save file path entered
            {
                try
                {
                    StreamWriter Writer = new StreamWriter(FileName);
                    
                    /*Write each transaction's values to file
                     *Date,Amount,TransactionType,Payee,Check*/
                    foreach (Transaction Trans in this)
                    {
                        string data = string.Format("{0},{1},{2},{3},{4}", Trans.Date.ToShortDateString(),
                            Trans.Amount.ToString(),Trans.Type.ToString(),Trans.Payee,Trans.Check);
                        Writer.WriteLine(data);
                    }
                    Writer.Close();
                }
                catch (Exception SaveException)
                {
                    Console.WriteLine(SaveException.Message);
                }
            }
        }

        #endregion

        #region Private Procedure

        private bool FileNameMissing()
        {
            return string.IsNullOrEmpty(FileName);
        }
        //Check if Index is within range of transaction
        private bool IndexIsValid(int Index)
        {
            return (Index < Count && Index >= 0);
        }
        #endregion
    }
}
