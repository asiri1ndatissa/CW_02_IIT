using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Xml;
using System.IO;
using System.Data.OleDb;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Threading.Tasks;

namespace CW_02
{
    public class TransactionPartyModel
    {
        public void SaveTransactionParty(DateTime date, String name, String description)
        {

            Task t = Task.Run(() =>
            {
                TransactionParty contact = new TransactionParty();
                contact.Description = description;
                contact.JoiningDate = date;
                contact.TransactionPartyName = name;
                MyDatabaseEntities db = new MyDatabaseEntities();

                try
                {
                    db.TransactionParties.Add(contact);
                    db.SaveChanges();

                }
                catch (DbEntityValidationException ex)
                {
                    // Retrieve the error messages as a list of strings.
                    var errorMessages = ex.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);

                    // Join the list to a single string.
                    var fullErrorMessage = string.Join("; ", errorMessages);

                    // Combine the original exception message with the new one.
                    var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                    // Throw a new DbEntityValidationException with the improved exception message.
                    throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
                }

            });
            t.Wait();
           

        }

        /*public void SaveTransaction(DateTime date, int transactionId, String transactionType,
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
        }*/

        public List<int> LoadTransactionParty()
        {
           
            MyDatabaseEntities db = new MyDatabaseEntities();

            var table = db.TransactionParties;
            List<int> list = new List<int>();

            foreach (var record in table)
            {
                list.Add(record.Id);
          //      Console.WriteLine("sdjsd" + record.Id);
            }
            return list;
        }
        public dynamic LoadTransactionPartyDetails()
        {
            MyDatabaseEntities db = new MyDatabaseEntities();

            return db.TransactionParties;
        }
        public void DeleteTransactionParty(int id)
        {
            TransactionParty contact = new TransactionParty();

            MyDatabaseEntities db = new MyDatabaseEntities();
            var transactionItem = db.TransactionParties.Find(id);
            db.TransactionParties.Remove(transactionItem);
            db.SaveChanges();
        }

        public void UpdateTransactionParty(int id, string name, string description)
        {
            TransactionParty transactionParty = new TransactionParty();

            transactionParty.Id = id;
            transactionParty.TransactionPartyName = name;
            transactionParty.Description = description;

            MyDatabaseEntities db = new MyDatabaseEntities();
            var transactionPartyItem = db.TransactionParties.Find(id);
            transactionPartyItem.Description = transactionParty.Description;
            transactionPartyItem.TransactionPartyName = transactionParty.TransactionPartyName;
            db.SaveChanges();
        }
    }
}
