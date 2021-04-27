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

        private void SearchById(object sender, EventArgs e)
        {
            this.dataGridTransactionParty.Rows.Clear();
            MyDatabaseEntities db = new MyDatabaseEntities();
            TransactionPartyModel transactionPartyModel = new TransactionPartyModel();
            Cursor = Cursors.WaitCursor;
            var transactionPartyTable = db.TransactionParties;
            foreach (var record in transactionPartyTable)
            {
                if (this.txtSearchById.Text == record.Id.ToString())
                    this.contactDetailsBindingSource.Add(new ContactDetails(record.JoiningDate,record.TransactionPartyName
                                                        ,record.Description,record.Id));
            }
            Cursor = Cursors.Arrow;

        }

        private void GridTransactionPartyLoadData(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridTransactionParty.Columns[e.ColumnIndex].Name == "Delete")
            {
                int deleteId = (int)dataGridTransactionParty.Rows[e.RowIndex].Cells[0].Value;
                TransactionPartyModel transactionPartyModel = new TransactionPartyModel();
                transactionPartyModel.DeleteTransactionParty(deleteId);
                contactDetailsBindingSource.RemoveCurrent();
                MessageBox.Show("Successfully Updated");
            }
            else if (dataGridTransactionParty.Columns[e.ColumnIndex].Name == "Update")
            {
                TransactionPartyModel transactionPartyModel = new TransactionPartyModel();
                int selectId = (int)dataGridTransactionParty.Rows[e.RowIndex].Cells[0].Value;
                String name = (string)dataGridTransactionParty.Rows[e.RowIndex].Cells[2].Value;
                String description = (string)dataGridTransactionParty.Rows[e.RowIndex].Cells[3].Value; TransactionModel transactionModel = new TransactionModel();
                transactionPartyModel.UpdateTransactionParty(selectId,name,description);

                MessageBox.Show("Successfully Updated");
             
            }
        }
    }
}
