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



namespace CW_02
{
    public partial class TransactionPartyUI : Form
    {
        // public TransactionPartyModel TransactionPartyData { get; set; }
       

        SortedList transactionPartyModelList = new SortedList();

        private DBTransaction dbTansaction = new DBTransaction();
        public TransactionPartyUI()
        {
            InitializeComponent();
        }
        private void writeXML()
        {
            String workingDir = Directory.GetCurrentDirectory();
            XmlTextWriter textWriter = new XmlTextWriter("transactionPartyXMLFile.xml", System.Text.Encoding.UTF8);
            textWriter.WriteStartDocument();
            textWriter.WriteComment("First Comment XmlTextWriterSample Example");
            textWriter.WriteComment("myXmlFile.xml in root dir");


            // Write first element
            textWriter.WriteStartElement("Transaction Party");
            // Write next element
            textWriter.WriteStartElement("Name", "");
            textWriter.WriteString(this.txtTransactionPartyName.Text);
            textWriter.WriteEndElement(); // Write some more
             textWriter.WriteStartElement("Id",""); 
            textWriter.WriteString(this.txtTransactionpartyId.Text); 
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("Date", "");
            textWriter.WriteString(this.dateTransactionParty.Text);
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("Description", "");
            textWriter.WriteString(this.txtTransactionPartyDescription.Text);
            textWriter.WriteEndElement();
            textWriter.WriteEndElement(); // Ends the
            textWriter.WriteEndDocument();

            textWriter.Flush();
            textWriter.Close();

            // close writer textWriter.Close();

         DBTransaction.TransactionPartyRow row =   this.dbTansaction.TransactionParty.NewTransactionPartyRow();
        }
        private void printOutTransactionpartyDetails(SortedList _contacts)
        {
           
            listBoxParty.Items.Clear();
            listBoxName.Items.Clear();
            foreach (object obj in _contacts)
            {
                TransactionPartyModel st = (TransactionPartyModel)((DictionaryEntry)obj).Value;
                String name = st.Name;
                String Id = st.TransactionPartyId;
                listBoxParty.Items.Add(Id);
                listBoxName.Items.Add(name);
            }
        }

        private void SubmitTransactionParty(object sender, EventArgs e)
        {
            try
            {
                transactionPartyModelList.Add(txtTransactionpartyId.Text, new TransactionPartyModel(this.dateTransactionParty.Text,
                    this.txtTransactionpartyId.Text,this.txtTransactionPartyName.Text,
                   this.txtTransactionPartyDescription.Text));
                DBTransaction.TransactionPartyRow row = this.dbTansaction.TransactionParty.NewTransactionPartyRow();
                row.TransactionPartyId = this.txtTransactionpartyId.Text;
                row.Name = this.txtTransactionPartyName.Text;
                row.JoiningDate = this.dateTransactionParty.Text;
                row.Description = this.txtTransactionPartyDescription.Text;
                this.dbTansaction.TransactionParty.AddTransactionPartyRow(row);
                this.dbTansaction.AcceptChanges();
               // this.dbTansaction.WriteXml("data.xml");
            }
            catch (Exception ex)
            {
                labelMessage.Text = "";
                labelMessage.BackColor = Color.Red;
                labelMessage.Text = ex.Message;
            }

            writeXML();
     
        }

      

        private void printOutContactsDetails(object sender, EventArgs e)
        {
            printOutTransactionpartyDetails(transactionPartyModelList);
        }
    }
}
