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
            InsertSheetMusicRecord();
            InsertPersonSheetMusicRecord();
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

        private static void InsertSheetMusicRecord()
        {
            using (var db = new MusicClassesContext())
            {
                var sheetMusic = new SheetMusic()
                {
                    Title = "Bohemian Rhapsody - Orchestra Version", 
                    ComposerName = "Freddy Mercury", 
                    DifficultyLevel = 2, 
                    NumberOfAuthCopies = 100, 
                    ScoreType = "Orchestral"
                };

                db.SheetMusic.Add(sheetMusic);
                db.SaveChanges();
                db.Database.Connection.Close();
            }
        }

        private static void InsertPersonSheetMusicRecord()
        {
            using (var db = new MusicClassesContext())
            {
                int personID = (from p in db.Person
                               where p.FirstName == "Bob" && p.LastName == "Brown"
                               select p.PersonId).First();

                int sheetMusicID = (from sm in db.SheetMusic
                                    where sm.Title == "Bohemian Rhapsody - Orchestra Version"
                                    select sm.SheetMusicId).First();

                var personSheetMusic = new PersonSheetMusic()
                {
                    PersonPersonId = personID,
                    SheetMusicSheetMusicId = sheetMusicID
                };

                db.PersonSheetMusic.Add(personSheetMusic);
                db.SaveChanges();
                db.Database.Connection.Close();
            }
        }
    }
}
