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
            InsertAddressRecord();
            InsertPersonRecord();
            InsertSheetMusicRecord();
            InsertPersonSheetMusicRecord();
            InsertPositionsHeldRecord();
            InsertTutorRecord();
            InsertTutorPositionsHeldRecord();
            InsertLessonRecord();
            InsertLocationRecord();
            InsertPerformanceRecord();
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

        private static void InsertAddressRecord()
        {
            using (var db = new MusicClassesContext())
            {
                
                string streetAddress = "101 Tramway Road";
                string suburb = "Chesapeake Bay";
                string townOrCity = "Dunedin";
                int postcode = 9012;
                string landlinePhone = "034567890";

                var address = new Address()
                {
                    StreetAddress = streetAddress, 
                    Suburb = suburb, 
                    TownOrCity = townOrCity, 
                    PostCode = postcode, 
                    LandlinePhone = landlinePhone
                };

                string streetAddress2 = "25 Mystery Street";
                string suburb2 = "Enigma";
                string townOrCity2 = "Dunedin";
                int postcode2 = 9012;
                string landlinePhone2 = "034789012";

                var address2 = new Address()
                {
                    StreetAddress = streetAddress2,
                    Suburb = suburb2,
                    TownOrCity = townOrCity2,
                    PostCode = postcode2,
                    LandlinePhone = landlinePhone2
                };

                db.Address.Add(address);
                db.Address.Add(address2);
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

                var addressId = (from a in db.Address
                                where a.StreetAddress == "101 Tramway Road"
                                && a.Suburb == "Chesapeake Bay"
                                && a.TownOrCity == "Dunedin"
                                && a.PostCode == 9012
                                && a.LandlinePhone == "034567890"
                                select a.AddressId).First();

                var addressId2 = (from a in db.Address
                                  where a.StreetAddress == "25 Mystery Street"
                                 && a.Suburb == "Enigma"
                                 && a.TownOrCity == "Dunedin"
                                 && a.PostCode == 9012
                                 && a.LandlinePhone == "034789012"
                                 select a.AddressId).First();

                var person = new Person {
                    FirstName = "Bob", 
                    LastName = "Brown", 
                    AddressAddressId = addressId,
                    EnsembleEnsembleId = ensembleID
                };

                var person2 = new Person
                {
                    FirstName = "John",
                    LastName = "Doe",
                    AddressAddressId = addressId2,
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
                                select p.PersonId).FirstOrDefault()
                               select t.TutorId).FirstOrDefault();

                int positionId = (from p in db.PositionsHeld
                                 where p.PositionName == "Violin Tutor"
                                 select p.PositionId).First();

                var tutorPositionsHeld = new TutorPositionsHeld()
                {
                    PositionsHeldPositionId = positionId, 
                    TutorTutorId = tutorId,

                    PositionsHeld = (from p in db.PositionsHeld
                                    where p.PositionId == positionId 
                                    select p).First(), 

                    Tutor = (from t in db.Tutor
                            where t.TutorId == tutorId 
                            select t).First()
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

        private static void InsertPerformanceRecord()
        {
            using (var db = new MusicClassesContext())
            {
                string performanceName = "Orchestra of Wonder - One Night Only";
                DateTime performanceDate = new DateTime(2013, 11, 23);
                TimeSpan startTime = new DateTime(2013, 11, 23, 18, 0, 0).TimeOfDay;
                TimeSpan finishTime = new DateTime(2013, 11, 23, 19, 30, 0).TimeOfDay;

                int locationId = (from l in db.Location
                                  where l.LocationName == "Symfony Orchestra Hall"
                                  select l.LocationId).First();

                var performance = new Performance() 
                {
                    PerformanceName = performanceName, 
                    PerformanceDate = performanceDate, 
                    StartTime = startTime, 
                    FinishTime = finishTime, 
                    LocationLocationId = locationId, 

                    Location = (from l in db.Location 
                               where l.LocationId == locationId 
                               select l).First()
                };

                db.Performance.Add(performance);
                db.SaveChanges();
                db.Database.Connection.Close();
            }

        }

        private static void InsertPerformanceSheetMusicRecord()
        {
            using (var db = new MusicClassesContext())
            {
                int performanceId = (from p in db.Performance
                                    where p.PerformanceName == "Orchestra of Wonder - One Night Only"
                                    select p.PerformanceId).First();
                int sheetMusicId = (from s in db.SheetMusic
                                    where s.Title == "Bohemian Rhapsody - Orchestra Version"
                                    select s.SheetMusicId).First();

                var performanceSheetMusic = new PerformanceSheetMusic()
                {
                    PerformancePerformanceId = performanceId, 
                    SheetMusicSheetMusicId = sheetMusicId
                };

                db.PerformanceSheetMusic.Add(performanceSheetMusic);
                db.SaveChanges();
                db.Database.Connection.Close();
            }
        }
    }
}
