﻿using System;
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
    public partial class TransactionUI : Form
    {
        public TransactionUI()
        {
            InitializeComponent();
        }

        private void ShowTransactionEntryView(object sender, EventArgs e)
        {
            TransactionEntryView transactionEntryView = new TransactionEntryView();
            transactionEntryView.Activate();
            transactionEntryView.ShowDialog();

            this.Hide();
        }

        private void ShowEditTransactionView(object sender, EventArgs e)
        {
            EditTransactionEntryView editTransactionEntryView = new EditTransactionEntryView();
            editTransactionEntryView.Activate();
            editTransactionEntryView.Show();
        }
    }
}
