using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_02
{
    public class ContactDetails
    {
    

    public ContactDetails(DateTime date, String name, String description)
        {
            this.Name = name;
            this.Date = date;
            this.Description = description;
        }

        DateTime date;
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }


        String name;
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        String description;
        public String Description
        {
            get { return description; }
            set { description = value; }
        }

    }
}

