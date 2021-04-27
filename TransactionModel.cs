using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_02
{
  public class TransactionModel
    {
        public void SaveTransaction(DateTime date, int transactionId, String transactionType,
                                     String recurrentType, double amount)
        {
            Transaction transaction = new Transaction();
            transaction.Amount = amount;
            transaction.Date = date;
            transaction.TransactionPartyId = transactionId;
            transaction.RecurrentType = recurrentType;
            transaction.TransactionType = transactionType;

            MyDatabaseEntities db = new MyDatabaseEntities();
            db.Transactions.Add(transaction);
            db.SaveChanges();

        }
        public dynamic LoadTransaction()
        {
            MyDatabaseEntities db = new MyDatabaseEntities();

            return db.Transactions;
        }

        public void DeleteTransaction(int id)
        {
            Transaction transaction = new Transaction();
            MyDatabaseEntities db = new MyDatabaseEntities();
            var transactionItem = db.Transactions.Find(id);
            db.Transactions.Remove(transactionItem);
            db.SaveChanges();
        }

        public void UpdateTransaction(int id, double amount)
        {
            Transaction transaction = new Transaction();
            transaction.TransactionPartyId = id;
            transaction.Amount = amount;

            MyDatabaseEntities db = new MyDatabaseEntities();
            var transactionItem = db.Transactions.Find(id);
            transactionItem.Amount = transaction.Amount;
            db.SaveChanges();
        }

    }
}
