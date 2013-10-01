using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace attfire1_assignment2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Database.SetInitializer(new DropCreateDatabaseAlways<MusicClassesContext>());
            InsertEnsembleRecord();
            InsertPersonRecord();
            Application.Run(new Form1());
        }

        private static void InsertEnsembleRecord()
        {
            using (var db = new MusicClassesContext())
            {
                IQueryable<Person> persons = from p in db.Person
                             where p.PersonId != null
                             select p;
                var ensemble = new Ensemble
                {
                    EnsembleName = "Beginners Ensemble",
                    EnsembleLevel = 1,
                    EnsembleLevelDesc = "An ensemble for beginners",
                    Person = persons.ToList()
                };

                db.Ensemble.Add(ensemble);
                db.SaveChanges();
                db.Database.Connection.Close();
            }
        }

        private static void InsertPersonRecord()
        {

            using (var db = new MusicClassesContext())
            {
            //List<Ensemble> ensembles = new List<Ensemble>();
                var ensembleID = (from e in db.Ensemble
                                  where e.EnsembleName == "Beginners Ensemble"
                                  select e.EnsembleId).FirstOrDefault();
            var person = new Person {
                FirstName = "Bob", 
                LastName = "Brown", 
                StreetAddress = "101 Tramway Road", 
                Suburb = "Chesapeake Bay", 
                Postcode = 9012, 
                EnsembleEnsembleId = ensembleID
            };
                db.Person.Add(person);
                db.SaveChanges();
                db.Database.Connection.Close();
            }
        }
    }
}
