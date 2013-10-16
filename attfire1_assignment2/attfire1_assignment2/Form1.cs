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

            //Adding tutors in database to lesson tutors in Lesson pane
            using (var db = new MusicClassesContext())
            {
                var tutors = (from p in db.Person
                              join t in db.Tutor
                              on p.PersonId equals t.PersonPersonId
                              select (p.FirstName + " " + p.LastName));

                foreach (string tutor in tutors)
                {
                    lessonTutorDropdown.Items.Add(tutor);
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
            // TODO: This line of code loads data into the '_attfire1_assignment2_MusicClassesContextDataSet3.Ensembles' table. You can move, or remove it, as needed.
            this.ensemblesTableAdapter.Fill(this._attfire1_assignment2_MusicClassesContextDataSet3.Ensembles);
            // TODO: This line of code loads data into the '_attfire1_assignment2_MusicClassesContextDataSet2.SheetMusics' table. You can move, or remove it, as needed.
            this.sheetMusicsTableAdapter.Fill(this._attfire1_assignment2_MusicClassesContextDataSet2.SheetMusics);
            // TODO: This line of code loads data into the '_attfire1_assignment2_MusicClassesContextDataSet1.Instruments' table. You can move, or remove it, as needed.
            this.instrumentsTableAdapter.Fill(this._attfire1_assignment2_MusicClassesContextDataSet1.Instruments);
            // TODO: This line of code loads data into the '_attfire1_assignment2_MusicClassesContextDataSet.Lessons' table. You can move, or remove it, as needed.
            this.lessonsTableAdapter.Fill(this._attfire1_assignment2_MusicClassesContextDataSet.Lessons);
            
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
            using (var db = new MusicClassesContext())
            {
                var address = new Address()
                {
                    StreetAddress = streetAddressField.Text, 
                    Suburb = suburbField.Text, 
                    TownOrCity = studentTownOrCityField.Text, 
                    PostCode = int.Parse(postCodeField.Text),
                    LandlinePhone = landlinePhoneField.Text
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
                                         select ensemble.EnsembleId).First(), 

                    AddressAddressId = (from a in db.Address 
                                        where a.StreetAddress == address.StreetAddress 
                                        && a.Suburb == address.Suburb 
                                        && a.TownOrCity == address.TownOrCity 
                                        && a.PostCode == address.PostCode 
                                        && a.LandlinePhone == address.LandlinePhone 
                                        select a.AddressId).First(),

                    Ensemble = (from en in db.Ensemble
                               where en.EnsembleId == (from ensemble in db.Ensemble
                                                      where ensemble.EnsembleName == ensembleDropdownBox.Text
                                                      select ensemble.EnsembleId).First()
                               select en).First(), 

                    Address = (from ad in db.Address 
                              where ad.AddressId == (from a in db.Address 
                                                    where a.StreetAddress == address.StreetAddress 
                                                    && a.Suburb == address.Suburb 
                                                    && a.TownOrCity == address.TownOrCity 
                                                    && a.PostCode == address.PostCode 
                                                    && a.LandlinePhone == address.LandlinePhone 
                                                    select a.AddressId).First() 
                              select ad).First()
                };

                db.Person.Add(person);
                db.SaveChanges();
                db.Database.Connection.Close();

                var student = new Student()
                {
                    Age = short.Parse(ageField.Text),
                    LessonFeesOwed = Convert.ToDecimal(lessonFeesOwedField.Text),
                    InstrumentFeesOwed = Convert.ToDecimal(instrumentFeesOwedField.Text),
                    InstrumentInstrumentId = (from i in db.Instrument
                                              where i.InstrumentName == instrumentDropdownBox.Text
                                              select i.InstrumentId).First(),
                    PersonPersonId = person.PersonId,
                    Instrument = (from i in db.Instrument
                                  where i.InstrumentId == (from inst in db.Instrument
                                                           where inst.InstrumentName == instrumentDropdownBox.Text
                                                           select inst.InstrumentId).First()
                                  select i).First(),
                    Person = (from p in db.Person
                              where p.PersonId == person.PersonId
                              select p).First()
                };

                db.Student.Add(student);
                db.SaveChanges();
                db.Database.Connection.Close();

                var studentLesson = new StudentLesson()
                {
                    StudentStudentId = student.StudentId,
                    LessonLessonId = (from l in db.Lesson
                                      where l.LessonName == lessonDropdownBox.Text
                                      select l.LessonId).First(), 
                    Lesson = (from l in db.Lesson 
                             where l.LessonId == (from le in db.Lesson 
                                                 where le.LessonName == lessonDropdownBox.Text 
                                                 select le.LessonId).First() 
                             select l).First(), 
                    Student = student
                };

                db.StudentLesson.Add(studentLesson);
                db.SaveChanges();
                db.Database.Connection.Close();

                var studentSheetMusic = new StudentSheetMusic()
                {
                    StudentStudentId = student.StudentId, 
                    SheetMusicSheetMusicId = (from s in db.SheetMusic 
                                             where s.Title == sheetMusicListBox.SelectedItem 
                                             select s.SheetMusicId).First(), 
                    Student = student, 
                    SheetMusic = (from sm in db.SheetMusic 
                                 where sm.SheetMusicId == (from s in db.SheetMusic 
                                                           where s.Title == sheetMusicListBox.SelectedItem 
                                                           select s.SheetMusicId).First() 
                                 select sm).First()

                };

                db.StudentSheetMusic.Add(studentSheetMusic);
                db.SaveChanges();
                db.Database.Connection.Close();
            }
        }
    }
}
