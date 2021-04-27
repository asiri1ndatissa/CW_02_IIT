using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_02
{
    public class TransactionData
    {
        public TransactionData(DateTime date, int id, String type,String recurrentType, double amount)
            {
            this.Type = type;
            this.Date = date;
            this.Id = id;
            this.RecurrentType = recurrentType;
            this.Amount = amount;
        }
        public DateTime Date { get ; set ; }
          public String Type { get; set;}
          public int Id { get; set; }
          public String RecurrentType { get; set; }
         public double Amount { get; set; }
    }
}
