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
    public partial class ProduceReport : Form
    {
        public ProduceReport()
        {
            InitializeComponent();
        }

        private void GenerateReport(object sender, EventArgs e)
        {
            GetTransactionData();
        }
        private void GetTransactionData()
        {
            this.dataGridView1.Rows.Clear();

            TransactionModel transactionModel = new TransactionModel();
            var transactionTable = transactionModel.LoadTransaction();

            TransactionPartyModel transactionPartyModel = new TransactionPartyModel();
            var transactionPartyTable = transactionPartyModel.LoadTransactionPartyDetails();

            foreach (var record in transactionTable)
            {
                if (this.dateTimeStartDate.Value.Date <= record.Date.Date && record.Date.Date <= this.dateTimeEndDate.Value.Date)
                {
                    this.transactionDataBindingSource.Add(new TransactionData(record.Date, record.Id, record.TransactionType,
                                                          record.RecurrentType, record.Amount));
                }


            }
        }
    }
}
