using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_02
{
    public class TransactionPartyModel
    {
        public TransactionPartyModel(String date, String iD,String name, String description)
        {
            this.Name = name;
            this.Date = date;
            this.TransactionPartyId = iD;
            this.Description = description;
        }

        String date;
        public String Date {
            get { return date; }
            set { date = value; }
        }
        String iD;
        public String TransactionPartyId {
            get { return iD; }
            set { iD = value; }
        }

        String name;
        public String Name {
            get { return name; }
            set { name = value; }
        }

        String description;
        public String Description {
            get { return description; }
            set { description = value; }
        }
       
    }
}
