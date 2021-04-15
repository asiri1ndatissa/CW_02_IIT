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
    public partial class ManageTransactionParty : Form
    {
        public ManageTransactionParty()
        {
            InitializeComponent();
        }

        private void UpdateTransactionParty(object sender, EventArgs e)
        {

        }

        private void DeleteTransactionParty(object sender, EventArgs e)
        {

        }

        private void ShowAddTransactionPartyView(object sender, EventArgs e)
        {
            TransactionPartyUI transactionPartyUI = new TransactionPartyUI();
            transactionPartyUI.Activate();
            transactionPartyUI.ShowDialog();
        }
    }
}
