using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace CW_02
{
    public partial class EventAddView : Form
    {
        public EventAddView()
        {
            InitializeComponent();
        }
        public EventDetails EventDetailsData { get; set; }

        EventDataModel eventDataModel = new EventDataModel();
        private DBTransaction dbTansaction = new DBTransaction();

        private void SubmitEvent(object sender, EventArgs e)
        {
            this.EventDetailsData = new EventDetails();

            if (File.Exists(@"event.xml"))
            {
                this.dbTansaction.ReadXml(@"event.xml");
            }
            
            DBTransaction.EventRow row = this.dbTansaction.Event.NewEventRow();
            row.Amount = Convert.ToDouble(this.textBoxAmount.Text);
            row.Date = this.dateTimeEventDate.Value;
            row.Description = this.textBoxDescription.Text;
            row.Interval = this.comboBoxInterval.Text;
            row.Type = this.comboBoxType.Text;

            this.dbTansaction.Event.AddEventRow(row);
            this.dbTansaction.AcceptChanges();
            this.dbTansaction.WriteXml(@"event.xml");

            EventDataModel eventDataModel = new EventDataModel();
             eventDataModel.SaveEvent(this.dateTimeEventDate.Value, this.comboBoxInterval.Text, this.comboBoxType.Text,
                this.textBoxDescription.Text, Convert.ToDouble(this.textBoxAmount.Text));

            this.dbTansaction.Reset();
            File.Delete(@"event.xml");
            MessageBox.Show("Successfully Saved");
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
