using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attfire1_assignment2
{
    public partial class Form1 : Form
    {
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void mainTabGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sheetMusicTitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        /**
         * <summary>
         * This click handler is responsible for adding and updating Student records
         * - and also creating records for associated entities
         * </summary>
         */
        private void submitUpdateBtn_Click(object sender, EventArgs e)
        {
            try
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
                                                  where i.InstrumentName == instrumentDropdownBox.Text
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


                    //Obtaining the SheetMusicTitle - selected by the user from the 
                    //SheetMusic listbox on the Student Records pane. To be used for
                    //creating the many-many StudentSheetMusic object.
                    string sheetMusicTitle = sheetMusicListBox.SelectedItem.ToString();


                    //Creating the many-many object that links Students 
                    //with SheetMusic records.
                    var studentSheetMusic = new StudentSheetMusic()
                    {
                        //Obtaining the StudentId from the Student object created earlier.
                        StudentStudentId = student.StudentId,

                        //Obtaining the SheetMusicId from the SheetMusic item object 
                        //selected by the user.
                        SheetMusicSheetMusicId = (from s in db.SheetMusic
                                                  where s.Title == sheetMusicTitle
                                                  select s.SheetMusicId).FirstOrDefault(),

                        //Obtaining the Student object required for reverse navigation.
                        Student = student,

                        //Obtaining the SheetMusic object required for reverse navigation, 
                        //obtained from the SheetMusic item selected by the user,
                        SheetMusic = (from sm in db.SheetMusic
                                      where sm.SheetMusicId == (from s in db.SheetMusic
                                                                where s.Title == sheetMusicTitle
                                                                select s.SheetMusicId).FirstOrDefault()
                                      select sm).FirstOrDefault()

                    };

                    //Add the StudentSheetMusic record to the database.
                    db.StudentSheetMusic.Add(studentSheetMusic);

                    //Save the changes made to the database.
                    db.SaveChanges();

                    //Close the connection
                    db.Database.Connection.Close();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("All fields must be filled in!");
                Console.Write(ex);
            }
        }

        private void tutorEnsemblesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
