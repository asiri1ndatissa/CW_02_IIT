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
    public partial class WeeklyView : Form
    {
        public WeeklyView()
        {
            InitializeComponent();
        }

        private void SubmitView(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();

            MyDatabaseEntities db = new MyDatabaseEntities();
            EventDataModel eventDataModel = new EventDataModel();
            Cursor = Cursors.WaitCursor;
            var eventTable = eventDataModel.LoadEvents();
            foreach (var record in eventTable)
            {
                if (this.dateTimeWeeklyEvent.Value.Date <= record.Date.Date && record.Date.Date <= this.dateTimeWeeklyEvent.Value.AddDays(7) || record.Interval == "Weekly" ) {
                    this.eventDetailsBindingSource.Add(new EventDetails()
                    {
                        Date = record.Date,
                        Description = record.Description,
                        Type = record.Type,
                        Interval = record.Interval,
                        Amount = record.Amount
                    });
                }
                    
            }
            Cursor = Cursors.Arrow;
        }
    }
}
