using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace CW_02
{
    public partial class TransactionEntryView : Form
    {
        public Transaction TransactionData { get; set; }

        private DBTransaction dBTransaction = new DBTransaction();

        public TransactionEntryView()
        {
            InitializeComponent();
        }
        private List<int> listId = new List<int>();

        TransactionPartyModel transactionPartyModel = new TransactionPartyModel();
   
        
        private async void SubmitTransactionEntry(object sender, EventArgs e)
        {
            this.TransactionData = new Transaction();
            this.TransactionData.Date = this.dateTransaction.Value;
            this.TransactionData.TransactionPartyId = Int16.Parse(this.cmbId.Text);
            this.TransactionData.TransactionType = this.cmBoxType.Text;
            this.TransactionData.RecurrentType = this.cmbBoxRecurrent.Text;
            this.TransactionData.Amount = Convert.ToDouble(this.txtAmount.Text);

            Console.WriteLine("sfshf" + TransactionData.TransactionType);

            if (File.Exists(@"transaction.xml"))
            {
                this.dBTransaction.ReadXml(@"transaction.xml");
            }

            DBTransaction.TransactionRow row = this.dBTransaction.Transaction.NewTransactionRow();
            row.Amount = this.txtAmount.Text;
            row.RecurrentType = this.cmbBoxRecurrent.Text;
            row.FK_TransactionPartyId = this.cmbId.SelectedIndex;
            row.TransactionType = this.cmBoxType.Text;
            this.dBTransaction.Transaction.AddTransactionRow(row);
            this.dBTransaction.AcceptChanges();
            this.dBTransaction.WriteXml(@"transaction.xml");

            TransactionModel transactionModel = new TransactionModel();
            Cursor = Cursors.WaitCursor;

            await transactionModel.SaveTransactionAsync(this.TransactionData.Date,
                                       this.TransactionData.TransactionPartyId,
                                       this.TransactionData.TransactionType, this.TransactionData.RecurrentType, 
                                       this.TransactionData.Amount);

            this.dBTransaction.Reset();
            Cursor = Cursors.Arrow;

            File.Delete(@"transaction.xml");
            MessageBox.Show("Successfully Saved");
            this.Close();
        }

        private  void TransactionEntryView_Load(object sender, EventArgs e)
        {
            listId = transactionPartyModel.LoadTransactionParty();
            listId.ForEach(i => this.cmbId.Items.Add(i));
            this.dataGridTransactionParty.Rows.Clear();
            MyDatabaseEntities db = new MyDatabaseEntities();
            TransactionPartyModel transactionPartyModelDetail = new TransactionPartyModel();
            Cursor = Cursors.WaitCursor;
            var transactionPartyTable = transactionPartyModelDetail.LoadTransactionPartyDetails();
            foreach (var record in transactionPartyTable)
            {
              
                    this.contactDetailsBindingSource.Add(new ContactDetails(record.JoiningDate, record.TransactionPartyName
                                                        , record.Description, record.Id));
            }
            Cursor = Cursors.Arrow;

        }
    }
}
