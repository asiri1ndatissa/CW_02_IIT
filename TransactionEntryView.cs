using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_02
{
    public partial class TransactionEntryView : Form
    {
        public Transaction TransactionData { get; set; }

        public TransactionEntryView()
        {
            InitializeComponent();
        }
        private List<int> listId = new List<int>();

        TransactionPartyModel transactionPartyModel = new TransactionPartyModel();
   
        
        private void SubmitTransactionEntry(object sender, EventArgs e)
        {
            this.TransactionData = new Transaction();
            this.TransactionData.Date = this.dateTransaction.Value;
            this.TransactionData.TransactionPartyId = Int16.Parse(this.cmbId.Text);
            this.TransactionData.TransactionType = this.cmBoxType.Text;
            this.TransactionData.RecurrentType = this.cmbBoxRecurrent.Text;
            this.TransactionData.Amount = Convert.ToDouble(this.txtAmount.Text);

            Console.WriteLine("sfshf" + TransactionData.TransactionType);

        }

        private void TransactionEntryView_Load(object sender, EventArgs e)
        {
            listId = transactionPartyModel.LoadTransactionParty();
            listId.ForEach(i => this.cmbId.Items.Add(i));

        }

    
    }
}
