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

        private void SubmitTransactionEntry(object sender, EventArgs e)
        {
            this.TransactionData = new Transaction();
            this.TransactionData.Date = this.dateTransaction.Text;
            this.TransactionData.TransactionpartyId = this.txtId.Text;
            this.TransactionData.Type = this.cmBoxType.Text;
            this.TransactionData.RecurrentType = this.cmbBoxRecurrent.Text;
            this.TransactionData.Amount = this.txtAmount.Text;

            Console.WriteLine("sfshf" + TransactionData.Type);

        }
    }
}
