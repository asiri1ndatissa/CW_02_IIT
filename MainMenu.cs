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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ShowManageTransactionView(object sender, EventArgs e)
        {
            TransactionUI transactionUI = new TransactionUI();
            transactionUI.Activate();
            transactionUI.ShowDialog();
        }

        private void ShowManageTransactionPartyView(object sender, EventArgs e)
        {
            ManageTransactionParty manageTransactionParty = new ManageTransactionParty();
            manageTransactionParty.Activate();
            manageTransactionParty.ShowDialog();
        }

        private void ShowProduceReportView(object sender, EventArgs e)
        {
            ProduceReport produceReport = new ProduceReport();
            produceReport.Activate();
            produceReport.ShowDialog();
        }

        private void ShowPrediction(object sender, EventArgs e)
        {
            ProduceFinancialStatus produceFinancialStatus = new ProduceFinancialStatus();
            produceFinancialStatus.Activate();
            produceFinancialStatus.ShowDialog();
        }

        private void LoadManageEventView(object sender, EventArgs e)
        {
            EventUI eventUI = new EventUI();
            eventUI.Activate();
            eventUI.ShowDialog();
        }
    }
}
