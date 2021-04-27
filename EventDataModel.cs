using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_02
{
  public  class EventDataModel
    {
        public void SaveEvent(DateTime date, String interval,String type, String description,
                              double amount)
        {
            Event eventDetails = new Event();
            eventDetails.Amount = amount;
            eventDetails.Date = date;
            eventDetails.Interval = interval;
            eventDetails.Type = type;
            eventDetails.Description = description;

            MyDatabaseEntities db = new MyDatabaseEntities();
            db.Events.Add(eventDetails);
            db.SaveChanges();

        }
        public dynamic LoadEvents()
        {
            MyDatabaseEntities db = new MyDatabaseEntities();

            return db.Events;
        }
    }
}
