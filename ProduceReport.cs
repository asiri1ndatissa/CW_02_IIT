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

        private async void GenerateReport(object sender, EventArgs e)
        {
           await GetTransactionDataAsync();
        }
        private async Task GetTransactionDataAsync()
        {
            this.dataGridView1.Rows.Clear();
       

            TransactionModel transactionModel = new TransactionModel();
            Cursor = Cursors.WaitCursor;
            
            var transactionTable = await Task.Run(() => transactionModel.LoadTransaction());
            List<double> expenseList = new List<double>();
            List<double> incomeList = new List<double>();

            foreach (var record in transactionTable)
            {
                if (this.dateTimeStartDate.Value.Date <= record.Date.Date && record.Date.Date <= this.dateTimeEndDate.Value.Date)
                {
                    this.transactionDataBindingSource.Add(new TransactionData(record.Date, record.Id, record.TransactionType,
                                                          record.RecurrentType, record.Amount));
                    if (record.TransactionType == "Expense")
                    {
                        expenseList.Add(record.Amount);

                    }
                    else if (record.TransactionType == "Income")
                    {
                        incomeList.Add(record.Amount);
                    }
                }
            }
            var currentBalance = (double)System.Math.Round((incomeList.Sum() -expenseList.Sum()),2);
            this.textBoxBalance.Text = currentBalance.ToString();
            Cursor = Cursors.Arrow;

        }
    }
}
