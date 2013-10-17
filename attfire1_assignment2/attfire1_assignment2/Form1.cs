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

        private void submitUpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new MusicClassesContext())
                {
                    var address = new Address()
                    {
                        StreetAddress = streetAddressField.Text.ToString(),
                        Suburb = suburbField.Text.ToString(),
                        TownOrCity = studentTownOrCityField.Text.ToString(),
                        PostCode = int.Parse(postCodeField.Text.ToString()),
                        LandlinePhone = landlinePhoneField.Text.ToString()
                    };

                    db.Address.Add(address);
                    db.SaveChanges();
                    db.Database.Connection.Close();

                    var person = new Person()
                    {
                        FirstName = firstNameField.Text,
                        LastName = lastNameField.Text,
                        EmailAddress = emailAddressField.Text,
                        MobileNumber = mobilePhoneField.Text,

                        EnsembleEnsembleId = (from ensemble in db.Ensemble
                                              where ensemble.EnsembleName == ensembleDropdownBox.Text
                                              select ensemble.EnsembleId).FirstOrDefault(),

                        AddressAddressId = (from a in db.Address
                                            where a.StreetAddress == address.StreetAddress
                                            && a.Suburb == address.Suburb
                                            && a.TownOrCity == address.TownOrCity
                                            && a.PostCode == address.PostCode
                                            && a.LandlinePhone == address.LandlinePhone
                                            select a.AddressId).FirstOrDefault(),

                        Ensemble = (from en in db.Ensemble
                                    where en.EnsembleId == (from ensemble in db.Ensemble
                                                            where ensemble.EnsembleName == ensembleDropdownBox.Text
                                                            select ensemble.EnsembleId).FirstOrDefault()
                                    select en).First(),

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

                    db.Person.Add(person);
                    db.SaveChanges();
                    db.Database.Connection.Close();

                    var student = new Student()
                    {
                        Age = short.Parse(ageField.Text.ToString()),
                        LessonFeesOwed = Convert.ToDecimal(lessonFeesOwedField.Text.ToString()),
                        InstrumentFeesOwed = Convert.ToDecimal(instrumentFeesOwedField.Text.ToString()),
                        InstrumentInstrumentId = (from i in db.Instrument
                                                  where i.InstrumentName == instrumentDropdownBox.Text
                                                  select i.InstrumentId).FirstOrDefault(),
                        PersonPersonId = person.PersonId,
                        Instrument = (from i in db.Instrument
                                      where i.InstrumentId == (from inst in db.Instrument
                                                               where inst.InstrumentName == instrumentDropdownBox.Text
                                                               select inst.InstrumentId).FirstOrDefault()
                                      select i).FirstOrDefault(),
                        Person = (from p in db.Person
                                  where p.PersonId == person.PersonId
                                  select p).FirstOrDefault()
                    };

                    db.Student.Add(student);
                    db.SaveChanges();
                    db.Database.Connection.Close();

                    var studentLesson = new StudentLesson()
                    {
                        StudentStudentId = student.StudentId,
                        LessonLessonId = (from l in db.Lesson
                                          where l.LessonName == lessonDropdownBox.Text
                                          select l.LessonId).FirstOrDefault(),
                        Lesson = (from l in db.Lesson
                                  where l.LessonId == (from le in db.Lesson
                                                       where le.LessonName == lessonDropdownBox.Text
                                                       select le.LessonId).FirstOrDefault()
                                  select l).FirstOrDefault(),
                        Student = student
                    };

                    db.StudentLesson.Add(studentLesson);
                    db.SaveChanges();
                    db.Database.Connection.Close();

                    string sheetMusicTitle = sheetMusicListBox.SelectedItem.ToString();

                    var studentSheetMusic = new StudentSheetMusic()
                    {
                        StudentStudentId = student.StudentId,
                        SheetMusicSheetMusicId = (from s in db.SheetMusic
                                                  where s.Title == sheetMusicTitle
                                                  select s.SheetMusicId).FirstOrDefault(),
                        Student = student,
                        SheetMusic = (from sm in db.SheetMusic
                                      where sm.SheetMusicId == (from s in db.SheetMusic
                                                                where s.Title == sheetMusicTitle
                                                                select s.SheetMusicId).FirstOrDefault()
                                      select sm).FirstOrDefault()

                    };

                    db.StudentSheetMusic.Add(studentSheetMusic);
                    db.SaveChanges();
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
