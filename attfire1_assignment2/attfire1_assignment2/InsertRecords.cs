using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attfire1_assignment2
{
    public class InsertRecords
    {
        public void InsertEnsembleRecord()
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
                    Person = persons.ToList()
                };

                db.Ensemble.Add(ensemble);
                db.SaveChanges();
                db.Database.Connection.Close();
            }
        }

        public void InsertAddressRecord()
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

        public void InsertPersonRecord()
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

                var person = new Person
                {
                    FirstName = "Bob",
                    LastName = "Brown",
                    EmailAddress = "bob_brown@gmail.com",
                    MobileNumber = "0271234567",
                    AddressAddressId = addressId,
                    EnsembleEnsembleId = ensembleID
                };

                //parent (father) of Bob Brown
                var person2 = new Person
                {
                    FirstName = "Bob",
                    LastName = "Brown Sr",
                    EmailAddress = "bob_brown_sr@gmail.com",
                    MobileNumber = "0271234578",
                    AddressAddressId = addressId,
                    EnsembleEnsembleId = ensembleID
                };

                //parent (mother) of Bob Brown
                var person3 = new Person
                {
                    FirstName = "Christina",
                    LastName = "Brown",
                    EmailAddress = "christina_brown@gmail.com",
                    MobileNumber = "0271029384",
                    AddressAddressId = addressId,
                    EnsembleEnsembleId = ensembleID
                };

                var person4 = new Person
                {
                    FirstName = "John",
                    LastName = "Doe",
                    EmailAddress = "johndoe@gmail.com",
                    MobileNumber = "0275647382",
                    AddressAddressId = addressId2,
                    EnsembleEnsembleId = ensembleID
                };

                db.Person.Add(person);
                db.Person.Add(person2);
                db.Person.Add(person3);
                db.Person.Add(person4);
                db.SaveChanges();
                db.Database.Connection.Close();
            }
        }

        public void InsertSheetMusicRecord()
        {
            using (var db = new MusicClassesContext())
            {
                var sheetMusic = new SheetMusic()
                {
                    Title = "Bohemian Rhapsody",
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

        public void InsertStudentRecord()
        {
            using (var db = new MusicClassesContext())
            {
                short age = 12;
                decimal lessonFeesOwed = 50.00m;
                decimal instrumentFeesOwed = 50.00m;
                int instrumentId = (from i in db.Instrument
                                    where i.InstrumentName == "Violin"
                                    select i.InstrumentId).First();
                int personId = (from p in db.Person
                               where p.FirstName == "Bob" && p.LastName == "Brown" 
                               select p.PersonId).First();

                var student = new Student()
                {
                    Age = age,
                    LessonFeesOwed = lessonFeesOwed,
                    InstrumentFeesOwed = instrumentFeesOwed,
                    InstrumentInstrumentId = instrumentId,
                    PersonPersonId = personId,
                    Instrument = (from i in db.Instrument
                                  where i.InstrumentId == instrumentId
                                  select i).First(),
                    Person = (from p in db.Person
                              where p.PersonId == personId
                              select p).First()
                };

                db.Student.Add(student);
                db.SaveChanges();
                db.Database.Connection.Close();
            }
        }

        public void InsertStudentSheetMusicRecord()
        {
            using (var db = new MusicClassesContext())
            {
                int studentID = (from p in db.Person
                                 join s in db.Student
                                 on p.PersonId equals s.PersonPersonId
                                 select s.StudentId).First();

                int sheetMusicID = (from sm in db.SheetMusic
                                    where sm.Title == "Bohemian Rhapsody"
                                    select sm.SheetMusicId).First();

                var studentSheetMusic = new StudentSheetMusic()
                {
                    StudentStudentId = studentID,
                    SheetMusicSheetMusicId = sheetMusicID
                };

                db.StudentSheetMusic.Add(studentSheetMusic);
                db.SaveChanges();
                db.Database.Connection.Close();
            }
        }

        public void InsertTutorPositionsHeldRecord()
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

        public void InsertTutorRecord()
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
        public void InsertLessonRecord()
        {
            using (var db = new MusicClassesContext())
            {
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

                var violinLesson = new Lesson()
                {
                    LessonName = "Percussion",
                    Location = "Symfony Orchestra Hall",
                    Subject = "Percussion",
                    Instrument = (from i in db.Instrument 
                                 where i.InstrumentName == "Percussion" 
                                 select i.InstrumentName).First(),
                    StudentFee = 50.00m,
                    OpenFee = 280.00m,
                    LessonDate = new DateTime (2013, 10, 19),
                    StartTime = new DateTime(2013, 10, 19, 08, 30, 0, DateTimeKind.Local),
                    FinishTime = new DateTime(2013, 10, 19, 09, 0, 0, DateTimeKind.Local),
                    TutorTutorId = tutorID,
                    Tutor = tutor
                };

                var recorderLesson = new Lesson()
                {
                    LessonName = "Recorder",
                    Location = "Symfony Orchestra Hall",
                    Subject = "Recorder",
                    Instrument = (from i in db.Instrument
                                  where i.InstrumentName == "Recorder"
                                  select i.InstrumentName).First(),
                    StudentFee = 40.00m,
                    OpenFee = 0.00m,
                    LessonDate = new DateTime(2013, 10, 19),
                    StartTime = new DateTime(2013, 10, 19, 08, 30, 0, DateTimeKind.Local),
                    FinishTime = new DateTime(2013, 10, 19, 09, 0, 0, DateTimeKind.Local),
                    TutorTutorId = tutorID,
                    Tutor = tutor
                };

                var violaLesson = new Lesson()
                {
                    LessonName = "Viola",
                    Location = "Symfony Orchestra Hall",
                    Subject = "Viola",
                    Instrument = (from i in db.Instrument
                                  where i.InstrumentName == "Viola"
                                  select i.InstrumentName).First(),
                    StudentFee = 50.00m,
                    OpenFee = 210.00m,
                    LessonDate = new DateTime(2013, 10, 19),
                    StartTime = new DateTime(2013, 10, 19, 08, 30, 0, DateTimeKind.Local),
                    FinishTime = new DateTime(2013, 10, 19, 09, 0, 0, DateTimeKind.Local),
                    TutorTutorId = tutorID,
                    Tutor = tutor
                };

                var celloLesson = new Lesson()
                {
                    LessonName = "Cello",
                    Location = "Symfony Orchestra Hall",
                    Subject = "Cello",
                    Instrument = (from i in db.Instrument
                                  where i.InstrumentName == "Cello"
                                  select i.InstrumentName).First(),
                    StudentFee = 50.00m,
                    OpenFee = 240.00m,
                    LessonDate = new DateTime(2013, 10, 19),
                    StartTime = new DateTime(2013, 10, 19, 08, 30, 0, DateTimeKind.Local),
                    FinishTime = new DateTime(2013, 10, 19, 09, 0, 0, DateTimeKind.Local),
                    TutorTutorId = tutorID,
                    Tutor = tutor
                };

                var doubleBassLesson = new Lesson()
                {
                    LessonName = "Double Bass",
                    Location = "Symfony Orchestra Hall",
                    Subject = "Double Bass",
                    Instrument = (from i in db.Instrument
                                  where i.InstrumentName == "Double Bass"
                                  select i.InstrumentName).First(),
                    StudentFee = 50.00m,
                    OpenFee = 240.00m,
                    LessonDate = new DateTime(2013, 10, 19),
                    StartTime = new DateTime(2013, 10, 19, 08, 30, 0, DateTimeKind.Local),
                    FinishTime = new DateTime(2013, 10, 19, 09, 0, 0, DateTimeKind.Local),
                    TutorTutorId = tutorID,
                    Tutor = tutor
                };

                var fluteLesson = new Lesson()
                {
                    LessonName = "Flute",
                    Location = "Symfony Orchestra Hall",
                    Subject = "Flute",
                    Instrument = (from i in db.Instrument
                                  where i.InstrumentName == "Flute"
                                  select i.InstrumentName).First(),
                    StudentFee = 50.00m,
                    OpenFee = 240.00m,
                    LessonDate = new DateTime(2013, 10, 19),
                    StartTime = new DateTime(2013, 10, 19, 08, 30, 0, DateTimeKind.Local),
                    FinishTime = new DateTime(2013, 10, 19, 09, 0, 0, DateTimeKind.Local),
                    TutorTutorId = tutorID,
                    Tutor = tutor
                };

                var clarinetLesson = new Lesson()
                {
                    LessonName = "Clarinet",
                    Location = "Symfony Orchestra Hall",
                    Subject = "Clarinet",
                    Instrument = (from i in db.Instrument
                                  where i.InstrumentName == "Clarinet"
                                  select i.InstrumentName).First(),
                    StudentFee = 50.00m,
                    OpenFee = 210.00m,
                    LessonDate = new DateTime(2013, 10, 19),
                    StartTime = new DateTime(2013, 10, 19, 08, 30, 0, DateTimeKind.Local),
                    FinishTime = new DateTime(2013, 10, 19, 09, 0, 0, DateTimeKind.Local),
                    TutorTutorId = tutorID,
                    Tutor = tutor
                };

                var oboeLesson = new Lesson()
                {
                    LessonName = "Oboe",
                    Location = "Symfony Orchestra Hall",
                    Subject = "Oboe",
                    Instrument = (from i in db.Instrument
                                  where i.InstrumentName == "Oboe"
                                  select i.InstrumentName).First(),
                    StudentFee = 50.00m,
                    OpenFee = 300.00m,
                    LessonDate = new DateTime(2013, 10, 19),
                    StartTime = new DateTime(2013, 10, 19, 08, 30, 0, DateTimeKind.Local),
                    FinishTime = new DateTime(2013, 10, 19, 09, 0, 0, DateTimeKind.Local),
                    TutorTutorId = tutorID,
                    Tutor = tutor
                };

                var bassoonLesson = new Lesson()
                {
                    LessonName = "Bassoon",
                    Location = "Symfony Orchestra Hall",
                    Subject = "Bassoon",
                    Instrument = (from i in db.Instrument
                                  where i.InstrumentName == "Bassoon"
                                  select i.InstrumentName).First(),
                    StudentFee = 50.00m,
                    OpenFee = 300.00m,
                    LessonDate = new DateTime(2013, 10, 19),
                    StartTime = new DateTime(2013, 10, 19, 08, 30, 0, DateTimeKind.Local),
                    FinishTime = new DateTime(2013, 10, 19, 09, 0, 0, DateTimeKind.Local),
                    TutorTutorId = tutorID,
                    Tutor = tutor
                };

                var otherWoodwindLesson = new Lesson()
                {
                    LessonName = "Other Woodwind",
                    Location = "Symfony Orchestra Hall",
                    Subject = "Other Woodwind",
                    Instrument = (from i in db.Instrument
                                  where i.InstrumentName == "Other Woodwind"
                                  select i.InstrumentName).First(),
                    StudentFee = 50.00m,
                    OpenFee = 300.00m,
                    LessonDate = new DateTime(2013, 10, 19),
                    StartTime = new DateTime(2013, 10, 19, 08, 30, 0, DateTimeKind.Local),
                    FinishTime = new DateTime(2013, 10, 19, 09, 0, 0, DateTimeKind.Local),
                    TutorTutorId = tutorID,
                    Tutor = tutor
                };

                var trumpetLesson = new Lesson()
                {
                    LessonName = "Trumpet",
                    Location = "Symfony Orchestra Hall",
                    Subject = "Trumpet",
                    Instrument = (from i in db.Instrument
                                  where i.InstrumentName == "Trumpet"
                                  select i.InstrumentName).First(),
                    StudentFee = 50.00m,
                    OpenFee = 210.00m,
                    LessonDate = new DateTime(2013, 10, 19),
                    StartTime = new DateTime(2013, 10, 19, 08, 30, 0, DateTimeKind.Local),
                    FinishTime = new DateTime(2013, 10, 19, 09, 0, 0, DateTimeKind.Local),
                    TutorTutorId = tutorID,
                    Tutor = tutor
                };

                var tromboneLesson = new Lesson()
                {
                    LessonName = "Trombone",
                    Location = "Symfony Orchestra Hall",
                    Subject = "Trombone",
                    Instrument = (from i in db.Instrument
                                  where i.InstrumentName == "Trombone"
                                  select i.InstrumentName).First(),
                    StudentFee = 50.00m,
                    OpenFee = 240.00m,
                    LessonDate = new DateTime(2013, 10, 19),
                    StartTime = new DateTime(2013, 10, 19, 08, 30, 0, DateTimeKind.Local),
                    FinishTime = new DateTime(2013, 10, 19, 09, 0, 0, DateTimeKind.Local),
                    TutorTutorId = tutorID,
                    Tutor = tutor
                };

                var frenchHornLesson = new Lesson()
                {
                    LessonName = "French Horn",
                    Location = "Symfony Orchestra Hall",
                    Subject = "Trombone",
                    Instrument = (from i in db.Instrument
                                  where i.InstrumentName == "French Horn"
                                  select i.InstrumentName).First(),
                    StudentFee = 50.00m,
                    OpenFee = 240.00m,
                    LessonDate = new DateTime(2013, 10, 19),
                    StartTime = new DateTime(2013, 10, 19, 08, 30, 0, DateTimeKind.Local),
                    FinishTime = new DateTime(2013, 10, 19, 09, 0, 0, DateTimeKind.Local),
                    TutorTutorId = tutorID,
                    Tutor = tutor
                };

                var tubaLesson = new Lesson()
                {
                    LessonName = "Tuba",
                    Location = "Symfony Orchestra Hall",
                    Subject = "Tuba",
                    Instrument = (from i in db.Instrument
                                  where i.InstrumentName == "Tuba"
                                  select i.InstrumentName).First(),
                    StudentFee = 50.00m,
                    OpenFee = 280.00m,
                    LessonDate = new DateTime(2013, 10, 19),
                    StartTime = new DateTime(2013, 10, 19, 08, 30, 0, DateTimeKind.Local),
                    FinishTime = new DateTime(2013, 10, 19, 09, 0, 0, DateTimeKind.Local),
                    TutorTutorId = tutorID,
                    Tutor = tutor
                };

                var otherBrassLesson = new Lesson()
                {
                    LessonName = "Other Brass",
                    Location = "Symfony Orchestra Hall",
                    Subject = "Other Brass",
                    Instrument = (from i in db.Instrument
                                  where i.InstrumentName == "Other Brass"
                                  select i.InstrumentName).First(),
                    StudentFee = 50.00m,
                    OpenFee = 240.00m,
                    LessonDate = new DateTime(2013, 10, 19),
                    StartTime = new DateTime(2013, 10, 19, 08, 30, 0, DateTimeKind.Local),
                    FinishTime = new DateTime(2013, 10, 19, 09, 0, 0, DateTimeKind.Local),
                    TutorTutorId = tutorID,
                    Tutor = tutor
                };

                var vocalTechniqueLesson = new Lesson()
                {
                    LessonName = "Vocal Technique",
                    Location = "Symfony Orchestra Hall",
                    Subject = "Vocal Technique",
                    Instrument = (from i in db.Instrument
                                  where i.InstrumentName == "Vocal Technique"
                                  select i.InstrumentName).First(),
                    StudentFee = 80.00m,
                    OpenFee = 300.00m,
                    LessonDate = new DateTime(2013, 10, 19),
                    StartTime = new DateTime(2013, 10, 19, 08, 30, 0, DateTimeKind.Local),
                    FinishTime = new DateTime(2013, 10, 19, 09, 0, 0, DateTimeKind.Local),
                    TutorTutorId = tutorID,
                    Tutor = tutor
                };

                var musicTheoryLesson = new Lesson()
                {
                    LessonName = "Music Theory",
                    Location = "Symfony Orchestra Hall",
                    Subject = "Music Theory",
                    Instrument = null,
                    StudentFee = 80.00m,
                    OpenFee = 300.00m,
                    LessonDate = new DateTime(2013, 10, 19),
                    StartTime = new DateTime(2013, 10, 19, 08, 30, 0, DateTimeKind.Local),
                    FinishTime = new DateTime(2013, 10, 19, 09, 0, 0, DateTimeKind.Local),
                    TutorTutorId = tutorID,
                    Tutor = tutor
                };

                db.Lesson.Add(violinLesson);
                db.Lesson.Add(recorderLesson);
                db.Lesson.Add(violaLesson);
                db.Lesson.Add(celloLesson);
                db.Lesson.Add(doubleBassLesson);
                db.Lesson.Add(fluteLesson);
                db.Lesson.Add(oboeLesson);
                db.Lesson.Add(bassoonLesson);
                db.Lesson.Add(otherWoodwindLesson);
                db.Lesson.Add(trumpetLesson);
                db.Lesson.Add(tromboneLesson);
                db.Lesson.Add(frenchHornLesson);
                db.Lesson.Add(tubaLesson);
                db.Lesson.Add(otherBrassLesson);
                db.Lesson.Add(vocalTechniqueLesson);
                db.Lesson.Add(musicTheoryLesson);
                db.SaveChanges();
                db.Database.Connection.Close();
            }
        }

        public void InsertLocationRecord()
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

        public void InsertInstrumentRecord()
        {
            using (var db = new MusicClassesContext())
            {
                var violin = new Instrument()
                {
                    InstrumentName = "Violin",
                    HireFee = 40.00m,
                    ConditionStatus = "Ok to use", 
                    RepairStatus = "No need for repair"
                };
                db.Instrument.Add(violin);

                var recorder = new Instrument()
                {
                    InstrumentName = "Recorder", 
                    HireFee = 0.00m, 
                    ConditionStatus = "Ok for use",
                    RepairStatus = "No need for repair"
                };
                db.Instrument.Add(recorder);

                var viola = new Instrument()
                {
                    InstrumentName = "Viola",
                    HireFee = 40.00m,
                    ConditionStatus = "Ok for use",
                    RepairStatus = "No need for repair"
                };
                db.Instrument.Add(viola);

                var cello = new Instrument()
                {
                    InstrumentName = "Cello",
                    HireFee = 80.00m,
                    ConditionStatus = "Ok for use",
                    RepairStatus = "No need for repair"
                };
                db.Instrument.Add(cello);

                var doubleBass = new Instrument()
                {
                    InstrumentName = "Double Bass",
                    HireFee = 80.00m,
                    ConditionStatus = "Ok for use",
                    RepairStatus = "No need for repair"
                };
                db.Instrument.Add(doubleBass);

                var flute = new Instrument()
                {
                    InstrumentName = "Flute",
                    HireFee = 40.00m,
                    ConditionStatus = "Ok for use",
                    RepairStatus = "No need for repair"
                };
                db.Instrument.Add(flute);

                var clarinet = new Instrument()
                {
                    InstrumentName = "Clarinet",
                    HireFee = 40.00m,
                    ConditionStatus = "Ok for use",
                    RepairStatus = "No need for repair"
                };
                db.Instrument.Add(clarinet);

                var oboe = new Instrument()
                {
                    InstrumentName = "Oboe",
                    HireFee = 80.00m,
                    ConditionStatus = "Ok for use",
                    RepairStatus = "No need for repair"
                };
                db.Instrument.Add(oboe);

                var bassoon = new Instrument()
                {
                    InstrumentName = "Bassoon",
                    HireFee = 80.00m,
                    ConditionStatus = "Ok for use",
                    RepairStatus = "No need for repair"
                };
                db.Instrument.Add(bassoon);

                var otherWoodwind = new Instrument()
                {
                    InstrumentName = "Other Woodwind",
                    HireFee = 80.00m,
                    ConditionStatus = "Ok for use",
                    RepairStatus = "No need for repair"
                };
                db.Instrument.Add(otherWoodwind);

                var trumpet = new Instrument()
                {
                    InstrumentName = "Trumpet",
                    HireFee = 40.00m,
                    ConditionStatus = "Ok for use",
                    RepairStatus = "No need for repair"
                };
                db.Instrument.Add(trumpet);

                var trombone = new Instrument()
                {
                    InstrumentName = "Trombone",
                    HireFee = 40.00m,
                    ConditionStatus = "Ok for use",
                    RepairStatus = "No need for repair"
                };
                db.Instrument.Add(trombone);

                var frenchHorn = new Instrument()
                {
                    InstrumentName = "French Horn",
                    HireFee = 80.00m,
                    ConditionStatus = "Ok for use",
                    RepairStatus = "No need for repair"
                };
                db.Instrument.Add(frenchHorn);

                var tuba = new Instrument()
                {
                    InstrumentName = "Tuba",
                    HireFee = 80.00m,
                    ConditionStatus = "Ok for use",
                    RepairStatus = "No need for repair"
                };
                db.Instrument.Add(tuba);

                var otherBrass = new Instrument()
                {
                    InstrumentName = "Other Brass",
                    HireFee = 80.00m,
                    ConditionStatus = "Ok for use",
                    RepairStatus = "No need for repair"
                };
                db.Instrument.Add(otherBrass);

                var percussion = new Instrument()
                {
                    InstrumentName = "Percussion",
                    HireFee = 0.00m,
                    ConditionStatus = "N/A",
                    RepairStatus = "N/A"
                };
                db.Instrument.Add(percussion);

                var vocalTechnique = new Instrument()
                {
                    InstrumentName = "Vocal Technique",
                    HireFee = 0.00m,
                    ConditionStatus = "N/A",
                    RepairStatus = "N/A"
                };
                db.Instrument.Add(vocalTechnique);

                var musicTheory = new Instrument()
                {
                    InstrumentName = "Music Theory",
                    HireFee = 0.00m,
                    ConditionStatus = "N/A",
                    RepairStatus = "N/A"
                };
                db.Instrument.Add(vocalTechnique);



                db.SaveChanges();
                db.Database.Connection.Close();
            }
        }

        public void InsertPositionsHeldRecord()
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

        public void InsertPerformanceRecord()
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

        public void InsertPerformanceSheetMusicRecord()
        {
            using (var db = new MusicClassesContext())
            {
                int performanceId = (from p in db.Performance
                                     where p.PerformanceName == "Orchestra of Wonder - One Night Only"
                                     select p.PerformanceId).First();
                int sheetMusicId = (from s in db.SheetMusic
                                    where s.Title == "Bohemian Rhapsody"
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
