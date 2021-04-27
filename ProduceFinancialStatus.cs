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
    public partial class ProduceFinancialStatus : Form
    {
        public ProduceFinancialStatus()
        {
            InitializeComponent();
        }

        private void GeneratePrediction(object sender, EventArgs e)
        {

            TransactionModel transactionModel = new TransactionModel();
            var transactionTable = transactionModel.LoadTransaction();
            List<TransactionData> transactionList = new List<TransactionData>();
            List<double> expenseList = new List<double>();
            List<double> incomeList = new List<double>();
            int incomeCounter = 0;

            DateTime currentDate = DateTime.UtcNow.Date;
            DateTime predictionDate = dateTimePrediction.Value.Date;
            double DaysForPrediction = (predictionDate - currentDate).TotalDays;
            DateTime startingDate = currentDate.AddDays(-DaysForPrediction);


            foreach (var record in transactionTable)
            {
                if (record.Date.Date >= startingDate)
                {
                  //  transactionList.Add(new TransactionData(record.Date, record.Id,record.Type,record.RecurrentType,record.Amount));
                    if(record.TransactionType == "Expense")
                    {
                        expenseList.Add(record.Amount);

                    }else if(record.TransactionType == "Income")
                    {
                        incomeList.Add(record.Amount);
                    }
                }

            }

            //Use Simple moving average to calculate prediction based on historical data
            var simpleMovingAverageIncome = (double)System.Math.Round(incomeList.Sum() / DaysForPrediction, 2);
            var simpleMovingAverageExpense = (double)System.Math.Round(expenseList.Sum() / DaysForPrediction,2);


            this.textBoxIncome.Text = simpleMovingAverageIncome.ToString();
            this.textBoxExpense.Text = simpleMovingAverageExpense.ToString();
        }
    }
}
