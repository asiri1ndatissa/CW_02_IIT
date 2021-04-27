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
    public partial class EditTransactionEntryView : Form
    {
        Transaction transaction1 = new Transaction();
        public EditTransactionEntryView()
        {
            InitializeComponent();
        }

       

        private void SearchByDate(object sender, EventArgs e)

        {
            string theDate = dateTimePicker.Value.ToString("yyyy-MM-dd");

            Console.WriteLine("date"+dateTimePicker.Value.Date);


            this.dataGridView1.Rows.Clear();
            Cursor = Cursors.WaitCursor;

            MyDatabaseEntities db = new MyDatabaseEntities();
            TransactionModel transaction = new TransactionModel();

            var transactionTable = db.Transactions;
           foreach(var record in transactionTable)
            {
                if (this.dateTimePicker.Value.Date == record.Date.Date)
                {
                    this.transactionDataBindingSource.Add(new TransactionData(record.Date, record.Id, record.TransactionType,
                                                          record.RecurrentType, record.Amount));
                }
             
            }
            Cursor = Cursors.Arrow;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Columns[e.ColumnIndex].Name == "DeleteRow")
            {
                int deleteId = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                TransactionModel transactionModel = new TransactionModel();
                transactionModel.DeleteTransaction(deleteId);
                transactionDataBindingSource.RemoveCurrent();
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Update")
            {
                Console.WriteLine("Update");
                int selectId = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                double updatedAmount = (double)dataGridView1.Rows[e.RowIndex].Cells[4].Value;
                TransactionModel transactionModel = new TransactionModel();
                transactionModel.UpdateTransaction(selectId, updatedAmount);

                MessageBox.Show("Successfully Updated");
                this.Close();
            }

        }

        private void EditTransactionEntryView_Load(object sender, EventArgs e)
        {

        }
    }
}
