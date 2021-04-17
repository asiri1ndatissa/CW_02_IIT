using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Xml;
using System.IO;
using System.Data.OleDb;
using System.Data.Entity;
using System.Data.Entity.Validation;



namespace CW_02
{
    public partial class TransactionPartyUI : Form
    {
        public ContactDetails ContactDetailsData { get; set; }
       

        SortedList transactionPartyModelList = new SortedList();

        private DBTransaction dbTansaction = new DBTransaction();
        public TransactionPartyUI()
        {
            InitializeComponent();
        }
        private void writeXML()
        {
          
         DBTransaction.TransactionPartyRow row =   this.dbTansaction.TransactionParty.NewTransactionPartyRow();
        }
        private void printOutTransactionpartyDetails(SortedList _contacts)
        {
           
            listBoxName.Items.Clear();
            foreach (object obj in _contacts)
            {
                ContactDetails st = (ContactDetails)((DictionaryEntry)obj).Value;
                String name = st.Name;
                listBoxName.Items.Add(name);
            }
        }

        private void SubmitTransactionParty(object sender, EventArgs e)
        {
           

            this.ContactDetailsData = new ContactDetails(this.dateTransactionParty.Value, this.txtTransactionPartyName.Text,
                                        this.txtTransactionPartyDescription.Text);
            
            if(File.Exists(@"data.xml"))
            {
                this.dbTansaction.ReadXml(@"data.xml");
            }

            DBTransaction.TransactionPartyRow row = this.dbTansaction.TransactionParty.NewTransactionPartyRow();
            row.Name = this.txtTransactionPartyName.Text;
            row.JoiningDate = this.dateTransactionParty.MinDate;
            row.Description = this.txtTransactionPartyDescription.Text;
            this.dbTansaction.TransactionParty.AddTransactionPartyRow(row);
            this.dbTansaction.AcceptChanges();
            this.dbTansaction.WriteXml(@"data.xml");

            TransactionPartyModel transactionPartyModel = new TransactionPartyModel();
            transactionPartyModel.SaveTransactionParty(this.ContactDetailsData.Date, 
                    this.ContactDetailsData.Name, this.ContactDetailsData.Description);

            this.dbTansaction.Reset();
            File.Delete(@"data.xml");
            MessageBox.Show("Successfully Saved");
            this.Close();
     
        }

      

        private void printOutContactsDetails(object sender, EventArgs e)
        {
            TransactionPartyModel transactionPartyModel = new TransactionPartyModel();
            transactionPartyModel.LoadTransactionParty();
        }
    }
}
