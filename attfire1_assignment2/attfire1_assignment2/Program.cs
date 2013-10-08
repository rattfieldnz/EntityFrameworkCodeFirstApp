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
            InsertConditionRecord();
            InsertRepairStatusRecord();
            InsertInstrumentRecord();
            InsertEnsembleRecord();
            InsertPersonRecord();
            InsertSheetMusicRecord();
            InsertPersonSheetMusicRecord();
            InsertPositionsHeldRecord();
            InsertTutorRecord();
            InsertTutorPositionsHeldRecord();
            InsertLessonRecord();
            InsertLocationRecord();
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

            var person2 = new Person
            {
                FirstName = "John",
                LastName = "Doe",
                StreetAddress = "25 Mystery Street",
                Suburb = "Enigma",
                Postcode = 9012,
                EnsembleEnsembleId = ensembleID
            };

                db.Person.Add(person);
                db.Person.Add(person2);
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

        private static void InsertTutorPositionsHeldRecord()
        {
            using (var db = new MusicClassesContext())
            {
                int tutorId = (from t in db.Tutor
                               where t.PersonPersonId ==
                               (from p in db.Person
                                where p.FirstName == "John" && p.LastName == "Doe"
                                select p.PersonId).First()
                               select t.TutorId).First();

                int positionId = (from p in db.PositionsHeld
                                 where p.PositionName == "Violin Tutor"
                                 select p.PositionId).First();

                var tutorPositionsHeld = new TutorPositionsHeld()
                {
                    PositionsHeldPositionId = positionId, 
                    TutorTutorId = tutorId
                };

                db.TutorPositionsHeld.Add(tutorPositionsHeld);
                db.SaveChanges();
                db.Database.Connection.Close();
            }
        }

        private static void InsertTutorRecord()
        {
            using (var db = new MusicClassesContext())
            {
                int personID = (from p in db.Person
                                where p.FirstName == "John" && p.LastName == "Doe"
                                select p.PersonId).First();

                var tutor = new Tutor()
                {
                    PersonPersonId = personID,
                    Person = (from p in db.Person
                                where p.PersonId == personID
                                select p).First()
                };

                db.Tutor.Add(tutor);
                db.SaveChanges();
                db.Database.Connection.Close();

            }
        }
        private static void InsertLessonRecord()
        {
            using (var db = new MusicClassesContext())
            {
                string lessonName = "Percussion with John Doe";
                string location = "Symfony Orchestra Hall";
                string subject = "Percussion";
                decimal studentFee = 50.00m;
                decimal openFee = 280.00m;
                short maxStudents = 25;

                int tutorID = (from t in db.Tutor
                               where t.PersonPersonId == ((from p in db.Person
                                                           where p.FirstName == "John" && p.LastName == "Doe"
                                                           select p.PersonId)).FirstOrDefault()
                               select t.TutorId).FirstOrDefault();

                int personID = (from p in db.Person
                                where p.FirstName == "John" && p.LastName == "Doe"
                                select p.PersonId).FirstOrDefault();

                var tutor = (from t in db.Tutor
                             where t.TutorId == tutorID
                             select t).FirstOrDefault();

                var lesson = new Lesson()
                {
                    LessonName = lessonName,
                    Location = location,
                    Subject = subject,
                    StudentFee = studentFee,
                    OpenFee = openFee,
                    MaxStudents = maxStudents,
                    TutorTutorId = tutorID, 
                    Tutor = tutor
                };

                db.Lesson.Add(lesson);
                db.SaveChanges();
                db.Database.Connection.Close();
            }
        }

        private static void InsertLocationRecord()
        {
            using (var db = new MusicClassesContext())
            {
                string locationName = "Symfony Orchestra Hall";

                var location = new Location()
                {
                    LocationName = locationName
                };

                db.Location.Add(location);
                db.SaveChanges();
                db.Database.Connection.Close();
            }
        }

        private static void InsertConditionRecord()
        {
            using (var db = new MusicClassesContext())
            {
                string conditionName = "Good";
                string conditionDescription = "Instrument is ok for use";

                var condition = new Condition()
                {
                    ConditionName = conditionName,
                    ConditionDescription = conditionDescription
                };
                db.Condition.Add(condition);
                db.SaveChanges();
                db.Database.Connection.Close();
            }
        }

        private static void InsertRepairStatusRecord()
        {
            using (var db = new MusicClassesContext())
            {
                string statusName = "Repaired";
                string statusDescription = "Instrument has been repaired and is good for use";

                var repairStatus = new RepairStatus()
                {
                    StatusName = statusName,
                    StatusDescription = statusDescription
                };

                db.RepairStatus.Add(repairStatus);
                db.SaveChanges();
                db.Database.Connection.Close();
            }
        }

        private static void InsertInstrumentRecord()
        {
            using (var db = new MusicClassesContext())
            {
                string instrumentName = "Violin";
                decimal hireFee = 40.00m;
                int repairStatusId = (from r in db.RepairStatus
                                      where r.StatusName == "Repaired"
                                      select r.RepairStatusId).First();

                int conditionID = (from c in db.Condition
                                 where c.ConditionName == "Good"
                                 select c.ConditionId).First();

                var instrument = new Instrument()
                {
                    InstrumentName = instrumentName, 
                    HireFee = hireFee,
                    RepairStatusId = repairStatusId,
                    InstrumentCondition = (from c in db.Condition
                                          where c.ConditionId == conditionID 
                                          select c).First(), 
                    RepairStatus = (from r in db.RepairStatus 
                                   where r.RepairStatusId == repairStatusId 
                                   select r).First()
                };

                db.Instrument.Add(instrument);
                db.SaveChanges();
                db.Database.Connection.Close();
            }
        }

        private static void InsertPositionsHeldRecord()
        {
            using (var db = new MusicClassesContext())
            {
                string positionName = "Violin Tutor";

                var positionHeld = new PositionsHeld()
                {
                    PositionName = positionName
                };

                db.PositionsHeld.Add(positionHeld);
                db.SaveChanges();
                db.Database.Connection.Close();
            }
        }
    }
}
