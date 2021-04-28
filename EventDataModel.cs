using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CW_02
{
  public  class EventDataModel
    {
        Event eventDetails = new Event();
        public void SaveThroughThread()
        {
            MyDatabaseEntities db = new MyDatabaseEntities();
            db.Events.Add(eventDetails);
            db.SaveChanges();
        }
        public void SaveEvent(DateTime date, String interval,String type, String description,
                              double amount)
        {
           
            eventDetails.Amount = amount;
            eventDetails.Date = date;
            eventDetails.Interval = interval;
            eventDetails.Type = type;
            eventDetails.Description = description;

            Thread backgroundThread = new Thread(new ThreadStart(SaveThroughThread));
            backgroundThread.Start();

        }
        public dynamic LoadEvents()
        {
            MyDatabaseEntities db = new MyDatabaseEntities();

            return db.Events;
        }
    }
}
