using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_attfire1_assignment2_MusicClassesContextDataSet7.Instruments' table. You can move, or remove it, as needed.
            this.instrumentsTableAdapter1.Fill(this._attfire1_assignment2_MusicClassesContextDataSet7.Instruments);
            // TODO: This line of code loads data into the '_attfire1_assignment2_MusicClassesContextDataSet3.SheetMusics' table. You can move, or remove it, as needed.
            this.sheetMusicsTableAdapter.Fill(this._attfire1_assignment2_MusicClassesContextDataSet3.SheetMusics);

            //Adding tutors in database to lesson tutors in Lesson pane
            using (var db = new MusicClassesContext())
            {
                var tutors = (from p in db.Person
                              join t in db.Tutor
                              on p.PersonId equals t.PersonPersonId
                              select (p.FirstName + " " + p.LastName));

                foreach(string tutor in tutors)
                {
                    lessonTutorDropdown.Items.Add(tutor);
                }
            }

            //lessonTutorDropdown
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
    }
}
