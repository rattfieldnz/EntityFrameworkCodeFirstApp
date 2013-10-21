using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace attfire1_assignment2
{
    public partial class Form1 : Form
    {

        StringBuilder formErrors = new StringBuilder();
        Utilities formUtilities = new Utilities();

        public Form1()
        {
            InitializeComponent();

            using (var db = new MusicClassesContext())
            {
                //inserting tutor names in tutor dropdown box in Lesson Records tab
                var tutors = (from p in db.Person
                              join t in db.Tutor
                              on p.PersonId equals t.PersonPersonId
                              select (p.FirstName + " " + p.LastName));

                foreach (string tutor in tutors)
                {
                    lessonTutorDropdown.Items.Add(tutor);
                }

                //inserting lessons in lesson dropdown box in Student and Tutor Records tab
                var lessons = from l in db.Lesson
                              select l.LessonName;

                foreach (string l in lessons)
                {
                    lessonDropdownBox.Items.Add(l);
                    lessonsToTeachListbox.Items.Add(l);
                }

                //inserting instruments in instrument dropdown box in Student Records tab
                var instruments = from i in db.Instrument
                                  select i.InstrumentName;

                foreach (string i in instruments)
                {
                    instrumentDropdownBox.Items.Add(i);
                    lessonInstrumentDropdown.Items.Add(i);
                }

                //inserting ensembles in ensembles dropdown box in Student and Tutor Records tab
                var ensembles = from e in db.Ensemble
                                select e.EnsembleName;

                foreach (string e in ensembles)
                {
                    ensembleDropdownBox.Items.Add(e);
                    tutorEnsemblesListBox.Items.Add(e);
                }

                //inserting sheetmusic items in sheetmusic listbox in Tutor and Student Records tab
                var sheetMusicItems = from sm in db.SheetMusic
                                      select sm.Title;
                foreach (string sm in sheetMusicItems)
                {
                    tutorSheetMusicListbox.Items.Add(sm);
                    sheetMusicListBox.Items.Add(sm);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //A method to validate the Age input field - in the Student Records pane.
        //Thanks to the following link for helping me - http://www.dotnetperls.com/textchanged
        //private void ageField_TextChanged(object sender, EventArgs e)
        //{
        //    //Creating String variable of Age field input
        //    string ageFieldInput = ageField.Text;

        //    //Checking if input for age is a number...
        //    if (Regex.IsMatch(ageFieldInput, @"^\d+$") == false)
        //    {
        //        //... if not, show user appripriate message in dialogue box
        //        MessageBox.Show("The age field must be an integer, e.g. 23, 5, 11, 32");
        //    }
        //    //Check if parsed integer input is less than 5, and display appropriate
        //    //message in dialogue box
        //    else if (int.Parse(ageFieldInput) < 5)
        //    {
        //        MessageBox.Show("The student must be 5 years old, or older, to enrol in lessons.");
        //    }

        //}

        //A method to validate the Postcode input field - in the Student Records pane.
        //private void postCodeField_TextChanged(object sender, EventArgs e)
        //{
        //    //Creating String variable of Postcode field input
        //    string postCodeFieldInput = postCodeField.Text;

        //    //Checking if input for Postcode is a number...
        //    if (Regex.IsMatch(postCodeFieldInput, @"^\d+$") == false)
        //    {
        //        //... if not, show user appripriate message in dialogue box
        //        MessageBox.Show("The Postcode field must be an integer, e.g. 9012, 9510, 9077, 9092");
        //    }
        //}


        /**
            * <summary>
            * This click handler is responsible for adding and updating Student records
            * - and also creating records for associated entities
            * </summary>
            */
        private void submitUpdateBtn_Click(object sender, EventArgs e)
        {
            formUtilities.checkFieldNullLengths(firstNameField, formErrors, "First Name");
            formUtilities.checkFieldNullLengths(lastNameField, formErrors, "Last Name");
            formUtilities.ageFieldCheck(ageField, formErrors);
            formUtilities.checkFieldNullLengths(streetAddressField, formErrors, "Street Address");
            formUtilities.checkFieldNullLengths(suburbField, formErrors, "Suburb");
            formUtilities.postCodeFieldCheck(postCodeField, formErrors);
            formUtilities.checkFieldNullLengths(studentTownOrCityField, formErrors, "Town or City");
            formUtilities.landlineNumberValidation(landlinePhoneField, formErrors);
            formUtilities.mobileNumberValidation(mobilePhoneField, formErrors);
            formUtilities.validateEmailField(emailAddressField, formErrors);
            formUtilities.checkDropdownBox(lessonDropdownBox, formErrors, "Lesson");
            formUtilities.checkDropdownBox(instrumentDropdownBox, formErrors, "Instrument");
            formUtilities.checkListBox(sheetMusicListBox, formErrors, "Sheet Music");
            formUtilities.checkDropdownBox(ensembleDropdownBox, formErrors, "Ensemble");
            formUtilities.lessonFeesFieldCheck(lessonFeesOwedField, formErrors);
            formUtilities.instrumentFeesFieldCheck(instrumentFeesOwedField, formErrors);
            formUtilities.totalFeesFieldCheck(totalFeesOwedField, formErrors);

            if (formErrors.ToString().Length != 0)
            {
                MessageBox.Show(formErrors.ToString());

                //Setting the error message string back to zero length, 
                //so continuous submit attempts don't keep appending 
                //subsequent error messages.
                formErrors = new StringBuilder();
            }
            else
            {
                using (var db = new MusicClassesContext())
                {
                    //Creating new Address object - using the appropriate form inputs
                    //from the Student Records pane.
                    var address = new Address()
                    {
                        StreetAddress = streetAddressField.Text.ToString(),
                        Suburb = suburbField.Text.ToString(),
                        TownOrCity = studentTownOrCityField.Text.ToString(),
                        PostCode = int.Parse(postCodeField.Text.ToString()),
                        LandlinePhone = landlinePhoneField.Text.ToString()
                    };

                    //Add the new Address object to the database
                    db.Address.Add(address);
                    //Save the changes that have just been made - after the 
                    //new Address object has been created and added
                    db.SaveChanges();
                    //Close the current conenction to the database, so 
                    //other functions and record additions can be executed.
                    db.Database.Connection.Close();

                    //Creating new Person object - using the appropriate form inputs
                    //from the Student Records pane.
                    var person = new Person()
                    {
                        FirstName = firstNameField.Text,
                        LastName = lastNameField.Text,
                        EmailAddress = emailAddressField.Text,
                        MobileNumber = mobilePhoneField.Text,

                        //A LINQ query, which obtains the Id for the Ensemble chosen by the user - 
                        //determined by the Ensemble name selected form the Student records pane.
                        EnsembleEnsembleId = (from ensemble in db.Ensemble
                                              where ensemble.EnsembleName == ensembleDropdownBox.Text
                                              select ensemble.EnsembleId).FirstOrDefault(),

                        //A LINQ query to obtain the Id of the Address record (of the current Student
                        //being added) that was just added.
                        AddressAddressId = (from a in db.Address
                                            where a.StreetAddress == address.StreetAddress
                                            && a.Suburb == address.Suburb
                                            && a.TownOrCity == address.TownOrCity
                                            && a.PostCode == address.PostCode
                                            && a.LandlinePhone == address.LandlinePhone
                                            select a.AddressId).FirstOrDefault(),

                        //A LINQ query to obtain the Ensemble object required for reverse navigation 
                        //- using the Ensemble selected by the user.
                        Ensemble = (from en in db.Ensemble
                                    where en.EnsembleId == (from ensemble in db.Ensemble
                                                            where ensemble.EnsembleName == ensembleDropdownBox.Text
                                                            select ensemble.EnsembleId).FirstOrDefault()
                                    select en).First(),

                        //A LINQ query to create the Address object required for reverse navigation 
                        //- using the Address record created by the user earlier.
                        Address = (from ad in db.Address
                                   where ad.AddressId == (from a in db.Address
                                                          where a.StreetAddress == address.StreetAddress
                                                          && a.Suburb == address.Suburb
                                                          && a.TownOrCity == address.TownOrCity
                                                          && a.PostCode == address.PostCode
                                                          && a.LandlinePhone == address.LandlinePhone
                                                          select a.AddressId).FirstOrDefault()
                                   select ad).FirstOrDefault()
                    };

                    //Add the new Person object to the database
                    db.Person.Add(person);
                    //Save the changes that have been made - by the new record being added.
                    db.SaveChanges();
                    //Close the connection to the database, so other methods and functions can 
                    //use the connection.
                    db.Database.Connection.Close();

                    //Creating a new Student record - with the necessary Person record
                    //created earlier.
                    string instrumentName = instrumentDropdownBox.Text.ToString();
                    var student = new Student()
                    {
                        //Converting the input for Age into a short
                        Age = short.Parse(ageField.Text.ToString()),

                        //Converting the inout for Lesson Fees Owed into decimal format
                        LessonFeesOwed = Convert.ToDecimal(lessonFeesOwedField.Text.ToString()),

                        //Converting the inout for Instrument Fees Owed into decimal format
                        InstrumentFeesOwed = Convert.ToDecimal(instrumentFeesOwedField.Text.ToString()),

                        //A LINQ query to obtain the associated InstrumentId with the Instrument
                        //selected by the user from the interface.
                        InstrumentInstrumentId = (from i in db.Instrument
                                                  where i.InstrumentName == instrumentName
                                                  select i.InstrumentId).FirstOrDefault(),

                        //Associating the Person record, created for the new Student, with the current Student object 
                        //being constructed.
                        PersonPersonId = person.PersonId,
                        Instrument = (from i in db.Instrument
                                      where i.InstrumentId == (from inst in db.Instrument
                                                               where inst.InstrumentName == instrumentDropdownBox.Text
                                                               select inst.InstrumentId).FirstOrDefault()
                                      select i).FirstOrDefault(),

                        //A LINQ query to obtain the Person object required for reverse navigation 
                        //- using the Person object created for the Student earlier.
                        Person = (from p in db.Person
                                  where p.PersonId == person.PersonId
                                  select p).FirstOrDefault()
                    };

                    //Add the student to the database
                    db.Student.Add(student);
                    //Save the changes made to the database - made by the addition of the Student record.
                    db.SaveChanges();
                    //Close the current connection to the database, so other record creations and method/function/
                    //handler calls can use the connection.
                    db.Database.Connection.Close();

                    //Creating the many-many record that relates Students with Lessons - 
                    //(Yes, I only found out on 17/10/2013 I could have done this better 
                    //with the Fluent API.
                    var studentLesson = new StudentLesson()
                    {
                        //Obtaining the StudentId from the Student object created earlier.
                        StudentStudentId = student.StudentId,

                        //Obtaining the LessonId from the Lesson the user selected form the
                        //interface.
                        LessonLessonId = (from l in db.Lesson
                                          where l.LessonName == lessonDropdownBox.Text
                                          select l.LessonId).FirstOrDefault(),

                        //Obtaining the Lesson object required for reverse navigation.
                        Lesson = (from l in db.Lesson
                                  where l.LessonId == (from le in db.Lesson
                                                       where le.LessonName == lessonDropdownBox.Text
                                                       select le.LessonId).FirstOrDefault()
                                  select l).FirstOrDefault(),

                        //Obtaining the Student object required for reverse navigation.
                        Student = student
                    };

                    //Add the student record to the database.
                    db.StudentLesson.Add(studentLesson);

                    //Save the changes that have just been made to the database.
                    db.SaveChanges();

                    //Close the connection so other method/function/handler calls 
                    //can use the connection.
                    db.Database.Connection.Close();


                    string[] sheetMusicRecords = new string[sheetMusicListBox.SelectedItems.Count];
                    sheetMusicListBox.SelectedItems.CopyTo(sheetMusicRecords, 0);


                    //Creating the many-many object that links Students 
                    //with SheetMusic records.


                    foreach (string smc in sheetMusicRecords)
                    {
                        var studentSheetMusic = new StudentSheetMusic()
                        {
                            //Obtaining the StudentId from the Student object created earlier.
                            StudentStudentId = student.StudentId,

                            //Obtaining the SheetMusicId from the SheetMusic item object 
                            //selected by the user.
                            SheetMusicSheetMusicId = (from s in db.SheetMusic
                                                      where s.Title == smc
                                                      select s.SheetMusicId).FirstOrDefault(),

                            //Obtaining the Student object required for reverse navigation.
                            Student = student,

                            //Obtaining the SheetMusic object required for reverse navigation, 
                            //obtained from the SheetMusic item selected by the user,
                            SheetMusic = (from sm in db.SheetMusic
                                          where sm.SheetMusicId == (from s in db.SheetMusic
                                                                    where s.Title == smc
                                                                    select s.SheetMusicId).FirstOrDefault()
                                          select sm).FirstOrDefault()

                        };

                        //Add the StudentSheetMusic record to the database.
                        db.StudentSheetMusic.Add(studentSheetMusic);

                        //Save the changes made to the database.
                        db.SaveChanges();
                    }

                    //Close the connection
                    db.Database.Connection.Close();
                }
            }
        }

        private void tutorEnsemblesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void showStudentsBtn_Click(object sender, EventArgs e)
        {
            studentRecordsListbox.Items.Clear();
            using (var db = new MusicClassesContext())
            {
                ////////////////////////////////////////////////////////////////////
                // The query which retrieves appropriate student records, namely: //
                //                                                                //
                // - Student's first name                                         //
                // - Student's last name                                          //
                // - The student's age                                            //
                // - The student's suburb and town/city details                   //
                // - The name of the lesson the student is taking                 //
                // - The name of the instrument the student is learning           //
                // - The amount of lesson fees the student owes                   //
                // - The amount of instrument fees the student owes               //
                // - The total amount of fees the student owes                    //
                ////////////////////////////////////////////////////////////////////
                if (showStudentsByDropdown.SelectedText.Length != 0)
                {
                    var studentRecordsQuery = from p in db.Person
                                              join s in db.Student on p.PersonId equals s.PersonPersonId
                                              join sl in db.StudentLesson on s.StudentId equals sl.StudentStudentId
                                              join l in db.Lesson on sl.LessonLessonId equals l.LessonId
                                              join a in db.Address on p.AddressAddressId equals a.AddressId
                                              join i in db.Instrument on s.InstrumentInstrumentId equals i.InstrumentId
                                              orderby showStudentsByDropdown.SelectedItem
                                              select new
                                              {
                                                  s.StudentId,
                                                  p.FirstName,
                                                  p.LastName,
                                                  s.Age,
                                                  a.Suburb,
                                                  a.TownOrCity,
                                                  l.LessonName,
                                                  i.InstrumentName,
                                                  s.LessonFeesOwed,
                                                  s.InstrumentFeesOwed,
                                                  TotalFeesOwed = s.LessonFeesOwed + s.InstrumentFeesOwed
                                              };

                    List<StudentRecordsItem> students = new List<StudentRecordsItem>();

                    foreach (var s in studentRecordsQuery)
                    {
                        StudentRecordsItem student = new StudentRecordsItem(s.StudentId,
                                                            s.FirstName,
                                                            s.LastName,
                                                            s.Age,
                                                            s.Suburb,
                                                            s.TownOrCity,
                                                            s.LessonName,
                                                            s.InstrumentName,
                                                            s.LessonFeesOwed,
                                                            s.InstrumentFeesOwed,
                                                            s.TotalFeesOwed);
                        students.Add(student);
                    }

                    foreach (var s in students)
                    {
                        studentRecordsListbox.Items.Add(s);
                    }

                }
                else
                {
                    var studentRecordsQuery = from p in db.Person
                                              join s in db.Student on p.PersonId equals s.PersonPersonId
                                              join sl in db.StudentLesson on s.StudentId equals sl.StudentStudentId
                                              join l in db.Lesson on sl.LessonLessonId equals l.LessonId
                                              join a in db.Address on p.AddressAddressId equals a.AddressId
                                              join i in db.Instrument on s.InstrumentInstrumentId equals i.InstrumentId
                                              select new
                                              {
                                                  s.StudentId,
                                                  p.FirstName,
                                                  p.LastName,
                                                  s.Age,
                                                  a.Suburb,
                                                  a.TownOrCity,
                                                  l.LessonName,
                                                  i.InstrumentName,
                                                  s.LessonFeesOwed,
                                                  s.InstrumentFeesOwed,
                                                  TotalFeesOwed = s.LessonFeesOwed + s.InstrumentFeesOwed
                                              };

                    List<StudentRecordsItem> students = new List<StudentRecordsItem>();

                    foreach (var s in studentRecordsQuery)
                    {
                        StudentRecordsItem student = new StudentRecordsItem(s.StudentId,
                                                            s.FirstName,
                                                            s.LastName,
                                                            s.Age,
                                                            s.Suburb,
                                                            s.TownOrCity,
                                                            s.LessonName,
                                                            s.InstrumentName,
                                                            s.LessonFeesOwed,
                                                            s.InstrumentFeesOwed, 
                                                            s.TotalFeesOwed);
                        students.Add(student);
                    }

                    foreach (var s in students)
                    {
                        studentRecordsListbox.Items.Add(s);
                    }
                }
            }
        }
    }
}