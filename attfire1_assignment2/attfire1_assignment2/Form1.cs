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
            // TODO: This line of code loads data into the '_attfire1_assignment2_MusicClassesContextDataSet4.Ensembles' table. You can move, or remove it, as needed.
            this.ensemblesTableAdapter.Fill(this._attfire1_assignment2_MusicClassesContextDataSet4.Ensembles);
            // TODO: This line of code loads data into the '_attfire1_assignment2_MusicClassesContextDataSet3.SheetMusics' table. You can move, or remove it, as needed.
            this.sheetMusicsTableAdapter.Fill(this._attfire1_assignment2_MusicClassesContextDataSet3.SheetMusics);
            // TODO: This line of code loads data into the '_attfire1_assignment2_MusicClassesContextDataSet1.Instruments' table. You can move, or remove it, as needed.
            this.instrumentsTableAdapter.Fill(this._attfire1_assignment2_MusicClassesContextDataSet1.Instruments);
            // TODO: This line of code loads data into the '_attfire1_assignment2_MusicClassesContextDataSet.Lessons' table. You can move, or remove it, as needed.
            this.lessonsTableAdapter.Fill(this._attfire1_assignment2_MusicClassesContextDataSet.Lessons);

            //editStudentDropdown.is
        }
    }
}
