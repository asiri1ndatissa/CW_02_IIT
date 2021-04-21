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

namespace CW_02
{
    public class TransactionPartyModel
    {
        public void SaveTransactionParty(DateTime date, String name, String description)
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
           

        }

        public List<int> LoadTransactionParty()
        {
            //  MyDatabaseEntities db = new MyDatabaseEntities();
            /*
                using (var context = new MyDatabaseEntities())
                {
                    var query = from st in context.TransactionParties

                                select st.Id;
                    Console.WriteLine("query" + query);


                }
            */
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
    }
}
