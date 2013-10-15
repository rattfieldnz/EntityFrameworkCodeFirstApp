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

            InsertRecords insertTestRecords = new InsertRecords();

            insertTestRecords.InsertInstrumentRecord();
            insertTestRecords.InsertEnsembleRecord();
            insertTestRecords.InsertAddressRecord();
            insertTestRecords.InsertPersonRecord();
            insertTestRecords.InsertSheetMusicRecord();
            insertTestRecords.InsertStudentRecord();
            insertTestRecords.InsertStudentSheetMusicRecord();
            insertTestRecords.InsertPositionsHeldRecord();
            insertTestRecords.InsertTutorRecord();
            insertTestRecords.InsertTutorPositionsHeldRecord();
            insertTestRecords.InsertLessonRecord();
            insertTestRecords.InsertLocationRecord();
            insertTestRecords.InsertPerformanceRecord();

            Application.Run(new Form1());
        }

        
    }
}
