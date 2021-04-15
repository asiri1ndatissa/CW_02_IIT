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
    public partial class TransactionPartyUI : Form
    {
        public TransactionPartyModel TransactionPartyData { get; set; }
        public TransactionPartyUI()
        {
            InitializeComponent();
        }

        private void SubmitTransactionParty(object sender, EventArgs e)
        {
            this.TransactionPartyData = new TransactionPartyModel();
            this.TransactionPartyData.Date = this.dateTransactionParty.Text;
            this.TransactionPartyData.TransactionPartyId = this.txtTransactionpartyId.Text;
            this.TransactionPartyData.Name = this.txtTransactionPartyName.Text;
            this.TransactionPartyData.Description = this.txtTransactionPartyDescription.Text;
        }
    }
}
