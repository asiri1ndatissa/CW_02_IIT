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
       /*     textWriter.WriteStartElement("Transaction Party");
            // Write next element
            textWriter.WriteElementString("Name", this.txtTransactionPartyName.Text);
            textWriter.WriteEndElement(); // Ends the
            textWriter.WriteElementString("Id", this.txtTransactionpartyId.Text);
            textWriter.WriteEndElement(); // Ends the
            textWriter.WriteElementString("Date", this.dateTransactionParty.Text);
            textWriter.WriteEndElement(); // Ends the
            textWriter.WriteElementString("Description", this.txtTransactionPartyDescription.Text);
            textWriter.WriteEndElement(); // Ends the
            textWriter.WriteEndDocument();
            textWriter.Flush();
            textWriter.Close();
       */

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
        }
        private void printOutTransactionpartyDetails(SortedList _contacts)
        {
            //this populates the list box with the student 
            //clear it first
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
                transactionPartyModelList.Add(txtTransactionpartyId.Text, new TransactionPartyModel(this.dateTransactionParty.Text,this.txtTransactionpartyId.Text,this.txtTransactionPartyName.Text,
                   this.txtTransactionPartyDescription.Text));
            }
            catch(Exception ex)
            {
                labelMessage.Text = "";
                labelMessage.BackColor = Color.Red;
                labelMessage.Text = ex.Message;
            }

            writeXML();
         /*   this.TransactionPartyData = new TransactionPartyModel();
            this.TransactionPartyData.Date = this.dateTransactionParty.Text;
            this.TransactionPartyData.TransactionPartyId = this.txtTransactionpartyId.Text;
            this.TransactionPartyData.Name = this.txtTransactionPartyName.Text;
            this.TransactionPartyData.Description = this.txtTransactionPartyDescription.Text;
         */
        }

      

        private void printOutContactsDetails(object sender, EventArgs e)
        {
            printOutTransactionpartyDetails(transactionPartyModelList);
        }
    }
}
