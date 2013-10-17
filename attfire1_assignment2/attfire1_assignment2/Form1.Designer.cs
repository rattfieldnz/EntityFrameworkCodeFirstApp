using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attfire1_assignment2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainTabGroup = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.displayStudentRecords = new System.Windows.Forms.Panel();
            this.showStudentsBtn = new System.Windows.Forms.Button();
            this.showStudentsByDropdown = new System.Windows.Forms.ComboBox();
            this.showStudentsByLabel = new System.Windows.Forms.Label();
            this.editStudentBtn = new System.Windows.Forms.Button();
            this.editStudentLabel = new System.Windows.Forms.Label();
            this.editStudentDropdown = new System.Windows.Forms.ComboBox();
            this.studentRecordsListbox = new System.Windows.Forms.ListBox();
            this.showStudentRecordsLabel = new System.Windows.Forms.Label();
            this.addUpdateStudent = new System.Windows.Forms.Panel();
            this.sheetMusicListBox = new System.Windows.Forms.ListBox();
            this.submitUpdateBtn = new System.Windows.Forms.Button();
            this.totalFeesOwedField = new System.Windows.Forms.TextBox();
            this.totalFeesOwedLabel = new System.Windows.Forms.Label();
            this.instrumentFeesOwedField = new System.Windows.Forms.TextBox();
            this.instrumentFeesOwedLabel = new System.Windows.Forms.Label();
            this.lessonFeesOwedField = new System.Windows.Forms.TextBox();
            this.lessonFeesOwedLabel = new System.Windows.Forms.Label();
            this.ensembleDropdownBox = new System.Windows.Forms.ComboBox();
            this.ensembleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.instrumentDropdownBox = new System.Windows.Forms.ComboBox();
            this.instrumentLabel = new System.Windows.Forms.Label();
            this.lessonDropdownBox = new System.Windows.Forms.ComboBox();
            this.lessonLabel = new System.Windows.Forms.Label();
            this.emailAddressField = new System.Windows.Forms.TextBox();
            this.mobilePhoneField = new System.Windows.Forms.TextBox();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.mobilePhoneLabel = new System.Windows.Forms.Label();
            this.landlinePhoneField = new System.Windows.Forms.TextBox();
            this.landlinePhoneLabel = new System.Windows.Forms.Label();
            this.studentTownOrCityField = new System.Windows.Forms.TextBox();
            this.townOrCityLabel = new System.Windows.Forms.Label();
            this.postCodeField = new System.Windows.Forms.TextBox();
            this.postCodeLabel = new System.Windows.Forms.Label();
            this.suburbField = new System.Windows.Forms.TextBox();
            this.suburbLabel = new System.Windows.Forms.Label();
            this.streetAddressField = new System.Windows.Forms.TextBox();
            this.streetAddressLabel = new System.Windows.Forms.Label();
            this.ageField = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.lastNameField = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameField = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.addOrUpdateStudentLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.showTutorsBtn = new System.Windows.Forms.Button();
            this.showTutorsByDropdown = new System.Windows.Forms.ComboBox();
            this.showTutorsByLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.editSelectedTutorLabel = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.showTutorRecordsListbox = new System.Windows.Forms.ListBox();
            this.showTutorRecordsLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.tutorEnsemblesListBox = new System.Windows.Forms.ListBox();
            this.tutorSheetMusicListbox = new System.Windows.Forms.ListBox();
            this.tutorEnsemblesLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.levelCheckboxesGroup = new System.Windows.Forms.GroupBox();
            this.tutorLevel8Checkbox = new System.Windows.Forms.CheckBox();
            this.tutorLevel7Checkbox = new System.Windows.Forms.CheckBox();
            this.tutorLevel6Checkbox = new System.Windows.Forms.CheckBox();
            this.tutorLevel5Checkbox = new System.Windows.Forms.CheckBox();
            this.tutorLevel4Checkbox = new System.Windows.Forms.CheckBox();
            this.tutorLevel3Checkbox = new System.Windows.Forms.CheckBox();
            this.tutorLevel2Checkbox = new System.Windows.Forms.CheckBox();
            this.tutorLevel1Checkbox = new System.Windows.Forms.CheckBox();
            this.tutorSheetMusicLabel = new System.Windows.Forms.Label();
            this.lessonsToTeachListbox = new System.Windows.Forms.ListBox();
            this.lessonsToTeachLabel = new System.Windows.Forms.Label();
            this.qualificationsSubLabel = new System.Windows.Forms.Label();
            this.qualificationsLabel = new System.Windows.Forms.Label();
            this.qualificationsTextbox = new System.Windows.Forms.RichTextBox();
            this.tutorMobileTextbox = new System.Windows.Forms.TextBox();
            this.tutorMobileLabel = new System.Windows.Forms.Label();
            this.tutorLandlineTextbox = new System.Windows.Forms.TextBox();
            this.tutorLandlineLabel = new System.Windows.Forms.Label();
            this.tutorTownOrCityTextbox = new System.Windows.Forms.TextBox();
            this.tutorTownOrCityLabel = new System.Windows.Forms.Label();
            this.tutorPostcodeTextbox = new System.Windows.Forms.TextBox();
            this.tutorPostcodeLabel = new System.Windows.Forms.Label();
            this.tutorSuburbTextbox = new System.Windows.Forms.TextBox();
            this.tutorSuburbLabel = new System.Windows.Forms.Label();
            this.tutorStreetAddressTextbox = new System.Windows.Forms.TextBox();
            this.tutorStreetAddressLabel = new System.Windows.Forms.Label();
            this.tutorAgeTextbox = new System.Windows.Forms.TextBox();
            this.tutorAgeLabel = new System.Windows.Forms.Label();
            this.tutorLastNameTextbox = new System.Windows.Forms.TextBox();
            this.tutorLastNameLabel = new System.Windows.Forms.Label();
            this.tutorFirstNameTextbox = new System.Windows.Forms.TextBox();
            this.tutorFirstNameLabel = new System.Windows.Forms.Label();
            this.addUpdateTutorLabel = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.showRecordsByBtn = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.showRecordsByLabel = new System.Windows.Forms.Label();
            this.editSheetMusicRecordBtn = new System.Windows.Forms.Button();
            this.editSheetMusicRecordLabel = new System.Windows.Forms.Label();
            this.editSheetMusicRecordDropdown = new System.Windows.Forms.ComboBox();
            this.sheetMusicRecordsListbox = new System.Windows.Forms.ListBox();
            this.showSheetMusicRecordsLabel = new System.Windows.Forms.Label();
            this.sheetMusicRecordPanel = new System.Windows.Forms.Panel();
            this.sheetMusicSubmitBtn = new System.Windows.Forms.Button();
            this.sheetMusicAuthCopiesTextbox = new System.Windows.Forms.TextBox();
            this.sheetMusicAuthCopiesLabel = new System.Windows.Forms.Label();
            this.sheetMusicDifficultyDropdown = new System.Windows.Forms.ComboBox();
            this.sheetMusicDifficultyLabel = new System.Windows.Forms.Label();
            this.sheetMusicComposerTextbox = new System.Windows.Forms.TextBox();
            this.sheetMusicComposerLabel = new System.Windows.Forms.Label();
            this.sheetMusicTitleTextbox = new System.Windows.Forms.TextBox();
            this.sheetMusicTitleLabel = new System.Windows.Forms.Label();
            this.addUpdateSheetMusicLabel = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.editInstrumentBtn = new System.Windows.Forms.Button();
            this.editInstrumentLabel = new System.Windows.Forms.Label();
            this.editInstrumentDropdown = new System.Windows.Forms.ComboBox();
            this.instrumentListbox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.instrumentConditionDropdown = new System.Windows.Forms.ComboBox();
            this.instrumentStatusDropdown = new System.Windows.Forms.ComboBox();
            this.instrumentFeeTextbox = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.instrumentAuthCopiesTextbox = new System.Windows.Forms.TextBox();
            this.instrumentAuthCopiesLabel = new System.Windows.Forms.Label();
            this.instrumentConditionLabel = new System.Windows.Forms.Label();
            this.instrumentStatusLabel = new System.Windows.Forms.Label();
            this.instrumentFeeLabel = new System.Windows.Forms.Label();
            this.instrumentSizeTextbox = new System.Windows.Forms.TextBox();
            this.instrumentSizeLabel = new System.Windows.Forms.Label();
            this.nameOfInstrumentTextbox = new System.Windows.Forms.TextBox();
            this.nameOfInstrumentLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.showPerformanceRecordsPanel = new System.Windows.Forms.Panel();
            this.showPerformancesBtn = new System.Windows.Forms.Button();
            this.showPerformancesByDropdown = new System.Windows.Forms.ComboBox();
            this.showPerformancesByLabel = new System.Windows.Forms.Label();
            this.editUpdatePerformanceBtn = new System.Windows.Forms.Button();
            this.editUpdatePerformanceLabel = new System.Windows.Forms.Label();
            this.editUpdatePerformanceDropdown = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.showPerformanceRecordsLabel = new System.Windows.Forms.Label();
            this.addUpdatePerformancesPanel = new System.Windows.Forms.Panel();
            this.totalRevenueLabel = new System.Windows.Forms.Label();
            this.totalAttendeesLabel = new System.Windows.Forms.Label();
            this.totalRevenueTextbox = new System.Windows.Forms.TextBox();
            this.beneficiaryPriceTextbox = new System.Windows.Forms.TextBox();
            this.totalAttendeesTextbox = new System.Windows.Forms.TextBox();
            this.studentPriceTextbox = new System.Windows.Forms.TextBox();
            this.beneficiaryAttendeesAmtTextbox = new System.Windows.Forms.TextBox();
            this.child5to17AttendeesAmtTextbox = new System.Windows.Forms.TextBox();
            this.child5to17textbox = new System.Windows.Forms.TextBox();
            this.studentAttendeesAmtTextbox = new System.Windows.Forms.TextBox();
            this.childUnder5AttendeesAmtTextbox = new System.Windows.Forms.TextBox();
            this.childUnder5Textbox = new System.Windows.Forms.TextBox();
            this.adultAttendeesAmtTextbox = new System.Windows.Forms.TextBox();
            this.adultPriceTextbox = new System.Windows.Forms.TextBox();
            this.totalsLabel = new System.Windows.Forms.Label();
            this.beneficiaryPriceLabel = new System.Windows.Forms.Label();
            this.studentPriceLabel = new System.Windows.Forms.Label();
            this.child5to17label = new System.Windows.Forms.Label();
            this.childUnder5Label = new System.Windows.Forms.Label();
            this.adultPriceLabel = new System.Windows.Forms.Label();
            this.noOfAttendeesLabel = new System.Windows.Forms.Label();
            this.ticketPricesLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.performanceTimeFinishedLabel = new System.Windows.Forms.Label();
            this.performanceTimeStartedLabel = new System.Windows.Forms.Label();
            this.submitUpdatePerformancesBtn = new System.Windows.Forms.Button();
            this.performanceTimeFinishedTextbox = new System.Windows.Forms.TextBox();
            this.performanceDateLabel = new System.Windows.Forms.Label();
            this.performanceTimeStartedTextbox = new System.Windows.Forms.TextBox();
            this.performanceDateTextbox = new System.Windows.Forms.TextBox();
            this.performanceNameTextboz = new System.Windows.Forms.TextBox();
            this.performanceVenueTextbox = new System.Windows.Forms.TextBox();
            this.performanceNameLabel = new System.Windows.Forms.Label();
            this.performanceVenueLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.showEnsembleLevelBtn = new System.Windows.Forms.Label();
            this.showEnsembleNameLabel = new System.Windows.Forms.Label();
            this.showEnsemblesListbox = new System.Windows.Forms.ListBox();
            this.showEnsemblesByDropdown = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.showEnsemblesByBtn = new System.Windows.Forms.Button();
            this.showEnsemblesByLabel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ensembleNoOfPerformancesLabel = new System.Windows.Forms.Label();
            this.ensembleMainInstrumentUsedLabel = new System.Windows.Forms.Label();
            this.ensembleMemberNameLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.displayEnsemblesByDropdown = new System.Windows.Forms.ComboBox();
            this.displayEnsemblesByLabel = new System.Windows.Forms.Label();
            this.ensembleRecordsListbox = new System.Windows.Forms.ListBox();
            this.showEnsembleRecordsLabel = new System.Windows.Forms.Label();
            this.addUpdateEnsemblePanel = new System.Windows.Forms.Panel();
            this.ensembleLevelDropdown = new System.Windows.Forms.ComboBox();
            this.ensembleNameTextbox = new System.Windows.Forms.TextBox();
            this.submitUpdateEnsembleBtn = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.ensembleLevelTextbox = new System.Windows.Forms.Label();
            this.ensembleNameLabel = new System.Windows.Forms.Label();
            this.ensembleRecordsLabel = new System.Windows.Forms.Label();
            this.lessonRecordsTab = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.displayLessonsListbox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lessonTutorLabel = new System.Windows.Forms.Label();
            this.lessonInstrumentLabel = new System.Windows.Forms.Label();
            this.lessonTutorDropdown = new System.Windows.Forms.ComboBox();
            this.lessonInstrumentDropdown = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.openLessonFeeTextbox = new System.Windows.Forms.TextBox();
            this.studentLessonFeeTextbox = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lessonLocationTextbox = new System.Windows.Forms.TextBox();
            this.lessonNameTextbox = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.openLessonFeeLabel = new System.Windows.Forms.Label();
            this.studentLessonFeeLabel = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lessonLocationLabel = new System.Windows.Forms.Label();
            this.lessonNameLabel = new System.Windows.Forms.Label();
            this.addUpdateLessonRecordsLabel = new System.Windows.Forms.Label();
            this.mainBannerLogo = new System.Windows.Forms.PictureBox();
            this.mainTabGroup.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.displayStudentRecords.SuspendLayout();
            this.addUpdateStudent.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.levelCheckboxesGroup.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.sheetMusicRecordPanel.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.showPerformanceRecordsPanel.SuspendLayout();
            this.addUpdatePerformancesPanel.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.addUpdateEnsemblePanel.SuspendLayout();
            this.lessonRecordsTab.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainBannerLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabGroup
            // 
            this.mainTabGroup.Controls.Add(this.tabPage1);
            this.mainTabGroup.Controls.Add(this.tabPage2);
            this.mainTabGroup.Controls.Add(this.tabPage3);
            this.mainTabGroup.Controls.Add(this.tabPage4);
            this.mainTabGroup.Controls.Add(this.tabPage5);
            this.mainTabGroup.Controls.Add(this.tabPage6);
            this.mainTabGroup.Controls.Add(this.lessonRecordsTab);
            this.mainTabGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTabGroup.ItemSize = new System.Drawing.Size(166, 30);
            this.mainTabGroup.Location = new System.Drawing.Point(4, 137);
            this.mainTabGroup.Name = "mainTabGroup";
            this.mainTabGroup.SelectedIndex = 0;
            this.mainTabGroup.Size = new System.Drawing.Size(1000, 615);
            this.mainTabGroup.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mainTabGroup.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.displayStudentRecords);
            this.tabPage1.Controls.Add(this.addUpdateStudent);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(992, 577);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Student Records";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // displayStudentRecords
            // 
            this.displayStudentRecords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayStudentRecords.Controls.Add(this.showStudentsBtn);
            this.displayStudentRecords.Controls.Add(this.showStudentsByDropdown);
            this.displayStudentRecords.Controls.Add(this.showStudentsByLabel);
            this.displayStudentRecords.Controls.Add(this.editStudentBtn);
            this.displayStudentRecords.Controls.Add(this.editStudentLabel);
            this.displayStudentRecords.Controls.Add(this.editStudentDropdown);
            this.displayStudentRecords.Controls.Add(this.studentRecordsListbox);
            this.displayStudentRecords.Controls.Add(this.showStudentRecordsLabel);
            this.displayStudentRecords.Location = new System.Drawing.Point(395, 18);
            this.displayStudentRecords.Name = "displayStudentRecords";
            this.displayStudentRecords.Size = new System.Drawing.Size(588, 553);
            this.displayStudentRecords.TabIndex = 1;
            // 
            // showStudentsBtn
            // 
            this.showStudentsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showStudentsBtn.Location = new System.Drawing.Point(431, 39);
            this.showStudentsBtn.Name = "showStudentsBtn";
            this.showStudentsBtn.Size = new System.Drawing.Size(149, 30);
            this.showStudentsBtn.TabIndex = 8;
            this.showStudentsBtn.Text = "Show Students";
            this.showStudentsBtn.UseVisualStyleBackColor = true;
            // 
            // showStudentsByDropdown
            // 
            this.showStudentsByDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.showStudentsByDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showStudentsByDropdown.FormattingEnabled = true;
            this.showStudentsByDropdown.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "Age",
            "Level",
            "Suburb",
            "Town/City",
            "Lesson Fees Owed",
            "Instrument Fees Owed",
            "Total Fees Owed"});
            this.showStudentsByDropdown.Location = new System.Drawing.Point(431, 7);
            this.showStudentsByDropdown.Name = "showStudentsByDropdown";
            this.showStudentsByDropdown.Size = new System.Drawing.Size(149, 24);
            this.showStudentsByDropdown.TabIndex = 7;
            // 
            // showStudentsByLabel
            // 
            this.showStudentsByLabel.AutoSize = true;
            this.showStudentsByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showStudentsByLabel.Location = new System.Drawing.Point(306, 10);
            this.showStudentsByLabel.Name = "showStudentsByLabel";
            this.showStudentsByLabel.Size = new System.Drawing.Size(122, 17);
            this.showStudentsByLabel.TabIndex = 6;
            this.showStudentsByLabel.Text = "Show Students By";
            // 
            // editStudentBtn
            // 
            this.editStudentBtn.Location = new System.Drawing.Point(258, 464);
            this.editStudentBtn.Name = "editStudentBtn";
            this.editStudentBtn.Size = new System.Drawing.Size(75, 26);
            this.editStudentBtn.TabIndex = 5;
            this.editStudentBtn.Text = "Go";
            this.editStudentBtn.UseVisualStyleBackColor = true;
            // 
            // editStudentLabel
            // 
            this.editStudentLabel.AutoSize = true;
            this.editStudentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editStudentLabel.Location = new System.Drawing.Point(129, 466);
            this.editStudentLabel.Name = "editStudentLabel";
            this.editStudentLabel.Size = new System.Drawing.Size(127, 20);
            this.editStudentLabel.TabIndex = 4;
            this.editStudentLabel.Text = "selected student";
            // 
            // editStudentDropdown
            // 
            this.editStudentDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editStudentDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editStudentDropdown.FormattingEnabled = true;
            this.editStudentDropdown.Items.AddRange(new object[] {
            "Edit/Update",
            "Delete"});
            this.editStudentDropdown.Location = new System.Drawing.Point(5, 464);
            this.editStudentDropdown.Name = "editStudentDropdown";
            this.editStudentDropdown.Size = new System.Drawing.Size(121, 24);
            this.editStudentDropdown.TabIndex = 3;
            // 
            // studentRecordsListbox
            // 
            this.studentRecordsListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentRecordsListbox.FormattingEnabled = true;
            this.studentRecordsListbox.ItemHeight = 16;
            this.studentRecordsListbox.Location = new System.Drawing.Point(5, 105);
            this.studentRecordsListbox.Name = "studentRecordsListbox";
            this.studentRecordsListbox.Size = new System.Drawing.Size(575, 340);
            this.studentRecordsListbox.TabIndex = 2;
            // 
            // showStudentRecordsLabel
            // 
            this.showStudentRecordsLabel.AutoSize = true;
            this.showStudentRecordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showStudentRecordsLabel.Location = new System.Drawing.Point(4, 4);
            this.showStudentRecordsLabel.Name = "showStudentRecordsLabel";
            this.showStudentRecordsLabel.Size = new System.Drawing.Size(194, 20);
            this.showStudentRecordsLabel.TabIndex = 0;
            this.showStudentRecordsLabel.Text = "Show Student Records";
            // 
            // addUpdateStudent
            // 
            this.addUpdateStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addUpdateStudent.Controls.Add(this.sheetMusicListBox);
            this.addUpdateStudent.Controls.Add(this.submitUpdateBtn);
            this.addUpdateStudent.Controls.Add(this.totalFeesOwedField);
            this.addUpdateStudent.Controls.Add(this.totalFeesOwedLabel);
            this.addUpdateStudent.Controls.Add(this.instrumentFeesOwedField);
            this.addUpdateStudent.Controls.Add(this.instrumentFeesOwedLabel);
            this.addUpdateStudent.Controls.Add(this.lessonFeesOwedField);
            this.addUpdateStudent.Controls.Add(this.lessonFeesOwedLabel);
            this.addUpdateStudent.Controls.Add(this.ensembleDropdownBox);
            this.addUpdateStudent.Controls.Add(this.ensembleLabel);
            this.addUpdateStudent.Controls.Add(this.label1);
            this.addUpdateStudent.Controls.Add(this.instrumentDropdownBox);
            this.addUpdateStudent.Controls.Add(this.instrumentLabel);
            this.addUpdateStudent.Controls.Add(this.lessonDropdownBox);
            this.addUpdateStudent.Controls.Add(this.lessonLabel);
            this.addUpdateStudent.Controls.Add(this.emailAddressField);
            this.addUpdateStudent.Controls.Add(this.mobilePhoneField);
            this.addUpdateStudent.Controls.Add(this.emailAddressLabel);
            this.addUpdateStudent.Controls.Add(this.mobilePhoneLabel);
            this.addUpdateStudent.Controls.Add(this.landlinePhoneField);
            this.addUpdateStudent.Controls.Add(this.landlinePhoneLabel);
            this.addUpdateStudent.Controls.Add(this.studentTownOrCityField);
            this.addUpdateStudent.Controls.Add(this.townOrCityLabel);
            this.addUpdateStudent.Controls.Add(this.postCodeField);
            this.addUpdateStudent.Controls.Add(this.postCodeLabel);
            this.addUpdateStudent.Controls.Add(this.suburbField);
            this.addUpdateStudent.Controls.Add(this.suburbLabel);
            this.addUpdateStudent.Controls.Add(this.streetAddressField);
            this.addUpdateStudent.Controls.Add(this.streetAddressLabel);
            this.addUpdateStudent.Controls.Add(this.ageField);
            this.addUpdateStudent.Controls.Add(this.ageLabel);
            this.addUpdateStudent.Controls.Add(this.lastNameField);
            this.addUpdateStudent.Controls.Add(this.lastNameLabel);
            this.addUpdateStudent.Controls.Add(this.firstNameField);
            this.addUpdateStudent.Controls.Add(this.firstNameLabel);
            this.addUpdateStudent.Controls.Add(this.addOrUpdateStudentLabel);
            this.addUpdateStudent.Location = new System.Drawing.Point(20, 18);
            this.addUpdateStudent.Name = "addUpdateStudent";
            this.addUpdateStudent.Size = new System.Drawing.Size(368, 553);
            this.addUpdateStudent.TabIndex = 0;
            // 
            // sheetMusicListBox
            // 
            this.sheetMusicListBox.DisplayMember = "Title";
            this.sheetMusicListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sheetMusicListBox.FormattingEnabled = true;
            this.sheetMusicListBox.Location = new System.Drawing.Point(132, 366);
            this.sheetMusicListBox.Name = "sheetMusicListBox";
            this.sheetMusicListBox.Size = new System.Drawing.Size(229, 43);
            this.sheetMusicListBox.TabIndex = 36;
            this.sheetMusicListBox.ValueMember = "Title";
            // 
            // submitUpdateBtn
            // 
            this.submitUpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitUpdateBtn.Location = new System.Drawing.Point(272, 479);
            this.submitUpdateBtn.Name = "submitUpdateBtn";
            this.submitUpdateBtn.Size = new System.Drawing.Size(77, 53);
            this.submitUpdateBtn.TabIndex = 35;
            this.submitUpdateBtn.Text = "Submit / Update";
            this.submitUpdateBtn.UseVisualStyleBackColor = true;
            this.submitUpdateBtn.Click += new System.EventHandler(this.submitUpdateBtn_Click);
            // 
            // totalFeesOwedField
            // 
            this.totalFeesOwedField.Location = new System.Drawing.Point(155, 520);
            this.totalFeesOwedField.Name = "totalFeesOwedField";
            this.totalFeesOwedField.Size = new System.Drawing.Size(100, 23);
            this.totalFeesOwedField.TabIndex = 34;
            // 
            // totalFeesOwedLabel
            // 
            this.totalFeesOwedLabel.AutoSize = true;
            this.totalFeesOwedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalFeesOwedLabel.Location = new System.Drawing.Point(37, 523);
            this.totalFeesOwedLabel.Name = "totalFeesOwedLabel";
            this.totalFeesOwedLabel.Size = new System.Drawing.Size(115, 17);
            this.totalFeesOwedLabel.TabIndex = 33;
            this.totalFeesOwedLabel.Text = "Total Fees Owed";
            // 
            // instrumentFeesOwedField
            // 
            this.instrumentFeesOwedField.Location = new System.Drawing.Point(155, 493);
            this.instrumentFeesOwedField.Name = "instrumentFeesOwedField";
            this.instrumentFeesOwedField.Size = new System.Drawing.Size(100, 23);
            this.instrumentFeesOwedField.TabIndex = 32;
            // 
            // instrumentFeesOwedLabel
            // 
            this.instrumentFeesOwedLabel.AutoSize = true;
            this.instrumentFeesOwedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instrumentFeesOwedLabel.Location = new System.Drawing.Point(3, 496);
            this.instrumentFeesOwedLabel.Name = "instrumentFeesOwedLabel";
            this.instrumentFeesOwedLabel.Size = new System.Drawing.Size(149, 17);
            this.instrumentFeesOwedLabel.TabIndex = 31;
            this.instrumentFeesOwedLabel.Text = "Instrument Fees Owed";
            // 
            // lessonFeesOwedField
            // 
            this.lessonFeesOwedField.Location = new System.Drawing.Point(155, 467);
            this.lessonFeesOwedField.Name = "lessonFeesOwedField";
            this.lessonFeesOwedField.Size = new System.Drawing.Size(100, 23);
            this.lessonFeesOwedField.TabIndex = 30;
            // 
            // lessonFeesOwedLabel
            // 
            this.lessonFeesOwedLabel.AutoSize = true;
            this.lessonFeesOwedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessonFeesOwedLabel.Location = new System.Drawing.Point(23, 470);
            this.lessonFeesOwedLabel.Name = "lessonFeesOwedLabel";
            this.lessonFeesOwedLabel.Size = new System.Drawing.Size(129, 17);
            this.lessonFeesOwedLabel.TabIndex = 29;
            this.lessonFeesOwedLabel.Text = "Lesson Fees Owed";
            // 
            // ensembleDropdownBox
            // 
            this.ensembleDropdownBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ensembleDropdownBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ensembleDropdownBox.FormattingEnabled = true;
            this.ensembleDropdownBox.Location = new System.Drawing.Point(155, 440);
            this.ensembleDropdownBox.Name = "ensembleDropdownBox";
            this.ensembleDropdownBox.Size = new System.Drawing.Size(206, 24);
            this.ensembleDropdownBox.TabIndex = 28;
            // 
            // ensembleLabel
            // 
            this.ensembleLabel.AutoSize = true;
            this.ensembleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ensembleLabel.Location = new System.Drawing.Point(82, 443);
            this.ensembleLabel.Name = "ensembleLabel";
            this.ensembleLabel.Size = new System.Drawing.Size(70, 17);
            this.ensembleLabel.TabIndex = 27;
            this.ensembleLabel.Text = "Ensemble";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Sheet Music Items";
            // 
            // instrumentDropdownBox
            // 
            this.instrumentDropdownBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.instrumentDropdownBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instrumentDropdownBox.FormattingEnabled = true;
            this.instrumentDropdownBox.Location = new System.Drawing.Point(132, 337);
            this.instrumentDropdownBox.Name = "instrumentDropdownBox";
            this.instrumentDropdownBox.Size = new System.Drawing.Size(206, 24);
            this.instrumentDropdownBox.TabIndex = 22;
            // 
            // instrumentLabel
            // 
            this.instrumentLabel.AutoSize = true;
            this.instrumentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instrumentLabel.Location = new System.Drawing.Point(9, 340);
            this.instrumentLabel.Name = "instrumentLabel";
            this.instrumentLabel.Size = new System.Drawing.Size(120, 17);
            this.instrumentLabel.TabIndex = 21;
            this.instrumentLabel.Text = "Instrument to Hire";
            // 
            // lessonDropdownBox
            // 
            this.lessonDropdownBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lessonDropdownBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessonDropdownBox.FormattingEnabled = true;
            this.lessonDropdownBox.Location = new System.Drawing.Point(132, 310);
            this.lessonDropdownBox.Name = "lessonDropdownBox";
            this.lessonDropdownBox.Size = new System.Drawing.Size(206, 24);
            this.lessonDropdownBox.TabIndex = 20;
            // 
            // lessonLabel
            // 
            this.lessonLabel.AutoSize = true;
            this.lessonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessonLabel.Location = new System.Drawing.Point(7, 313);
            this.lessonLabel.Name = "lessonLabel";
            this.lessonLabel.Size = new System.Drawing.Size(122, 17);
            this.lessonLabel.TabIndex = 19;
            this.lessonLabel.Text = "Lesson to Enrol In";
            // 
            // emailAddressField
            // 
            this.emailAddressField.Location = new System.Drawing.Point(132, 273);
            this.emailAddressField.Name = "emailAddressField";
            this.emailAddressField.Size = new System.Drawing.Size(176, 23);
            this.emailAddressField.TabIndex = 18;
            // 
            // mobilePhoneField
            // 
            this.mobilePhoneField.Location = new System.Drawing.Point(132, 247);
            this.mobilePhoneField.Name = "mobilePhoneField";
            this.mobilePhoneField.Size = new System.Drawing.Size(176, 23);
            this.mobilePhoneField.TabIndex = 18;
            // 
            // emailAddressLabel
            // 
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddressLabel.Location = new System.Drawing.Point(31, 276);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(98, 17);
            this.emailAddressLabel.TabIndex = 17;
            this.emailAddressLabel.Text = "Email Address";
            // 
            // mobilePhoneLabel
            // 
            this.mobilePhoneLabel.AutoSize = true;
            this.mobilePhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobilePhoneLabel.Location = new System.Drawing.Point(35, 250);
            this.mobilePhoneLabel.Name = "mobilePhoneLabel";
            this.mobilePhoneLabel.Size = new System.Drawing.Size(94, 17);
            this.mobilePhoneLabel.TabIndex = 17;
            this.mobilePhoneLabel.Text = "Mobile Phone";
            // 
            // landlinePhoneField
            // 
            this.landlinePhoneField.Location = new System.Drawing.Point(132, 221);
            this.landlinePhoneField.Name = "landlinePhoneField";
            this.landlinePhoneField.Size = new System.Drawing.Size(177, 23);
            this.landlinePhoneField.TabIndex = 16;
            // 
            // landlinePhoneLabel
            // 
            this.landlinePhoneLabel.AutoSize = true;
            this.landlinePhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.landlinePhoneLabel.Location = new System.Drawing.Point(22, 224);
            this.landlinePhoneLabel.Name = "landlinePhoneLabel";
            this.landlinePhoneLabel.Size = new System.Drawing.Size(107, 17);
            this.landlinePhoneLabel.TabIndex = 15;
            this.landlinePhoneLabel.Text = "Landline Phone";
            // 
            // studentTownOrCityField
            // 
            this.studentTownOrCityField.Location = new System.Drawing.Point(132, 195);
            this.studentTownOrCityField.Name = "studentTownOrCityField";
            this.studentTownOrCityField.Size = new System.Drawing.Size(178, 23);
            this.studentTownOrCityField.TabIndex = 14;
            // 
            // townOrCityLabel
            // 
            this.townOrCityLabel.AutoSize = true;
            this.townOrCityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.townOrCityLabel.Location = new System.Drawing.Point(43, 198);
            this.townOrCityLabel.Name = "townOrCityLabel";
            this.townOrCityLabel.Size = new System.Drawing.Size(86, 17);
            this.townOrCityLabel.TabIndex = 13;
            this.townOrCityLabel.Text = "Town or City";
            // 
            // postCodeField
            // 
            this.postCodeField.Location = new System.Drawing.Point(132, 169);
            this.postCodeField.Name = "postCodeField";
            this.postCodeField.Size = new System.Drawing.Size(74, 23);
            this.postCodeField.TabIndex = 12;
            // 
            // postCodeLabel
            // 
            this.postCodeLabel.AutoSize = true;
            this.postCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postCodeLabel.Location = new System.Drawing.Point(56, 172);
            this.postCodeLabel.Name = "postCodeLabel";
            this.postCodeLabel.Size = new System.Drawing.Size(73, 17);
            this.postCodeLabel.TabIndex = 11;
            this.postCodeLabel.Text = "Post Code";
            // 
            // suburbField
            // 
            this.suburbField.Location = new System.Drawing.Point(132, 143);
            this.suburbField.Name = "suburbField";
            this.suburbField.Size = new System.Drawing.Size(177, 23);
            this.suburbField.TabIndex = 10;
            // 
            // suburbLabel
            // 
            this.suburbLabel.AutoSize = true;
            this.suburbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suburbLabel.Location = new System.Drawing.Point(75, 146);
            this.suburbLabel.Name = "suburbLabel";
            this.suburbLabel.Size = new System.Drawing.Size(54, 17);
            this.suburbLabel.TabIndex = 9;
            this.suburbLabel.Text = "Suburb";
            // 
            // streetAddressField
            // 
            this.streetAddressField.Location = new System.Drawing.Point(132, 117);
            this.streetAddressField.Name = "streetAddressField";
            this.streetAddressField.Size = new System.Drawing.Size(177, 23);
            this.streetAddressField.TabIndex = 8;
            // 
            // streetAddressLabel
            // 
            this.streetAddressLabel.AutoSize = true;
            this.streetAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetAddressLabel.Location = new System.Drawing.Point(27, 120);
            this.streetAddressLabel.Name = "streetAddressLabel";
            this.streetAddressLabel.Size = new System.Drawing.Size(102, 17);
            this.streetAddressLabel.TabIndex = 7;
            this.streetAddressLabel.Text = "Street Address";
            // 
            // ageField
            // 
            this.ageField.Location = new System.Drawing.Point(132, 91);
            this.ageField.Name = "ageField";
            this.ageField.Size = new System.Drawing.Size(57, 23);
            this.ageField.TabIndex = 6;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.Location = new System.Drawing.Point(96, 94);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(33, 17);
            this.ageLabel.TabIndex = 5;
            this.ageLabel.Text = "Age";
            // 
            // lastNameField
            // 
            this.lastNameField.Location = new System.Drawing.Point(132, 66);
            this.lastNameField.Name = "lastNameField";
            this.lastNameField.Size = new System.Drawing.Size(176, 23);
            this.lastNameField.TabIndex = 4;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(53, 69);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(76, 17);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameField
            // 
            this.firstNameField.Location = new System.Drawing.Point(132, 42);
            this.firstNameField.Name = "firstNameField";
            this.firstNameField.Size = new System.Drawing.Size(176, 23);
            this.firstNameField.TabIndex = 2;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(53, 45);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(76, 17);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name";
            // 
            // addOrUpdateStudentLabel
            // 
            this.addOrUpdateStudentLabel.AutoSize = true;
            this.addOrUpdateStudentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOrUpdateStudentLabel.Location = new System.Drawing.Point(4, 4);
            this.addOrUpdateStudentLabel.Name = "addOrUpdateStudentLabel";
            this.addOrUpdateStudentLabel.Size = new System.Drawing.Size(174, 20);
            this.addOrUpdateStudentLabel.TabIndex = 0;
            this.addOrUpdateStudentLabel.Text = "Add/Update Student";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(992, 577);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tutor Records";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.showTutorsBtn);
            this.panel1.Controls.Add(this.showTutorsByDropdown);
            this.panel1.Controls.Add(this.showTutorsByLabel);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.editSelectedTutorLabel);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.showTutorRecordsListbox);
            this.panel1.Controls.Add(this.showTutorRecordsLabel);
            this.panel1.Location = new System.Drawing.Point(395, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 553);
            this.panel1.TabIndex = 3;
            // 
            // showTutorsBtn
            // 
            this.showTutorsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showTutorsBtn.Location = new System.Drawing.Point(431, 39);
            this.showTutorsBtn.Name = "showTutorsBtn";
            this.showTutorsBtn.Size = new System.Drawing.Size(149, 30);
            this.showTutorsBtn.TabIndex = 9;
            this.showTutorsBtn.Text = "Show Tutors";
            this.showTutorsBtn.UseVisualStyleBackColor = true;
            // 
            // showTutorsByDropdown
            // 
            this.showTutorsByDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.showTutorsByDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showTutorsByDropdown.FormattingEnabled = true;
            this.showTutorsByDropdown.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "Age",
            "Level",
            "Suburb",
            "Town/City"});
            this.showTutorsByDropdown.Location = new System.Drawing.Point(431, 7);
            this.showTutorsByDropdown.Name = "showTutorsByDropdown";
            this.showTutorsByDropdown.Size = new System.Drawing.Size(149, 24);
            this.showTutorsByDropdown.TabIndex = 7;
            // 
            // showTutorsByLabel
            // 
            this.showTutorsByLabel.AutoSize = true;
            this.showTutorsByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showTutorsByLabel.Location = new System.Drawing.Point(321, 11);
            this.showTutorsByLabel.Name = "showTutorsByLabel";
            this.showTutorsByLabel.Size = new System.Drawing.Size(107, 17);
            this.showTutorsByLabel.TabIndex = 6;
            this.showTutorsByLabel.Text = "Show Tutors By";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(237, 463);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 26);
            this.button2.TabIndex = 5;
            this.button2.Text = "Go";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // editSelectedTutorLabel
            // 
            this.editSelectedTutorLabel.AutoSize = true;
            this.editSelectedTutorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editSelectedTutorLabel.Location = new System.Drawing.Point(129, 466);
            this.editSelectedTutorLabel.Name = "editSelectedTutorLabel";
            this.editSelectedTutorLabel.Size = new System.Drawing.Size(106, 20);
            this.editSelectedTutorLabel.TabIndex = 4;
            this.editSelectedTutorLabel.Text = "selected tutor";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Edit/Update",
            "Delete"});
            this.comboBox3.Location = new System.Drawing.Point(5, 464);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 3;
            // 
            // showTutorRecordsListbox
            // 
            this.showTutorRecordsListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showTutorRecordsListbox.FormattingEnabled = true;
            this.showTutorRecordsListbox.ItemHeight = 16;
            this.showTutorRecordsListbox.Location = new System.Drawing.Point(5, 105);
            this.showTutorRecordsListbox.Name = "showTutorRecordsListbox";
            this.showTutorRecordsListbox.Size = new System.Drawing.Size(575, 340);
            this.showTutorRecordsListbox.TabIndex = 2;
            // 
            // showTutorRecordsLabel
            // 
            this.showTutorRecordsLabel.AutoSize = true;
            this.showTutorRecordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showTutorRecordsLabel.Location = new System.Drawing.Point(4, 4);
            this.showTutorRecordsLabel.Name = "showTutorRecordsLabel";
            this.showTutorRecordsLabel.Size = new System.Drawing.Size(172, 20);
            this.showTutorRecordsLabel.TabIndex = 0;
            this.showTutorRecordsLabel.Text = "Show Tutor Records";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.tutorEnsemblesListBox);
            this.panel2.Controls.Add(this.tutorSheetMusicListbox);
            this.panel2.Controls.Add(this.tutorEnsemblesLabel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.levelCheckboxesGroup);
            this.panel2.Controls.Add(this.tutorSheetMusicLabel);
            this.panel2.Controls.Add(this.lessonsToTeachListbox);
            this.panel2.Controls.Add(this.lessonsToTeachLabel);
            this.panel2.Controls.Add(this.qualificationsSubLabel);
            this.panel2.Controls.Add(this.qualificationsLabel);
            this.panel2.Controls.Add(this.qualificationsTextbox);
            this.panel2.Controls.Add(this.tutorMobileTextbox);
            this.panel2.Controls.Add(this.tutorMobileLabel);
            this.panel2.Controls.Add(this.tutorLandlineTextbox);
            this.panel2.Controls.Add(this.tutorLandlineLabel);
            this.panel2.Controls.Add(this.tutorTownOrCityTextbox);
            this.panel2.Controls.Add(this.tutorTownOrCityLabel);
            this.panel2.Controls.Add(this.tutorPostcodeTextbox);
            this.panel2.Controls.Add(this.tutorPostcodeLabel);
            this.panel2.Controls.Add(this.tutorSuburbTextbox);
            this.panel2.Controls.Add(this.tutorSuburbLabel);
            this.panel2.Controls.Add(this.tutorStreetAddressTextbox);
            this.panel2.Controls.Add(this.tutorStreetAddressLabel);
            this.panel2.Controls.Add(this.tutorAgeTextbox);
            this.panel2.Controls.Add(this.tutorAgeLabel);
            this.panel2.Controls.Add(this.tutorLastNameTextbox);
            this.panel2.Controls.Add(this.tutorLastNameLabel);
            this.panel2.Controls.Add(this.tutorFirstNameTextbox);
            this.panel2.Controls.Add(this.tutorFirstNameLabel);
            this.panel2.Controls.Add(this.addUpdateTutorLabel);
            this.panel2.Location = new System.Drawing.Point(20, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 553);
            this.panel2.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(278, 489);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 53);
            this.button3.TabIndex = 44;
            this.button3.Text = "Submit / Update";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tutorEnsemblesListBox
            // 
            this.tutorEnsemblesListBox.DisplayMember = "EnsembleName";
            this.tutorEnsemblesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorEnsemblesListBox.FormattingEnabled = true;
            this.tutorEnsemblesListBox.Location = new System.Drawing.Point(86, 481);
            this.tutorEnsemblesListBox.Name = "tutorEnsemblesListBox";
            this.tutorEnsemblesListBox.Size = new System.Drawing.Size(178, 69);
            this.tutorEnsemblesListBox.TabIndex = 43;
            this.tutorEnsemblesListBox.ValueMember = "EnsembleName";
            this.tutorEnsemblesListBox.SelectedIndexChanged += new System.EventHandler(this.tutorEnsemblesListBox_SelectedIndexChanged);
            // 
            // tutorSheetMusicListbox
            // 
            this.tutorSheetMusicListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorSheetMusicListbox.FormattingEnabled = true;
            this.tutorSheetMusicListbox.Location = new System.Drawing.Point(131, 386);
            this.tutorSheetMusicListbox.Name = "tutorSheetMusicListbox";
            this.tutorSheetMusicListbox.Size = new System.Drawing.Size(231, 56);
            this.tutorSheetMusicListbox.TabIndex = 38;
            // 
            // tutorEnsemblesLabel
            // 
            this.tutorEnsemblesLabel.AutoSize = true;
            this.tutorEnsemblesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorEnsemblesLabel.Location = new System.Drawing.Point(6, 484);
            this.tutorEnsemblesLabel.Name = "tutorEnsemblesLabel";
            this.tutorEnsemblesLabel.Size = new System.Drawing.Size(77, 17);
            this.tutorEnsemblesLabel.TabIndex = 42;
            this.tutorEnsemblesLabel.Text = "Ensembles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Levels";
            // 
            // levelCheckboxesGroup
            // 
            this.levelCheckboxesGroup.Controls.Add(this.tutorLevel8Checkbox);
            this.levelCheckboxesGroup.Controls.Add(this.tutorLevel7Checkbox);
            this.levelCheckboxesGroup.Controls.Add(this.tutorLevel6Checkbox);
            this.levelCheckboxesGroup.Controls.Add(this.tutorLevel5Checkbox);
            this.levelCheckboxesGroup.Controls.Add(this.tutorLevel4Checkbox);
            this.levelCheckboxesGroup.Controls.Add(this.tutorLevel3Checkbox);
            this.levelCheckboxesGroup.Controls.Add(this.tutorLevel2Checkbox);
            this.levelCheckboxesGroup.Controls.Add(this.tutorLevel1Checkbox);
            this.levelCheckboxesGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelCheckboxesGroup.Location = new System.Drawing.Point(48, 440);
            this.levelCheckboxesGroup.Name = "levelCheckboxesGroup";
            this.levelCheckboxesGroup.Size = new System.Drawing.Size(315, 38);
            this.levelCheckboxesGroup.TabIndex = 40;
            this.levelCheckboxesGroup.TabStop = false;
            // 
            // tutorLevel8Checkbox
            // 
            this.tutorLevel8Checkbox.AutoSize = true;
            this.tutorLevel8Checkbox.Location = new System.Drawing.Point(287, 12);
            this.tutorLevel8Checkbox.Name = "tutorLevel8Checkbox";
            this.tutorLevel8Checkbox.Size = new System.Drawing.Size(32, 17);
            this.tutorLevel8Checkbox.TabIndex = 40;
            this.tutorLevel8Checkbox.Text = "8";
            this.tutorLevel8Checkbox.UseVisualStyleBackColor = true;
            // 
            // tutorLevel7Checkbox
            // 
            this.tutorLevel7Checkbox.AutoSize = true;
            this.tutorLevel7Checkbox.Location = new System.Drawing.Point(245, 12);
            this.tutorLevel7Checkbox.Name = "tutorLevel7Checkbox";
            this.tutorLevel7Checkbox.Size = new System.Drawing.Size(32, 17);
            this.tutorLevel7Checkbox.TabIndex = 41;
            this.tutorLevel7Checkbox.Text = "7";
            this.tutorLevel7Checkbox.UseVisualStyleBackColor = true;
            // 
            // tutorLevel6Checkbox
            // 
            this.tutorLevel6Checkbox.AutoSize = true;
            this.tutorLevel6Checkbox.Location = new System.Drawing.Point(203, 12);
            this.tutorLevel6Checkbox.Name = "tutorLevel6Checkbox";
            this.tutorLevel6Checkbox.Size = new System.Drawing.Size(32, 17);
            this.tutorLevel6Checkbox.TabIndex = 42;
            this.tutorLevel6Checkbox.Text = "6";
            this.tutorLevel6Checkbox.UseVisualStyleBackColor = true;
            // 
            // tutorLevel5Checkbox
            // 
            this.tutorLevel5Checkbox.AutoSize = true;
            this.tutorLevel5Checkbox.Location = new System.Drawing.Point(167, 12);
            this.tutorLevel5Checkbox.Name = "tutorLevel5Checkbox";
            this.tutorLevel5Checkbox.Size = new System.Drawing.Size(32, 17);
            this.tutorLevel5Checkbox.TabIndex = 43;
            this.tutorLevel5Checkbox.Text = "5";
            this.tutorLevel5Checkbox.UseVisualStyleBackColor = true;
            // 
            // tutorLevel4Checkbox
            // 
            this.tutorLevel4Checkbox.AutoSize = true;
            this.tutorLevel4Checkbox.Location = new System.Drawing.Point(126, 12);
            this.tutorLevel4Checkbox.Name = "tutorLevel4Checkbox";
            this.tutorLevel4Checkbox.Size = new System.Drawing.Size(32, 17);
            this.tutorLevel4Checkbox.TabIndex = 44;
            this.tutorLevel4Checkbox.Text = "4";
            this.tutorLevel4Checkbox.UseVisualStyleBackColor = true;
            // 
            // tutorLevel3Checkbox
            // 
            this.tutorLevel3Checkbox.AutoSize = true;
            this.tutorLevel3Checkbox.Location = new System.Drawing.Point(84, 12);
            this.tutorLevel3Checkbox.Name = "tutorLevel3Checkbox";
            this.tutorLevel3Checkbox.Size = new System.Drawing.Size(32, 17);
            this.tutorLevel3Checkbox.TabIndex = 45;
            this.tutorLevel3Checkbox.Text = "3";
            this.tutorLevel3Checkbox.UseVisualStyleBackColor = true;
            // 
            // tutorLevel2Checkbox
            // 
            this.tutorLevel2Checkbox.AutoSize = true;
            this.tutorLevel2Checkbox.Location = new System.Drawing.Point(42, 12);
            this.tutorLevel2Checkbox.Name = "tutorLevel2Checkbox";
            this.tutorLevel2Checkbox.Size = new System.Drawing.Size(32, 17);
            this.tutorLevel2Checkbox.TabIndex = 46;
            this.tutorLevel2Checkbox.Text = "2";
            this.tutorLevel2Checkbox.UseVisualStyleBackColor = true;
            // 
            // tutorLevel1Checkbox
            // 
            this.tutorLevel1Checkbox.AutoSize = true;
            this.tutorLevel1Checkbox.Location = new System.Drawing.Point(6, 12);
            this.tutorLevel1Checkbox.Name = "tutorLevel1Checkbox";
            this.tutorLevel1Checkbox.Size = new System.Drawing.Size(32, 17);
            this.tutorLevel1Checkbox.TabIndex = 47;
            this.tutorLevel1Checkbox.Text = "1";
            this.tutorLevel1Checkbox.UseVisualStyleBackColor = true;
            // 
            // tutorSheetMusicLabel
            // 
            this.tutorSheetMusicLabel.AutoSize = true;
            this.tutorSheetMusicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorSheetMusicLabel.Location = new System.Drawing.Point(6, 389);
            this.tutorSheetMusicLabel.Name = "tutorSheetMusicLabel";
            this.tutorSheetMusicLabel.Size = new System.Drawing.Size(122, 17);
            this.tutorSheetMusicLabel.TabIndex = 37;
            this.tutorSheetMusicLabel.Text = "Sheet Music Items";
            // 
            // lessonsToTeachListbox
            // 
            this.lessonsToTeachListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessonsToTeachListbox.FormattingEnabled = true;
            this.lessonsToTeachListbox.Location = new System.Drawing.Point(131, 339);
            this.lessonsToTeachListbox.Name = "lessonsToTeachListbox";
            this.lessonsToTeachListbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lessonsToTeachListbox.Size = new System.Drawing.Size(231, 43);
            this.lessonsToTeachListbox.TabIndex = 23;
            // 
            // lessonsToTeachLabel
            // 
            this.lessonsToTeachLabel.AutoSize = true;
            this.lessonsToTeachLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessonsToTeachLabel.Location = new System.Drawing.Point(8, 342);
            this.lessonsToTeachLabel.Name = "lessonsToTeachLabel";
            this.lessonsToTeachLabel.Size = new System.Drawing.Size(121, 17);
            this.lessonsToTeachLabel.TabIndex = 22;
            this.lessonsToTeachLabel.Text = "Lessons to Teach";
            // 
            // qualificationsSubLabel
            // 
            this.qualificationsSubLabel.AutoSize = true;
            this.qualificationsSubLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qualificationsSubLabel.Location = new System.Drawing.Point(59, 294);
            this.qualificationsSubLabel.Name = "qualificationsSubLabel";
            this.qualificationsSubLabel.Size = new System.Drawing.Size(71, 13);
            this.qualificationsSubLabel.TabIndex = 21;
            this.qualificationsSubLabel.Text = "* One per line";
            // 
            // qualificationsLabel
            // 
            this.qualificationsLabel.AutoSize = true;
            this.qualificationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qualificationsLabel.Location = new System.Drawing.Point(32, 276);
            this.qualificationsLabel.Name = "qualificationsLabel";
            this.qualificationsLabel.Size = new System.Drawing.Size(98, 17);
            this.qualificationsLabel.TabIndex = 20;
            this.qualificationsLabel.Text = "Qualifications*";
            // 
            // qualificationsTextbox
            // 
            this.qualificationsTextbox.Location = new System.Drawing.Point(132, 273);
            this.qualificationsTextbox.Name = "qualificationsTextbox";
            this.qualificationsTextbox.Size = new System.Drawing.Size(231, 61);
            this.qualificationsTextbox.TabIndex = 19;
            this.qualificationsTextbox.Text = "";
            // 
            // tutorMobileTextbox
            // 
            this.tutorMobileTextbox.Location = new System.Drawing.Point(132, 247);
            this.tutorMobileTextbox.Name = "tutorMobileTextbox";
            this.tutorMobileTextbox.Size = new System.Drawing.Size(176, 23);
            this.tutorMobileTextbox.TabIndex = 18;
            // 
            // tutorMobileLabel
            // 
            this.tutorMobileLabel.AutoSize = true;
            this.tutorMobileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorMobileLabel.Location = new System.Drawing.Point(35, 250);
            this.tutorMobileLabel.Name = "tutorMobileLabel";
            this.tutorMobileLabel.Size = new System.Drawing.Size(94, 17);
            this.tutorMobileLabel.TabIndex = 17;
            this.tutorMobileLabel.Text = "Mobile Phone";
            // 
            // tutorLandlineTextbox
            // 
            this.tutorLandlineTextbox.Location = new System.Drawing.Point(132, 221);
            this.tutorLandlineTextbox.Name = "tutorLandlineTextbox";
            this.tutorLandlineTextbox.Size = new System.Drawing.Size(177, 23);
            this.tutorLandlineTextbox.TabIndex = 16;
            // 
            // tutorLandlineLabel
            // 
            this.tutorLandlineLabel.AutoSize = true;
            this.tutorLandlineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorLandlineLabel.Location = new System.Drawing.Point(22, 224);
            this.tutorLandlineLabel.Name = "tutorLandlineLabel";
            this.tutorLandlineLabel.Size = new System.Drawing.Size(107, 17);
            this.tutorLandlineLabel.TabIndex = 15;
            this.tutorLandlineLabel.Text = "Landline Phone";
            // 
            // tutorTownOrCityTextbox
            // 
            this.tutorTownOrCityTextbox.Location = new System.Drawing.Point(132, 195);
            this.tutorTownOrCityTextbox.Name = "tutorTownOrCityTextbox";
            this.tutorTownOrCityTextbox.Size = new System.Drawing.Size(178, 23);
            this.tutorTownOrCityTextbox.TabIndex = 14;
            // 
            // tutorTownOrCityLabel
            // 
            this.tutorTownOrCityLabel.AutoSize = true;
            this.tutorTownOrCityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorTownOrCityLabel.Location = new System.Drawing.Point(43, 198);
            this.tutorTownOrCityLabel.Name = "tutorTownOrCityLabel";
            this.tutorTownOrCityLabel.Size = new System.Drawing.Size(86, 17);
            this.tutorTownOrCityLabel.TabIndex = 13;
            this.tutorTownOrCityLabel.Text = "Town or City";
            // 
            // tutorPostcodeTextbox
            // 
            this.tutorPostcodeTextbox.Location = new System.Drawing.Point(132, 169);
            this.tutorPostcodeTextbox.Name = "tutorPostcodeTextbox";
            this.tutorPostcodeTextbox.Size = new System.Drawing.Size(74, 23);
            this.tutorPostcodeTextbox.TabIndex = 12;
            // 
            // tutorPostcodeLabel
            // 
            this.tutorPostcodeLabel.AutoSize = true;
            this.tutorPostcodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorPostcodeLabel.Location = new System.Drawing.Point(56, 172);
            this.tutorPostcodeLabel.Name = "tutorPostcodeLabel";
            this.tutorPostcodeLabel.Size = new System.Drawing.Size(73, 17);
            this.tutorPostcodeLabel.TabIndex = 11;
            this.tutorPostcodeLabel.Text = "Post Code";
            // 
            // tutorSuburbTextbox
            // 
            this.tutorSuburbTextbox.Location = new System.Drawing.Point(132, 143);
            this.tutorSuburbTextbox.Name = "tutorSuburbTextbox";
            this.tutorSuburbTextbox.Size = new System.Drawing.Size(177, 23);
            this.tutorSuburbTextbox.TabIndex = 10;
            // 
            // tutorSuburbLabel
            // 
            this.tutorSuburbLabel.AutoSize = true;
            this.tutorSuburbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorSuburbLabel.Location = new System.Drawing.Point(75, 146);
            this.tutorSuburbLabel.Name = "tutorSuburbLabel";
            this.tutorSuburbLabel.Size = new System.Drawing.Size(54, 17);
            this.tutorSuburbLabel.TabIndex = 9;
            this.tutorSuburbLabel.Text = "Suburb";
            // 
            // tutorStreetAddressTextbox
            // 
            this.tutorStreetAddressTextbox.Location = new System.Drawing.Point(132, 117);
            this.tutorStreetAddressTextbox.Name = "tutorStreetAddressTextbox";
            this.tutorStreetAddressTextbox.Size = new System.Drawing.Size(177, 23);
            this.tutorStreetAddressTextbox.TabIndex = 8;
            // 
            // tutorStreetAddressLabel
            // 
            this.tutorStreetAddressLabel.AutoSize = true;
            this.tutorStreetAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorStreetAddressLabel.Location = new System.Drawing.Point(27, 120);
            this.tutorStreetAddressLabel.Name = "tutorStreetAddressLabel";
            this.tutorStreetAddressLabel.Size = new System.Drawing.Size(102, 17);
            this.tutorStreetAddressLabel.TabIndex = 7;
            this.tutorStreetAddressLabel.Text = "Street Address";
            // 
            // tutorAgeTextbox
            // 
            this.tutorAgeTextbox.Location = new System.Drawing.Point(132, 91);
            this.tutorAgeTextbox.Name = "tutorAgeTextbox";
            this.tutorAgeTextbox.Size = new System.Drawing.Size(57, 23);
            this.tutorAgeTextbox.TabIndex = 6;
            // 
            // tutorAgeLabel
            // 
            this.tutorAgeLabel.AutoSize = true;
            this.tutorAgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorAgeLabel.Location = new System.Drawing.Point(96, 94);
            this.tutorAgeLabel.Name = "tutorAgeLabel";
            this.tutorAgeLabel.Size = new System.Drawing.Size(33, 17);
            this.tutorAgeLabel.TabIndex = 5;
            this.tutorAgeLabel.Text = "Age";
            // 
            // tutorLastNameTextbox
            // 
            this.tutorLastNameTextbox.Location = new System.Drawing.Point(132, 66);
            this.tutorLastNameTextbox.Name = "tutorLastNameTextbox";
            this.tutorLastNameTextbox.Size = new System.Drawing.Size(176, 23);
            this.tutorLastNameTextbox.TabIndex = 4;
            // 
            // tutorLastNameLabel
            // 
            this.tutorLastNameLabel.AutoSize = true;
            this.tutorLastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorLastNameLabel.Location = new System.Drawing.Point(53, 69);
            this.tutorLastNameLabel.Name = "tutorLastNameLabel";
            this.tutorLastNameLabel.Size = new System.Drawing.Size(76, 17);
            this.tutorLastNameLabel.TabIndex = 3;
            this.tutorLastNameLabel.Text = "Last Name";
            // 
            // tutorFirstNameTextbox
            // 
            this.tutorFirstNameTextbox.Location = new System.Drawing.Point(132, 42);
            this.tutorFirstNameTextbox.Name = "tutorFirstNameTextbox";
            this.tutorFirstNameTextbox.Size = new System.Drawing.Size(176, 23);
            this.tutorFirstNameTextbox.TabIndex = 2;
            // 
            // tutorFirstNameLabel
            // 
            this.tutorFirstNameLabel.AutoSize = true;
            this.tutorFirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorFirstNameLabel.Location = new System.Drawing.Point(53, 45);
            this.tutorFirstNameLabel.Name = "tutorFirstNameLabel";
            this.tutorFirstNameLabel.Size = new System.Drawing.Size(76, 17);
            this.tutorFirstNameLabel.TabIndex = 1;
            this.tutorFirstNameLabel.Text = "First Name";
            // 
            // addUpdateTutorLabel
            // 
            this.addUpdateTutorLabel.AutoSize = true;
            this.addUpdateTutorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUpdateTutorLabel.Location = new System.Drawing.Point(4, 4);
            this.addUpdateTutorLabel.Name = "addUpdateTutorLabel";
            this.addUpdateTutorLabel.Size = new System.Drawing.Size(152, 20);
            this.addUpdateTutorLabel.TabIndex = 0;
            this.addUpdateTutorLabel.Text = "Add/Update Tutor";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.sheetMusicRecordPanel);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(992, 577);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sheet Music Records";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.showRecordsByBtn);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.showRecordsByLabel);
            this.panel3.Controls.Add(this.editSheetMusicRecordBtn);
            this.panel3.Controls.Add(this.editSheetMusicRecordLabel);
            this.panel3.Controls.Add(this.editSheetMusicRecordDropdown);
            this.panel3.Controls.Add(this.sheetMusicRecordsListbox);
            this.panel3.Controls.Add(this.showSheetMusicRecordsLabel);
            this.panel3.Location = new System.Drawing.Point(430, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(559, 545);
            this.panel3.TabIndex = 4;
            // 
            // showRecordsByBtn
            // 
            this.showRecordsByBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showRecordsByBtn.Location = new System.Drawing.Point(403, 39);
            this.showRecordsByBtn.Name = "showRecordsByBtn";
            this.showRecordsByBtn.Size = new System.Drawing.Size(149, 30);
            this.showRecordsByBtn.TabIndex = 9;
            this.showRecordsByBtn.Text = "Show Records";
            this.showRecordsByBtn.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "Age",
            "Level",
            "Suburb",
            "Town/City"});
            this.comboBox2.Location = new System.Drawing.Point(403, 7);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(149, 24);
            this.comboBox2.TabIndex = 7;
            // 
            // showRecordsByLabel
            // 
            this.showRecordsByLabel.AutoSize = true;
            this.showRecordsByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showRecordsByLabel.Location = new System.Drawing.Point(282, 11);
            this.showRecordsByLabel.Name = "showRecordsByLabel";
            this.showRecordsByLabel.Size = new System.Drawing.Size(119, 17);
            this.showRecordsByLabel.TabIndex = 6;
            this.showRecordsByLabel.Text = "Show Records By";
            // 
            // editSheetMusicRecordBtn
            // 
            this.editSheetMusicRecordBtn.Location = new System.Drawing.Point(338, 463);
            this.editSheetMusicRecordBtn.Name = "editSheetMusicRecordBtn";
            this.editSheetMusicRecordBtn.Size = new System.Drawing.Size(75, 26);
            this.editSheetMusicRecordBtn.TabIndex = 5;
            this.editSheetMusicRecordBtn.Text = "Go";
            this.editSheetMusicRecordBtn.UseVisualStyleBackColor = true;
            // 
            // editSheetMusicRecordLabel
            // 
            this.editSheetMusicRecordLabel.AutoSize = true;
            this.editSheetMusicRecordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editSheetMusicRecordLabel.Location = new System.Drawing.Point(129, 466);
            this.editSheetMusicRecordLabel.Name = "editSheetMusicRecordLabel";
            this.editSheetMusicRecordLabel.Size = new System.Drawing.Size(207, 20);
            this.editSheetMusicRecordLabel.TabIndex = 4;
            this.editSheetMusicRecordLabel.Text = "selected sheet music record";
            // 
            // editSheetMusicRecordDropdown
            // 
            this.editSheetMusicRecordDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editSheetMusicRecordDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editSheetMusicRecordDropdown.FormattingEnabled = true;
            this.editSheetMusicRecordDropdown.Items.AddRange(new object[] {
            "Edit/Update",
            "Delete"});
            this.editSheetMusicRecordDropdown.Location = new System.Drawing.Point(5, 464);
            this.editSheetMusicRecordDropdown.Name = "editSheetMusicRecordDropdown";
            this.editSheetMusicRecordDropdown.Size = new System.Drawing.Size(121, 24);
            this.editSheetMusicRecordDropdown.TabIndex = 3;
            // 
            // sheetMusicRecordsListbox
            // 
            this.sheetMusicRecordsListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sheetMusicRecordsListbox.FormattingEnabled = true;
            this.sheetMusicRecordsListbox.ItemHeight = 16;
            this.sheetMusicRecordsListbox.Location = new System.Drawing.Point(5, 105);
            this.sheetMusicRecordsListbox.Name = "sheetMusicRecordsListbox";
            this.sheetMusicRecordsListbox.Size = new System.Drawing.Size(575, 340);
            this.sheetMusicRecordsListbox.TabIndex = 2;
            // 
            // showSheetMusicRecordsLabel
            // 
            this.showSheetMusicRecordsLabel.AutoSize = true;
            this.showSheetMusicRecordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showSheetMusicRecordsLabel.Location = new System.Drawing.Point(4, 4);
            this.showSheetMusicRecordsLabel.Name = "showSheetMusicRecordsLabel";
            this.showSheetMusicRecordsLabel.Size = new System.Drawing.Size(229, 20);
            this.showSheetMusicRecordsLabel.TabIndex = 0;
            this.showSheetMusicRecordsLabel.Text = "Show Sheet Music Records";
            // 
            // sheetMusicRecordPanel
            // 
            this.sheetMusicRecordPanel.Controls.Add(this.sheetMusicSubmitBtn);
            this.sheetMusicRecordPanel.Controls.Add(this.sheetMusicAuthCopiesTextbox);
            this.sheetMusicRecordPanel.Controls.Add(this.sheetMusicAuthCopiesLabel);
            this.sheetMusicRecordPanel.Controls.Add(this.sheetMusicDifficultyDropdown);
            this.sheetMusicRecordPanel.Controls.Add(this.sheetMusicDifficultyLabel);
            this.sheetMusicRecordPanel.Controls.Add(this.sheetMusicComposerTextbox);
            this.sheetMusicRecordPanel.Controls.Add(this.sheetMusicComposerLabel);
            this.sheetMusicRecordPanel.Controls.Add(this.sheetMusicTitleTextbox);
            this.sheetMusicRecordPanel.Controls.Add(this.sheetMusicTitleLabel);
            this.sheetMusicRecordPanel.Controls.Add(this.addUpdateSheetMusicLabel);
            this.sheetMusicRecordPanel.Location = new System.Drawing.Point(19, 21);
            this.sheetMusicRecordPanel.Name = "sheetMusicRecordPanel";
            this.sheetMusicRecordPanel.Size = new System.Drawing.Size(405, 545);
            this.sheetMusicRecordPanel.TabIndex = 0;
            // 
            // sheetMusicSubmitBtn
            // 
            this.sheetMusicSubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sheetMusicSubmitBtn.Location = new System.Drawing.Point(279, 192);
            this.sheetMusicSubmitBtn.Name = "sheetMusicSubmitBtn";
            this.sheetMusicSubmitBtn.Size = new System.Drawing.Size(116, 26);
            this.sheetMusicSubmitBtn.TabIndex = 12;
            this.sheetMusicSubmitBtn.Text = "Submit/Update";
            this.sheetMusicSubmitBtn.UseVisualStyleBackColor = true;
            // 
            // sheetMusicAuthCopiesTextbox
            // 
            this.sheetMusicAuthCopiesTextbox.Location = new System.Drawing.Point(172, 154);
            this.sheetMusicAuthCopiesTextbox.Name = "sheetMusicAuthCopiesTextbox";
            this.sheetMusicAuthCopiesTextbox.Size = new System.Drawing.Size(121, 23);
            this.sheetMusicAuthCopiesTextbox.TabIndex = 11;
            // 
            // sheetMusicAuthCopiesLabel
            // 
            this.sheetMusicAuthCopiesLabel.AutoSize = true;
            this.sheetMusicAuthCopiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sheetMusicAuthCopiesLabel.Location = new System.Drawing.Point(4, 156);
            this.sheetMusicAuthCopiesLabel.Name = "sheetMusicAuthCopiesLabel";
            this.sheetMusicAuthCopiesLabel.Size = new System.Drawing.Size(165, 17);
            this.sheetMusicAuthCopiesLabel.TabIndex = 10;
            this.sheetMusicAuthCopiesLabel.Text = "No. of Authorised Copies";
            // 
            // sheetMusicDifficultyDropdown
            // 
            this.sheetMusicDifficultyDropdown.FormattingEnabled = true;
            this.sheetMusicDifficultyDropdown.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.sheetMusicDifficultyDropdown.Location = new System.Drawing.Point(172, 119);
            this.sheetMusicDifficultyDropdown.Name = "sheetMusicDifficultyDropdown";
            this.sheetMusicDifficultyDropdown.Size = new System.Drawing.Size(121, 24);
            this.sheetMusicDifficultyDropdown.TabIndex = 9;
            // 
            // sheetMusicDifficultyLabel
            // 
            this.sheetMusicDifficultyLabel.AutoSize = true;
            this.sheetMusicDifficultyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sheetMusicDifficultyLabel.Location = new System.Drawing.Point(70, 122);
            this.sheetMusicDifficultyLabel.Name = "sheetMusicDifficultyLabel";
            this.sheetMusicDifficultyLabel.Size = new System.Drawing.Size(99, 17);
            this.sheetMusicDifficultyLabel.TabIndex = 8;
            this.sheetMusicDifficultyLabel.Text = "Difficulty Level";
            // 
            // sheetMusicComposerTextbox
            // 
            this.sheetMusicComposerTextbox.Location = new System.Drawing.Point(172, 84);
            this.sheetMusicComposerTextbox.Name = "sheetMusicComposerTextbox";
            this.sheetMusicComposerTextbox.Size = new System.Drawing.Size(223, 23);
            this.sheetMusicComposerTextbox.TabIndex = 4;
            // 
            // sheetMusicComposerLabel
            // 
            this.sheetMusicComposerLabel.AutoSize = true;
            this.sheetMusicComposerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sheetMusicComposerLabel.Location = new System.Drawing.Point(97, 87);
            this.sheetMusicComposerLabel.Name = "sheetMusicComposerLabel";
            this.sheetMusicComposerLabel.Size = new System.Drawing.Size(72, 17);
            this.sheetMusicComposerLabel.TabIndex = 3;
            this.sheetMusicComposerLabel.Text = "Composer";
            // 
            // sheetMusicTitleTextbox
            // 
            this.sheetMusicTitleTextbox.Location = new System.Drawing.Point(172, 49);
            this.sheetMusicTitleTextbox.Name = "sheetMusicTitleTextbox";
            this.sheetMusicTitleTextbox.Size = new System.Drawing.Size(223, 23);
            this.sheetMusicTitleTextbox.TabIndex = 2;
            // 
            // sheetMusicTitleLabel
            // 
            this.sheetMusicTitleLabel.AutoSize = true;
            this.sheetMusicTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sheetMusicTitleLabel.Location = new System.Drawing.Point(134, 52);
            this.sheetMusicTitleLabel.Name = "sheetMusicTitleLabel";
            this.sheetMusicTitleLabel.Size = new System.Drawing.Size(35, 17);
            this.sheetMusicTitleLabel.TabIndex = 1;
            this.sheetMusicTitleLabel.Text = "Title";
            // 
            // addUpdateSheetMusicLabel
            // 
            this.addUpdateSheetMusicLabel.AutoSize = true;
            this.addUpdateSheetMusicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUpdateSheetMusicLabel.Location = new System.Drawing.Point(8, 9);
            this.addUpdateSheetMusicLabel.Name = "addUpdateSheetMusicLabel";
            this.addUpdateSheetMusicLabel.Size = new System.Drawing.Size(281, 20);
            this.addUpdateSheetMusicLabel.TabIndex = 0;
            this.addUpdateSheetMusicLabel.Text = "Add/Update Sheet Music Records";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel4);
            this.tabPage4.Controls.Add(this.panel5);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(992, 577);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Instrument Records";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.comboBox4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.editInstrumentBtn);
            this.panel4.Controls.Add(this.editInstrumentLabel);
            this.panel4.Controls.Add(this.editInstrumentDropdown);
            this.panel4.Controls.Add(this.instrumentListbox);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(429, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(559, 545);
            this.panel4.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(403, 39);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 30);
            this.button4.TabIndex = 9;
            this.button4.Text = "Show Instruments";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Instrument Name",
            "Size",
            "Instrument Fee",
            "Instrument Status",
            "Instrument Condition"});
            this.comboBox4.Location = new System.Drawing.Point(403, 7);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(149, 24);
            this.comboBox4.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(262, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Show Instruments By";
            // 
            // editInstrumentBtn
            // 
            this.editInstrumentBtn.Location = new System.Drawing.Point(328, 463);
            this.editInstrumentBtn.Name = "editInstrumentBtn";
            this.editInstrumentBtn.Size = new System.Drawing.Size(75, 26);
            this.editInstrumentBtn.TabIndex = 5;
            this.editInstrumentBtn.Text = "Go";
            this.editInstrumentBtn.UseVisualStyleBackColor = true;
            // 
            // editInstrumentLabel
            // 
            this.editInstrumentLabel.AutoSize = true;
            this.editInstrumentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editInstrumentLabel.Location = new System.Drawing.Point(129, 466);
            this.editInstrumentLabel.Name = "editInstrumentLabel";
            this.editInstrumentLabel.Size = new System.Drawing.Size(197, 20);
            this.editInstrumentLabel.TabIndex = 4;
            this.editInstrumentLabel.Text = "selected instrument record";
            // 
            // editInstrumentDropdown
            // 
            this.editInstrumentDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editInstrumentDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editInstrumentDropdown.FormattingEnabled = true;
            this.editInstrumentDropdown.Items.AddRange(new object[] {
            "Edit/Update",
            "Delete"});
            this.editInstrumentDropdown.Location = new System.Drawing.Point(5, 464);
            this.editInstrumentDropdown.Name = "editInstrumentDropdown";
            this.editInstrumentDropdown.Size = new System.Drawing.Size(121, 24);
            this.editInstrumentDropdown.TabIndex = 3;
            // 
            // instrumentListbox
            // 
            this.instrumentListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instrumentListbox.FormattingEnabled = true;
            this.instrumentListbox.ItemHeight = 16;
            this.instrumentListbox.Location = new System.Drawing.Point(5, 105);
            this.instrumentListbox.Name = "instrumentListbox";
            this.instrumentListbox.Size = new System.Drawing.Size(575, 340);
            this.instrumentListbox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Show Instrument Records";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.instrumentConditionDropdown);
            this.panel5.Controls.Add(this.instrumentStatusDropdown);
            this.panel5.Controls.Add(this.instrumentFeeTextbox);
            this.panel5.Controls.Add(this.button7);
            this.panel5.Controls.Add(this.instrumentAuthCopiesTextbox);
            this.panel5.Controls.Add(this.instrumentAuthCopiesLabel);
            this.panel5.Controls.Add(this.instrumentConditionLabel);
            this.panel5.Controls.Add(this.instrumentStatusLabel);
            this.panel5.Controls.Add(this.instrumentFeeLabel);
            this.panel5.Controls.Add(this.instrumentSizeTextbox);
            this.panel5.Controls.Add(this.instrumentSizeLabel);
            this.panel5.Controls.Add(this.nameOfInstrumentTextbox);
            this.panel5.Controls.Add(this.nameOfInstrumentLabel);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Location = new System.Drawing.Point(17, 21);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(405, 545);
            this.panel5.TabIndex = 5;
            // 
            // instrumentConditionDropdown
            // 
            this.instrumentConditionDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.instrumentConditionDropdown.FormattingEnabled = true;
            this.instrumentConditionDropdown.Items.AddRange(new object[] {
            "Ok for use",
            "Needs repaired",
            "Has been repaired",
            "N/A"});
            this.instrumentConditionDropdown.Location = new System.Drawing.Point(172, 194);
            this.instrumentConditionDropdown.Name = "instrumentConditionDropdown";
            this.instrumentConditionDropdown.Size = new System.Drawing.Size(223, 24);
            this.instrumentConditionDropdown.TabIndex = 14;
            // 
            // instrumentStatusDropdown
            // 
            this.instrumentStatusDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.instrumentStatusDropdown.FormattingEnabled = true;
            this.instrumentStatusDropdown.Items.AddRange(new object[] {
            "Brand new, never used before",
            "Ok for use",
            "Mild wear and tear",
            "Significant wear and tear",
            "Is unusable",
            "N/A"});
            this.instrumentStatusDropdown.Location = new System.Drawing.Point(172, 159);
            this.instrumentStatusDropdown.Name = "instrumentStatusDropdown";
            this.instrumentStatusDropdown.Size = new System.Drawing.Size(223, 24);
            this.instrumentStatusDropdown.TabIndex = 14;
            // 
            // instrumentFeeTextbox
            // 
            this.instrumentFeeTextbox.Location = new System.Drawing.Point(172, 121);
            this.instrumentFeeTextbox.Name = "instrumentFeeTextbox";
            this.instrumentFeeTextbox.Size = new System.Drawing.Size(100, 23);
            this.instrumentFeeTextbox.TabIndex = 13;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(279, 266);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(116, 26);
            this.button7.TabIndex = 12;
            this.button7.Text = "Submit/Update";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // instrumentAuthCopiesTextbox
            // 
            this.instrumentAuthCopiesTextbox.Location = new System.Drawing.Point(172, 228);
            this.instrumentAuthCopiesTextbox.Name = "instrumentAuthCopiesTextbox";
            this.instrumentAuthCopiesTextbox.Size = new System.Drawing.Size(121, 23);
            this.instrumentAuthCopiesTextbox.TabIndex = 11;
            // 
            // instrumentAuthCopiesLabel
            // 
            this.instrumentAuthCopiesLabel.AutoSize = true;
            this.instrumentAuthCopiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instrumentAuthCopiesLabel.Location = new System.Drawing.Point(4, 230);
            this.instrumentAuthCopiesLabel.Name = "instrumentAuthCopiesLabel";
            this.instrumentAuthCopiesLabel.Size = new System.Drawing.Size(165, 17);
            this.instrumentAuthCopiesLabel.TabIndex = 10;
            this.instrumentAuthCopiesLabel.Text = "No. of Authorised Copies";
            // 
            // instrumentConditionLabel
            // 
            this.instrumentConditionLabel.AutoSize = true;
            this.instrumentConditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instrumentConditionLabel.Location = new System.Drawing.Point(33, 197);
            this.instrumentConditionLabel.Name = "instrumentConditionLabel";
            this.instrumentConditionLabel.Size = new System.Drawing.Size(137, 17);
            this.instrumentConditionLabel.TabIndex = 8;
            this.instrumentConditionLabel.Text = "Instrument Condition";
            // 
            // instrumentStatusLabel
            // 
            this.instrumentStatusLabel.AutoSize = true;
            this.instrumentStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instrumentStatusLabel.Location = new System.Drawing.Point(52, 164);
            this.instrumentStatusLabel.Name = "instrumentStatusLabel";
            this.instrumentStatusLabel.Size = new System.Drawing.Size(118, 17);
            this.instrumentStatusLabel.TabIndex = 8;
            this.instrumentStatusLabel.Text = "Instrument Status";
            // 
            // instrumentFeeLabel
            // 
            this.instrumentFeeLabel.AutoSize = true;
            this.instrumentFeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instrumentFeeLabel.Location = new System.Drawing.Point(67, 124);
            this.instrumentFeeLabel.Name = "instrumentFeeLabel";
            this.instrumentFeeLabel.Size = new System.Drawing.Size(102, 17);
            this.instrumentFeeLabel.TabIndex = 5;
            this.instrumentFeeLabel.Text = "Instrument Fee";
            // 
            // instrumentSizeTextbox
            // 
            this.instrumentSizeTextbox.Location = new System.Drawing.Point(172, 84);
            this.instrumentSizeTextbox.Name = "instrumentSizeTextbox";
            this.instrumentSizeTextbox.Size = new System.Drawing.Size(223, 23);
            this.instrumentSizeTextbox.TabIndex = 4;
            // 
            // instrumentSizeLabel
            // 
            this.instrumentSizeLabel.AutoSize = true;
            this.instrumentSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instrumentSizeLabel.Location = new System.Drawing.Point(134, 87);
            this.instrumentSizeLabel.Name = "instrumentSizeLabel";
            this.instrumentSizeLabel.Size = new System.Drawing.Size(35, 17);
            this.instrumentSizeLabel.TabIndex = 3;
            this.instrumentSizeLabel.Text = "Size";
            // 
            // nameOfInstrumentTextbox
            // 
            this.nameOfInstrumentTextbox.Location = new System.Drawing.Point(172, 49);
            this.nameOfInstrumentTextbox.Name = "nameOfInstrumentTextbox";
            this.nameOfInstrumentTextbox.Size = new System.Drawing.Size(223, 23);
            this.nameOfInstrumentTextbox.TabIndex = 2;
            // 
            // nameOfInstrumentLabel
            // 
            this.nameOfInstrumentLabel.AutoSize = true;
            this.nameOfInstrumentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOfInstrumentLabel.Location = new System.Drawing.Point(39, 52);
            this.nameOfInstrumentLabel.Name = "nameOfInstrumentLabel";
            this.nameOfInstrumentLabel.Size = new System.Drawing.Size(131, 17);
            this.nameOfInstrumentLabel.TabIndex = 1;
            this.nameOfInstrumentLabel.Text = "Name of Instrument";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(269, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Add/Update Instrument Records";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.showPerformanceRecordsPanel);
            this.tabPage5.Controls.Add(this.addUpdatePerformancesPanel);
            this.tabPage5.Location = new System.Drawing.Point(4, 34);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(992, 577);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Performance Records";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // showPerformanceRecordsPanel
            // 
            this.showPerformanceRecordsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.showPerformanceRecordsPanel.Controls.Add(this.showPerformancesBtn);
            this.showPerformanceRecordsPanel.Controls.Add(this.showPerformancesByDropdown);
            this.showPerformanceRecordsPanel.Controls.Add(this.showPerformancesByLabel);
            this.showPerformanceRecordsPanel.Controls.Add(this.editUpdatePerformanceBtn);
            this.showPerformanceRecordsPanel.Controls.Add(this.editUpdatePerformanceLabel);
            this.showPerformanceRecordsPanel.Controls.Add(this.editUpdatePerformanceDropdown);
            this.showPerformanceRecordsPanel.Controls.Add(this.listBox1);
            this.showPerformanceRecordsPanel.Controls.Add(this.showPerformanceRecordsLabel);
            this.showPerformanceRecordsPanel.Location = new System.Drawing.Point(428, 21);
            this.showPerformanceRecordsPanel.Name = "showPerformanceRecordsPanel";
            this.showPerformanceRecordsPanel.Size = new System.Drawing.Size(559, 545);
            this.showPerformanceRecordsPanel.TabIndex = 7;
            // 
            // showPerformancesBtn
            // 
            this.showPerformancesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPerformancesBtn.Location = new System.Drawing.Point(403, 39);
            this.showPerformancesBtn.Name = "showPerformancesBtn";
            this.showPerformancesBtn.Size = new System.Drawing.Size(149, 30);
            this.showPerformancesBtn.TabIndex = 9;
            this.showPerformancesBtn.Text = "Show Performances";
            this.showPerformancesBtn.UseVisualStyleBackColor = true;
            // 
            // showPerformancesByDropdown
            // 
            this.showPerformancesByDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.showPerformancesByDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPerformancesByDropdown.FormattingEnabled = true;
            this.showPerformancesByDropdown.Items.AddRange(new object[] {
            "Performance Venue",
            "Performance Name",
            "Date of Performance",
            "Time Started",
            "Time Finished",
            "No. of Adult Attendees",
            "No. of Children Under 5 Attended",
            "No. of Children 5 to 17 Attended",
            "No. of Students Attended",
            "No. of Beneficiaries Attended",
            "Total Attendees",
            "Total Revenue"});
            this.showPerformancesByDropdown.Location = new System.Drawing.Point(403, 7);
            this.showPerformancesByDropdown.Name = "showPerformancesByDropdown";
            this.showPerformancesByDropdown.Size = new System.Drawing.Size(149, 24);
            this.showPerformancesByDropdown.TabIndex = 7;
            // 
            // showPerformancesByLabel
            // 
            this.showPerformancesByLabel.AutoSize = true;
            this.showPerformancesByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPerformancesByLabel.Location = new System.Drawing.Point(247, 10);
            this.showPerformancesByLabel.Name = "showPerformancesByLabel";
            this.showPerformancesByLabel.Size = new System.Drawing.Size(154, 17);
            this.showPerformancesByLabel.TabIndex = 6;
            this.showPerformancesByLabel.Text = "Show Performances By";
            // 
            // editUpdatePerformanceBtn
            // 
            this.editUpdatePerformanceBtn.Location = new System.Drawing.Point(343, 463);
            this.editUpdatePerformanceBtn.Name = "editUpdatePerformanceBtn";
            this.editUpdatePerformanceBtn.Size = new System.Drawing.Size(75, 26);
            this.editUpdatePerformanceBtn.TabIndex = 5;
            this.editUpdatePerformanceBtn.Text = "Go";
            this.editUpdatePerformanceBtn.UseVisualStyleBackColor = true;
            // 
            // editUpdatePerformanceLabel
            // 
            this.editUpdatePerformanceLabel.AutoSize = true;
            this.editUpdatePerformanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editUpdatePerformanceLabel.Location = new System.Drawing.Point(129, 466);
            this.editUpdatePerformanceLabel.Name = "editUpdatePerformanceLabel";
            this.editUpdatePerformanceLabel.Size = new System.Drawing.Size(212, 20);
            this.editUpdatePerformanceLabel.TabIndex = 4;
            this.editUpdatePerformanceLabel.Text = "selected performance record";
            // 
            // editUpdatePerformanceDropdown
            // 
            this.editUpdatePerformanceDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editUpdatePerformanceDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editUpdatePerformanceDropdown.FormattingEnabled = true;
            this.editUpdatePerformanceDropdown.Items.AddRange(new object[] {
            "Edit/Update",
            "Delete"});
            this.editUpdatePerformanceDropdown.Location = new System.Drawing.Point(5, 464);
            this.editUpdatePerformanceDropdown.Name = "editUpdatePerformanceDropdown";
            this.editUpdatePerformanceDropdown.Size = new System.Drawing.Size(121, 24);
            this.editUpdatePerformanceDropdown.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(5, 105);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(575, 340);
            this.listBox1.TabIndex = 2;
            // 
            // showPerformanceRecordsLabel
            // 
            this.showPerformanceRecordsLabel.AutoSize = true;
            this.showPerformanceRecordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPerformanceRecordsLabel.Location = new System.Drawing.Point(4, 4);
            this.showPerformanceRecordsLabel.Name = "showPerformanceRecordsLabel";
            this.showPerformanceRecordsLabel.Size = new System.Drawing.Size(232, 20);
            this.showPerformanceRecordsLabel.TabIndex = 0;
            this.showPerformanceRecordsLabel.Text = "Show Performance Records";
            // 
            // addUpdatePerformancesPanel
            // 
            this.addUpdatePerformancesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addUpdatePerformancesPanel.Controls.Add(this.totalRevenueLabel);
            this.addUpdatePerformancesPanel.Controls.Add(this.totalAttendeesLabel);
            this.addUpdatePerformancesPanel.Controls.Add(this.totalRevenueTextbox);
            this.addUpdatePerformancesPanel.Controls.Add(this.beneficiaryPriceTextbox);
            this.addUpdatePerformancesPanel.Controls.Add(this.totalAttendeesTextbox);
            this.addUpdatePerformancesPanel.Controls.Add(this.studentPriceTextbox);
            this.addUpdatePerformancesPanel.Controls.Add(this.beneficiaryAttendeesAmtTextbox);
            this.addUpdatePerformancesPanel.Controls.Add(this.child5to17AttendeesAmtTextbox);
            this.addUpdatePerformancesPanel.Controls.Add(this.child5to17textbox);
            this.addUpdatePerformancesPanel.Controls.Add(this.studentAttendeesAmtTextbox);
            this.addUpdatePerformancesPanel.Controls.Add(this.childUnder5AttendeesAmtTextbox);
            this.addUpdatePerformancesPanel.Controls.Add(this.childUnder5Textbox);
            this.addUpdatePerformancesPanel.Controls.Add(this.adultAttendeesAmtTextbox);
            this.addUpdatePerformancesPanel.Controls.Add(this.adultPriceTextbox);
            this.addUpdatePerformancesPanel.Controls.Add(this.totalsLabel);
            this.addUpdatePerformancesPanel.Controls.Add(this.beneficiaryPriceLabel);
            this.addUpdatePerformancesPanel.Controls.Add(this.studentPriceLabel);
            this.addUpdatePerformancesPanel.Controls.Add(this.child5to17label);
            this.addUpdatePerformancesPanel.Controls.Add(this.childUnder5Label);
            this.addUpdatePerformancesPanel.Controls.Add(this.adultPriceLabel);
            this.addUpdatePerformancesPanel.Controls.Add(this.noOfAttendeesLabel);
            this.addUpdatePerformancesPanel.Controls.Add(this.ticketPricesLabel);
            this.addUpdatePerformancesPanel.Controls.Add(this.label13);
            this.addUpdatePerformancesPanel.Controls.Add(this.label14);
            this.addUpdatePerformancesPanel.Controls.Add(this.label8);
            this.addUpdatePerformancesPanel.Controls.Add(this.performanceTimeFinishedLabel);
            this.addUpdatePerformancesPanel.Controls.Add(this.performanceTimeStartedLabel);
            this.addUpdatePerformancesPanel.Controls.Add(this.submitUpdatePerformancesBtn);
            this.addUpdatePerformancesPanel.Controls.Add(this.performanceTimeFinishedTextbox);
            this.addUpdatePerformancesPanel.Controls.Add(this.performanceDateLabel);
            this.addUpdatePerformancesPanel.Controls.Add(this.performanceTimeStartedTextbox);
            this.addUpdatePerformancesPanel.Controls.Add(this.performanceDateTextbox);
            this.addUpdatePerformancesPanel.Controls.Add(this.performanceNameTextboz);
            this.addUpdatePerformancesPanel.Controls.Add(this.performanceVenueTextbox);
            this.addUpdatePerformancesPanel.Controls.Add(this.performanceNameLabel);
            this.addUpdatePerformancesPanel.Controls.Add(this.performanceVenueLabel);
            this.addUpdatePerformancesPanel.Controls.Add(this.label12);
            this.addUpdatePerformancesPanel.Location = new System.Drawing.Point(17, 21);
            this.addUpdatePerformancesPanel.Name = "addUpdatePerformancesPanel";
            this.addUpdatePerformancesPanel.Size = new System.Drawing.Size(405, 545);
            this.addUpdatePerformancesPanel.TabIndex = 6;
            // 
            // totalRevenueLabel
            // 
            this.totalRevenueLabel.AutoSize = true;
            this.totalRevenueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRevenueLabel.Location = new System.Drawing.Point(11, 496);
            this.totalRevenueLabel.Name = "totalRevenueLabel";
            this.totalRevenueLabel.Size = new System.Drawing.Size(101, 17);
            this.totalRevenueLabel.TabIndex = 17;
            this.totalRevenueLabel.Text = "Total Revenue";
            // 
            // totalAttendeesLabel
            // 
            this.totalAttendeesLabel.AutoSize = true;
            this.totalAttendeesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAttendeesLabel.Location = new System.Drawing.Point(5, 465);
            this.totalAttendeesLabel.Name = "totalAttendeesLabel";
            this.totalAttendeesLabel.Size = new System.Drawing.Size(108, 17);
            this.totalAttendeesLabel.TabIndex = 17;
            this.totalAttendeesLabel.Text = "Total Attendees";
            // 
            // totalRevenueTextbox
            // 
            this.totalRevenueTextbox.Location = new System.Drawing.Point(116, 494);
            this.totalRevenueTextbox.Name = "totalRevenueTextbox";
            this.totalRevenueTextbox.ReadOnly = true;
            this.totalRevenueTextbox.Size = new System.Drawing.Size(100, 23);
            this.totalRevenueTextbox.TabIndex = 16;
            // 
            // beneficiaryPriceTextbox
            // 
            this.beneficiaryPriceTextbox.Location = new System.Drawing.Point(106, 402);
            this.beneficiaryPriceTextbox.Name = "beneficiaryPriceTextbox";
            this.beneficiaryPriceTextbox.Size = new System.Drawing.Size(100, 23);
            this.beneficiaryPriceTextbox.TabIndex = 16;
            // 
            // totalAttendeesTextbox
            // 
            this.totalAttendeesTextbox.Location = new System.Drawing.Point(116, 463);
            this.totalAttendeesTextbox.Name = "totalAttendeesTextbox";
            this.totalAttendeesTextbox.ReadOnly = true;
            this.totalAttendeesTextbox.Size = new System.Drawing.Size(100, 23);
            this.totalAttendeesTextbox.TabIndex = 16;
            // 
            // studentPriceTextbox
            // 
            this.studentPriceTextbox.Location = new System.Drawing.Point(106, 371);
            this.studentPriceTextbox.Name = "studentPriceTextbox";
            this.studentPriceTextbox.Size = new System.Drawing.Size(100, 23);
            this.studentPriceTextbox.TabIndex = 16;
            // 
            // beneficiaryAttendeesAmtTextbox
            // 
            this.beneficiaryAttendeesAmtTextbox.Location = new System.Drawing.Point(248, 403);
            this.beneficiaryAttendeesAmtTextbox.Name = "beneficiaryAttendeesAmtTextbox";
            this.beneficiaryAttendeesAmtTextbox.Size = new System.Drawing.Size(100, 23);
            this.beneficiaryAttendeesAmtTextbox.TabIndex = 16;
            // 
            // child5to17AttendeesAmtTextbox
            // 
            this.child5to17AttendeesAmtTextbox.Location = new System.Drawing.Point(248, 339);
            this.child5to17AttendeesAmtTextbox.Name = "child5to17AttendeesAmtTextbox";
            this.child5to17AttendeesAmtTextbox.Size = new System.Drawing.Size(100, 23);
            this.child5to17AttendeesAmtTextbox.TabIndex = 16;
            // 
            // child5to17textbox
            // 
            this.child5to17textbox.Location = new System.Drawing.Point(106, 339);
            this.child5to17textbox.Name = "child5to17textbox";
            this.child5to17textbox.Size = new System.Drawing.Size(100, 23);
            this.child5to17textbox.TabIndex = 16;
            // 
            // studentAttendeesAmtTextbox
            // 
            this.studentAttendeesAmtTextbox.Location = new System.Drawing.Point(248, 371);
            this.studentAttendeesAmtTextbox.Name = "studentAttendeesAmtTextbox";
            this.studentAttendeesAmtTextbox.Size = new System.Drawing.Size(100, 23);
            this.studentAttendeesAmtTextbox.TabIndex = 16;
            // 
            // childUnder5AttendeesAmtTextbox
            // 
            this.childUnder5AttendeesAmtTextbox.Location = new System.Drawing.Point(248, 307);
            this.childUnder5AttendeesAmtTextbox.Name = "childUnder5AttendeesAmtTextbox";
            this.childUnder5AttendeesAmtTextbox.Size = new System.Drawing.Size(100, 23);
            this.childUnder5AttendeesAmtTextbox.TabIndex = 16;
            // 
            // childUnder5Textbox
            // 
            this.childUnder5Textbox.Location = new System.Drawing.Point(106, 307);
            this.childUnder5Textbox.Name = "childUnder5Textbox";
            this.childUnder5Textbox.Size = new System.Drawing.Size(100, 23);
            this.childUnder5Textbox.TabIndex = 16;
            // 
            // adultAttendeesAmtTextbox
            // 
            this.adultAttendeesAmtTextbox.Location = new System.Drawing.Point(248, 274);
            this.adultAttendeesAmtTextbox.Name = "adultAttendeesAmtTextbox";
            this.adultAttendeesAmtTextbox.Size = new System.Drawing.Size(100, 23);
            this.adultAttendeesAmtTextbox.TabIndex = 16;
            // 
            // adultPriceTextbox
            // 
            this.adultPriceTextbox.Location = new System.Drawing.Point(106, 274);
            this.adultPriceTextbox.Name = "adultPriceTextbox";
            this.adultPriceTextbox.Size = new System.Drawing.Size(100, 23);
            this.adultPriceTextbox.TabIndex = 16;
            // 
            // totalsLabel
            // 
            this.totalsLabel.AutoSize = true;
            this.totalsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalsLabel.Location = new System.Drawing.Point(44, 440);
            this.totalsLabel.Name = "totalsLabel";
            this.totalsLabel.Size = new System.Drawing.Size(69, 17);
            this.totalsLabel.TabIndex = 15;
            this.totalsLabel.Text = "TOTALS";
            // 
            // beneficiaryPriceLabel
            // 
            this.beneficiaryPriceLabel.AutoSize = true;
            this.beneficiaryPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beneficiaryPriceLabel.Location = new System.Drawing.Point(18, 405);
            this.beneficiaryPriceLabel.Name = "beneficiaryPriceLabel";
            this.beneficiaryPriceLabel.Size = new System.Drawing.Size(78, 17);
            this.beneficiaryPriceLabel.TabIndex = 15;
            this.beneficiaryPriceLabel.Text = "Beneficiary";
            // 
            // studentPriceLabel
            // 
            this.studentPriceLabel.AutoSize = true;
            this.studentPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentPriceLabel.Location = new System.Drawing.Point(39, 374);
            this.studentPriceLabel.Name = "studentPriceLabel";
            this.studentPriceLabel.Size = new System.Drawing.Size(57, 17);
            this.studentPriceLabel.TabIndex = 15;
            this.studentPriceLabel.Text = "Student";
            // 
            // child5to17label
            // 
            this.child5to17label.AutoSize = true;
            this.child5to17label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.child5to17label.Location = new System.Drawing.Point(9, 342);
            this.child5to17label.Name = "child5to17label";
            this.child5to17label.Size = new System.Drawing.Size(87, 17);
            this.child5to17label.TabIndex = 15;
            this.child5to17label.Text = "Child 5 to 17";
            // 
            // childUnder5Label
            // 
            this.childUnder5Label.AutoSize = true;
            this.childUnder5Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.childUnder5Label.Location = new System.Drawing.Point(4, 310);
            this.childUnder5Label.Name = "childUnder5Label";
            this.childUnder5Label.Size = new System.Drawing.Size(92, 17);
            this.childUnder5Label.TabIndex = 15;
            this.childUnder5Label.Text = "Child under 5";
            // 
            // adultPriceLabel
            // 
            this.adultPriceLabel.AutoSize = true;
            this.adultPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adultPriceLabel.Location = new System.Drawing.Point(56, 277);
            this.adultPriceLabel.Name = "adultPriceLabel";
            this.adultPriceLabel.Size = new System.Drawing.Size(40, 17);
            this.adultPriceLabel.TabIndex = 15;
            this.adultPriceLabel.Text = "Adult";
            // 
            // noOfAttendeesLabel
            // 
            this.noOfAttendeesLabel.AutoSize = true;
            this.noOfAttendeesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfAttendeesLabel.Location = new System.Drawing.Point(231, 243);
            this.noOfAttendeesLabel.Name = "noOfAttendeesLabel";
            this.noOfAttendeesLabel.Size = new System.Drawing.Size(145, 20);
            this.noOfAttendeesLabel.TabIndex = 7;
            this.noOfAttendeesLabel.Text = "No. of Attendees";
            // 
            // ticketPricesLabel
            // 
            this.ticketPricesLabel.AutoSize = true;
            this.ticketPricesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketPricesLabel.Location = new System.Drawing.Point(101, 244);
            this.ticketPricesLabel.Name = "ticketPricesLabel";
            this.ticketPricesLabel.Size = new System.Drawing.Size(111, 20);
            this.ticketPricesLabel.TabIndex = 7;
            this.ticketPricesLabel.Text = "Ticket Prices";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(279, 197);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 17);
            this.label13.TabIndex = 7;
            this.label13.Text = "e.g. 19:30";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(272, 139);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 17);
            this.label14.TabIndex = 7;
            this.label14.Text = "e.g. 27/11/2013";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "e.g. 18:00";
            // 
            // performanceTimeFinishedLabel
            // 
            this.performanceTimeFinishedLabel.AutoSize = true;
            this.performanceTimeFinishedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.performanceTimeFinishedLabel.Location = new System.Drawing.Point(73, 197);
            this.performanceTimeFinishedLabel.Name = "performanceTimeFinishedLabel";
            this.performanceTimeFinishedLabel.Size = new System.Drawing.Size(96, 17);
            this.performanceTimeFinishedLabel.TabIndex = 14;
            this.performanceTimeFinishedLabel.Text = "Time Finished";
            // 
            // performanceTimeStartedLabel
            // 
            this.performanceTimeStartedLabel.AutoSize = true;
            this.performanceTimeStartedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.performanceTimeStartedLabel.Location = new System.Drawing.Point(80, 165);
            this.performanceTimeStartedLabel.Name = "performanceTimeStartedLabel";
            this.performanceTimeStartedLabel.Size = new System.Drawing.Size(89, 17);
            this.performanceTimeStartedLabel.TabIndex = 14;
            this.performanceTimeStartedLabel.Text = "Time Started";
            // 
            // submitUpdatePerformancesBtn
            // 
            this.submitUpdatePerformancesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitUpdatePerformancesBtn.Location = new System.Drawing.Point(282, 512);
            this.submitUpdatePerformancesBtn.Name = "submitUpdatePerformancesBtn";
            this.submitUpdatePerformancesBtn.Size = new System.Drawing.Size(116, 26);
            this.submitUpdatePerformancesBtn.TabIndex = 12;
            this.submitUpdatePerformancesBtn.Text = "Submit/Update";
            this.submitUpdatePerformancesBtn.UseVisualStyleBackColor = true;
            // 
            // performanceTimeFinishedTextbox
            // 
            this.performanceTimeFinishedTextbox.Location = new System.Drawing.Point(172, 194);
            this.performanceTimeFinishedTextbox.Name = "performanceTimeFinishedTextbox";
            this.performanceTimeFinishedTextbox.Size = new System.Drawing.Size(105, 23);
            this.performanceTimeFinishedTextbox.TabIndex = 2;
            // 
            // performanceDateLabel
            // 
            this.performanceDateLabel.AutoSize = true;
            this.performanceDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.performanceDateLabel.Location = new System.Drawing.Point(131, 116);
            this.performanceDateLabel.Name = "performanceDateLabel";
            this.performanceDateLabel.Size = new System.Drawing.Size(38, 17);
            this.performanceDateLabel.TabIndex = 3;
            this.performanceDateLabel.Text = "Date";
            // 
            // performanceTimeStartedTextbox
            // 
            this.performanceTimeStartedTextbox.Location = new System.Drawing.Point(172, 162);
            this.performanceTimeStartedTextbox.Name = "performanceTimeStartedTextbox";
            this.performanceTimeStartedTextbox.Size = new System.Drawing.Size(105, 23);
            this.performanceTimeStartedTextbox.TabIndex = 2;
            // 
            // performanceDateTextbox
            // 
            this.performanceDateTextbox.Location = new System.Drawing.Point(172, 113);
            this.performanceDateTextbox.Name = "performanceDateTextbox";
            this.performanceDateTextbox.Size = new System.Drawing.Size(223, 23);
            this.performanceDateTextbox.TabIndex = 2;
            // 
            // performanceNameTextboz
            // 
            this.performanceNameTextboz.Location = new System.Drawing.Point(172, 81);
            this.performanceNameTextboz.Name = "performanceNameTextboz";
            this.performanceNameTextboz.Size = new System.Drawing.Size(223, 23);
            this.performanceNameTextboz.TabIndex = 2;
            // 
            // performanceVenueTextbox
            // 
            this.performanceVenueTextbox.Location = new System.Drawing.Point(172, 49);
            this.performanceVenueTextbox.Name = "performanceVenueTextbox";
            this.performanceVenueTextbox.Size = new System.Drawing.Size(223, 23);
            this.performanceVenueTextbox.TabIndex = 2;
            // 
            // performanceNameLabel
            // 
            this.performanceNameLabel.AutoSize = true;
            this.performanceNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.performanceNameLabel.Location = new System.Drawing.Point(39, 84);
            this.performanceNameLabel.Name = "performanceNameLabel";
            this.performanceNameLabel.Size = new System.Drawing.Size(130, 17);
            this.performanceNameLabel.TabIndex = 1;
            this.performanceNameLabel.Text = "Performance Name";
            // 
            // performanceVenueLabel
            // 
            this.performanceVenueLabel.AutoSize = true;
            this.performanceVenueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.performanceVenueLabel.Location = new System.Drawing.Point(35, 52);
            this.performanceVenueLabel.Name = "performanceVenueLabel";
            this.performanceVenueLabel.Size = new System.Drawing.Size(134, 17);
            this.performanceVenueLabel.TabIndex = 1;
            this.performanceVenueLabel.Text = "Performance Venue";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(284, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Add/Update Performance Records";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.panel8);
            this.tabPage6.Controls.Add(this.panel6);
            this.tabPage6.Controls.Add(this.addUpdateEnsemblePanel);
            this.tabPage6.Location = new System.Drawing.Point(4, 34);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(992, 577);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Ensemble Records";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.showEnsembleLevelBtn);
            this.panel8.Controls.Add(this.showEnsembleNameLabel);
            this.panel8.Controls.Add(this.showEnsemblesListbox);
            this.panel8.Controls.Add(this.showEnsemblesByDropdown);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Controls.Add(this.showEnsemblesByBtn);
            this.panel8.Controls.Add(this.showEnsemblesByLabel);
            this.panel8.Location = new System.Drawing.Point(17, 168);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(405, 398);
            this.panel8.TabIndex = 10;
            // 
            // showEnsembleLevelBtn
            // 
            this.showEnsembleLevelBtn.AutoSize = true;
            this.showEnsembleLevelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showEnsembleLevelBtn.Location = new System.Drawing.Point(241, 113);
            this.showEnsembleLevelBtn.Name = "showEnsembleLevelBtn";
            this.showEnsembleLevelBtn.Size = new System.Drawing.Size(82, 13);
            this.showEnsembleLevelBtn.TabIndex = 14;
            this.showEnsembleLevelBtn.Text = "Ensemble Level";
            // 
            // showEnsembleNameLabel
            // 
            this.showEnsembleNameLabel.AutoSize = true;
            this.showEnsembleNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showEnsembleNameLabel.Location = new System.Drawing.Point(7, 113);
            this.showEnsembleNameLabel.Name = "showEnsembleNameLabel";
            this.showEnsembleNameLabel.Size = new System.Drawing.Size(84, 13);
            this.showEnsembleNameLabel.TabIndex = 14;
            this.showEnsembleNameLabel.Text = "Ensemble Name";
            // 
            // showEnsemblesListbox
            // 
            this.showEnsemblesListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showEnsemblesListbox.FormattingEnabled = true;
            this.showEnsemblesListbox.ItemHeight = 16;
            this.showEnsemblesListbox.Location = new System.Drawing.Point(3, 129);
            this.showEnsemblesListbox.Name = "showEnsemblesListbox";
            this.showEnsemblesListbox.Size = new System.Drawing.Size(399, 260);
            this.showEnsemblesListbox.TabIndex = 13;
            // 
            // showEnsemblesByDropdown
            // 
            this.showEnsemblesByDropdown.FormattingEnabled = true;
            this.showEnsemblesByDropdown.Items.AddRange(new object[] {
            "Ensemble Name",
            "Ensemble Level"});
            this.showEnsemblesByDropdown.Location = new System.Drawing.Point(143, 43);
            this.showEnsemblesByDropdown.Name = "showEnsemblesByDropdown";
            this.showEnsemblesByDropdown.Size = new System.Drawing.Size(220, 24);
            this.showEnsemblesByDropdown.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Display Ensembles";
            // 
            // showEnsemblesByBtn
            // 
            this.showEnsemblesByBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showEnsemblesByBtn.Location = new System.Drawing.Point(143, 73);
            this.showEnsemblesByBtn.Name = "showEnsemblesByBtn";
            this.showEnsemblesByBtn.Size = new System.Drawing.Size(220, 26);
            this.showEnsemblesByBtn.TabIndex = 12;
            this.showEnsemblesByBtn.Text = "Display Ensembles";
            this.showEnsemblesByBtn.UseVisualStyleBackColor = true;
            // 
            // showEnsemblesByLabel
            // 
            this.showEnsemblesByLabel.AutoSize = true;
            this.showEnsemblesByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showEnsemblesByLabel.Location = new System.Drawing.Point(6, 46);
            this.showEnsemblesByLabel.Name = "showEnsemblesByLabel";
            this.showEnsemblesByLabel.Size = new System.Drawing.Size(135, 17);
            this.showEnsemblesByLabel.TabIndex = 1;
            this.showEnsemblesByLabel.Text = "Show Ensembles By";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.ensembleNoOfPerformancesLabel);
            this.panel6.Controls.Add(this.ensembleMainInstrumentUsedLabel);
            this.panel6.Controls.Add(this.ensembleMemberNameLabel);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.displayEnsemblesByDropdown);
            this.panel6.Controls.Add(this.displayEnsemblesByLabel);
            this.panel6.Controls.Add(this.ensembleRecordsListbox);
            this.panel6.Controls.Add(this.showEnsembleRecordsLabel);
            this.panel6.Location = new System.Drawing.Point(428, 21);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(559, 545);
            this.panel6.TabIndex = 9;
            // 
            // ensembleNoOfPerformancesLabel
            // 
            this.ensembleNoOfPerformancesLabel.AutoSize = true;
            this.ensembleNoOfPerformancesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ensembleNoOfPerformancesLabel.Location = new System.Drawing.Point(382, 96);
            this.ensembleNoOfPerformancesLabel.Name = "ensembleNoOfPerformancesLabel";
            this.ensembleNoOfPerformancesLabel.Size = new System.Drawing.Size(104, 13);
            this.ensembleNoOfPerformancesLabel.TabIndex = 10;
            this.ensembleNoOfPerformancesLabel.Text = "No. of Performances";
            // 
            // ensembleMainInstrumentUsedLabel
            // 
            this.ensembleMainInstrumentUsedLabel.AutoSize = true;
            this.ensembleMainInstrumentUsedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ensembleMainInstrumentUsedLabel.Location = new System.Drawing.Point(161, 96);
            this.ensembleMainInstrumentUsedLabel.Name = "ensembleMainInstrumentUsedLabel";
            this.ensembleMainInstrumentUsedLabel.Size = new System.Drawing.Size(110, 13);
            this.ensembleMainInstrumentUsedLabel.TabIndex = 10;
            this.ensembleMainInstrumentUsedLabel.Text = "Main Instrument Used";
            // 
            // ensembleMemberNameLabel
            // 
            this.ensembleMemberNameLabel.AutoSize = true;
            this.ensembleMemberNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ensembleMemberNameLabel.Location = new System.Drawing.Point(8, 96);
            this.ensembleMemberNameLabel.Name = "ensembleMemberNameLabel";
            this.ensembleMemberNameLabel.Size = new System.Drawing.Size(76, 13);
            this.ensembleMemberNameLabel.TabIndex = 10;
            this.ensembleMemberNameLabel.Text = "Member Name";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(403, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Show Performances";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // displayEnsemblesByDropdown
            // 
            this.displayEnsemblesByDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.displayEnsemblesByDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayEnsemblesByDropdown.FormattingEnabled = true;
            this.displayEnsemblesByDropdown.Items.AddRange(new object[] {
            "Ensemble Name",
            "Ensemble Level"});
            this.displayEnsemblesByDropdown.Location = new System.Drawing.Point(403, 7);
            this.displayEnsemblesByDropdown.Name = "displayEnsemblesByDropdown";
            this.displayEnsemblesByDropdown.Size = new System.Drawing.Size(149, 24);
            this.displayEnsemblesByDropdown.TabIndex = 7;
            // 
            // displayEnsemblesByLabel
            // 
            this.displayEnsemblesByLabel.AutoSize = true;
            this.displayEnsemblesByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayEnsemblesByLabel.Location = new System.Drawing.Point(247, 10);
            this.displayEnsemblesByLabel.Name = "displayEnsemblesByLabel";
            this.displayEnsemblesByLabel.Size = new System.Drawing.Size(135, 17);
            this.displayEnsemblesByLabel.TabIndex = 6;
            this.displayEnsemblesByLabel.Text = "Show Ensembles By";
            // 
            // ensembleRecordsListbox
            // 
            this.ensembleRecordsListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ensembleRecordsListbox.FormattingEnabled = true;
            this.ensembleRecordsListbox.ItemHeight = 16;
            this.ensembleRecordsListbox.Location = new System.Drawing.Point(5, 115);
            this.ensembleRecordsListbox.Name = "ensembleRecordsListbox";
            this.ensembleRecordsListbox.Size = new System.Drawing.Size(549, 420);
            this.ensembleRecordsListbox.TabIndex = 2;
            // 
            // showEnsembleRecordsLabel
            // 
            this.showEnsembleRecordsLabel.AutoSize = true;
            this.showEnsembleRecordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showEnsembleRecordsLabel.Location = new System.Drawing.Point(4, 4);
            this.showEnsembleRecordsLabel.Name = "showEnsembleRecordsLabel";
            this.showEnsembleRecordsLabel.Size = new System.Drawing.Size(209, 20);
            this.showEnsembleRecordsLabel.TabIndex = 0;
            this.showEnsembleRecordsLabel.Text = "Show Ensemble Records";
            // 
            // addUpdateEnsemblePanel
            // 
            this.addUpdateEnsemblePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addUpdateEnsemblePanel.Controls.Add(this.ensembleLevelDropdown);
            this.addUpdateEnsemblePanel.Controls.Add(this.ensembleNameTextbox);
            this.addUpdateEnsemblePanel.Controls.Add(this.submitUpdateEnsembleBtn);
            this.addUpdateEnsemblePanel.Controls.Add(this.label29);
            this.addUpdateEnsemblePanel.Controls.Add(this.ensembleLevelTextbox);
            this.addUpdateEnsemblePanel.Controls.Add(this.ensembleNameLabel);
            this.addUpdateEnsemblePanel.Controls.Add(this.ensembleRecordsLabel);
            this.addUpdateEnsemblePanel.Location = new System.Drawing.Point(17, 21);
            this.addUpdateEnsemblePanel.Name = "addUpdateEnsemblePanel";
            this.addUpdateEnsemblePanel.Size = new System.Drawing.Size(405, 140);
            this.addUpdateEnsemblePanel.TabIndex = 8;
            // 
            // ensembleLevelDropdown
            // 
            this.ensembleLevelDropdown.FormattingEnabled = true;
            this.ensembleLevelDropdown.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.ensembleLevelDropdown.Location = new System.Drawing.Point(120, 81);
            this.ensembleLevelDropdown.Name = "ensembleLevelDropdown";
            this.ensembleLevelDropdown.Size = new System.Drawing.Size(121, 24);
            this.ensembleLevelDropdown.TabIndex = 14;
            // 
            // ensembleNameTextbox
            // 
            this.ensembleNameTextbox.Location = new System.Drawing.Point(120, 50);
            this.ensembleNameTextbox.Name = "ensembleNameTextbox";
            this.ensembleNameTextbox.Size = new System.Drawing.Size(282, 23);
            this.ensembleNameTextbox.TabIndex = 13;
            // 
            // submitUpdateEnsembleBtn
            // 
            this.submitUpdateEnsembleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitUpdateEnsembleBtn.Location = new System.Drawing.Point(286, 106);
            this.submitUpdateEnsembleBtn.Name = "submitUpdateEnsembleBtn";
            this.submitUpdateEnsembleBtn.Size = new System.Drawing.Size(116, 26);
            this.submitUpdateEnsembleBtn.TabIndex = 12;
            this.submitUpdateEnsembleBtn.Text = "Submit/Update";
            this.submitUpdateEnsembleBtn.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(39, 84);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(0, 17);
            this.label29.TabIndex = 1;
            // 
            // ensembleLevelTextbox
            // 
            this.ensembleLevelTextbox.AutoSize = true;
            this.ensembleLevelTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ensembleLevelTextbox.Location = new System.Drawing.Point(75, 84);
            this.ensembleLevelTextbox.Name = "ensembleLevelTextbox";
            this.ensembleLevelTextbox.Size = new System.Drawing.Size(42, 17);
            this.ensembleLevelTextbox.TabIndex = 1;
            this.ensembleLevelTextbox.Text = "Level";
            // 
            // ensembleNameLabel
            // 
            this.ensembleNameLabel.AutoSize = true;
            this.ensembleNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ensembleNameLabel.Location = new System.Drawing.Point(6, 52);
            this.ensembleNameLabel.Name = "ensembleNameLabel";
            this.ensembleNameLabel.Size = new System.Drawing.Size(111, 17);
            this.ensembleNameLabel.TabIndex = 1;
            this.ensembleNameLabel.Text = "Ensemble Name";
            // 
            // ensembleRecordsLabel
            // 
            this.ensembleRecordsLabel.AutoSize = true;
            this.ensembleRecordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ensembleRecordsLabel.Location = new System.Drawing.Point(8, 9);
            this.ensembleRecordsLabel.Name = "ensembleRecordsLabel";
            this.ensembleRecordsLabel.Size = new System.Drawing.Size(261, 20);
            this.ensembleRecordsLabel.TabIndex = 0;
            this.ensembleRecordsLabel.Text = "Add/Update Ensemble Records";
            // 
            // lessonRecordsTab
            // 
            this.lessonRecordsTab.Controls.Add(this.panel7);
            this.lessonRecordsTab.Controls.Add(this.panel9);
            this.lessonRecordsTab.Location = new System.Drawing.Point(4, 34);
            this.lessonRecordsTab.Name = "lessonRecordsTab";
            this.lessonRecordsTab.Padding = new System.Windows.Forms.Padding(3);
            this.lessonRecordsTab.Size = new System.Drawing.Size(992, 577);
            this.lessonRecordsTab.TabIndex = 6;
            this.lessonRecordsTab.Text = "Lesson Records";
            this.lessonRecordsTab.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.button5);
            this.panel7.Controls.Add(this.comboBox5);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.button6);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.comboBox6);
            this.panel7.Controls.Add(this.displayLessonsListbox);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(428, 21);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(559, 545);
            this.panel7.TabIndex = 9;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(403, 39);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(149, 30);
            this.button5.TabIndex = 9;
            this.button5.Text = "Show Lessons";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Lesson Name",
            "Lesson Location",
            "Subject",
            "Lesson Date",
            "Start Time",
            "Finish Time",
            "Student Fee",
            "Open Fee",
            "No. of Students"});
            this.comboBox5.Location = new System.Drawing.Point(403, 7);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(149, 24);
            this.comboBox5.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(247, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Show Lessons By";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(343, 463);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 26);
            this.button6.TabIndex = 5;
            this.button6.Text = "Go";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(129, 466);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "selected lesson record";
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "Edit/Update",
            "Delete"});
            this.comboBox6.Location = new System.Drawing.Point(5, 464);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 24);
            this.comboBox6.TabIndex = 3;
            // 
            // displayLessonsListbox
            // 
            this.displayLessonsListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLessonsListbox.FormattingEnabled = true;
            this.displayLessonsListbox.ItemHeight = 16;
            this.displayLessonsListbox.Location = new System.Drawing.Point(5, 105);
            this.displayLessonsListbox.Name = "displayLessonsListbox";
            this.displayLessonsListbox.Size = new System.Drawing.Size(575, 340);
            this.displayLessonsListbox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Show Lesson Records";
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.lessonTutorLabel);
            this.panel9.Controls.Add(this.lessonInstrumentLabel);
            this.panel9.Controls.Add(this.lessonTutorDropdown);
            this.panel9.Controls.Add(this.lessonInstrumentDropdown);
            this.panel9.Controls.Add(this.comboBox8);
            this.panel9.Controls.Add(this.comboBox7);
            this.panel9.Controls.Add(this.label16);
            this.panel9.Controls.Add(this.label15);
            this.panel9.Controls.Add(this.dateTimePicker1);
            this.panel9.Controls.Add(this.label9);
            this.panel9.Controls.Add(this.openLessonFeeTextbox);
            this.panel9.Controls.Add(this.studentLessonFeeTextbox);
            this.panel9.Controls.Add(this.textBox5);
            this.panel9.Controls.Add(this.lessonLocationTextbox);
            this.panel9.Controls.Add(this.lessonNameTextbox);
            this.panel9.Controls.Add(this.button8);
            this.panel9.Controls.Add(this.openLessonFeeLabel);
            this.panel9.Controls.Add(this.studentLessonFeeLabel);
            this.panel9.Controls.Add(this.label30);
            this.panel9.Controls.Add(this.lessonLocationLabel);
            this.panel9.Controls.Add(this.lessonNameLabel);
            this.panel9.Controls.Add(this.addUpdateLessonRecordsLabel);
            this.panel9.Location = new System.Drawing.Point(17, 21);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(405, 545);
            this.panel9.TabIndex = 8;
            // 
            // lessonTutorLabel
            // 
            this.lessonTutorLabel.AutoSize = true;
            this.lessonTutorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessonTutorLabel.Location = new System.Drawing.Point(38, 183);
            this.lessonTutorLabel.Name = "lessonTutorLabel";
            this.lessonTutorLabel.Size = new System.Drawing.Size(92, 17);
            this.lessonTutorLabel.TabIndex = 24;
            this.lessonTutorLabel.Text = "Lesson Tutor";
            // 
            // lessonInstrumentLabel
            // 
            this.lessonInstrumentLabel.AutoSize = true;
            this.lessonInstrumentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessonInstrumentLabel.Location = new System.Drawing.Point(56, 148);
            this.lessonInstrumentLabel.Name = "lessonInstrumentLabel";
            this.lessonInstrumentLabel.Size = new System.Drawing.Size(74, 17);
            this.lessonInstrumentLabel.TabIndex = 24;
            this.lessonInstrumentLabel.Text = "Instrument";
            // 
            // lessonTutorDropdown
            // 
            this.lessonTutorDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lessonTutorDropdown.FormattingEnabled = true;
            this.lessonTutorDropdown.Location = new System.Drawing.Point(133, 180);
            this.lessonTutorDropdown.Name = "lessonTutorDropdown";
            this.lessonTutorDropdown.Size = new System.Drawing.Size(261, 24);
            this.lessonTutorDropdown.TabIndex = 23;
            // 
            // lessonInstrumentDropdown
            // 
            this.lessonInstrumentDropdown.DisplayMember = "InstrumentName";
            this.lessonInstrumentDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lessonInstrumentDropdown.FormattingEnabled = true;
            this.lessonInstrumentDropdown.Location = new System.Drawing.Point(133, 145);
            this.lessonInstrumentDropdown.Name = "lessonInstrumentDropdown";
            this.lessonInstrumentDropdown.Size = new System.Drawing.Size(261, 24);
            this.lessonInstrumentDropdown.TabIndex = 23;
            this.lessonInstrumentDropdown.ValueMember = "InstrumentName";
            // 
            // comboBox8
            // 
            this.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00"});
            this.comboBox8.Location = new System.Drawing.Point(133, 284);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(89, 24);
            this.comboBox8.TabIndex = 22;
            // 
            // comboBox7
            // 
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30"});
            this.comboBox7.Location = new System.Drawing.Point(133, 250);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(89, 24);
            this.comboBox7.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(50, 287);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 17);
            this.label16.TabIndex = 21;
            this.label16.Text = "Finish Time";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(57, 253);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 17);
            this.label15.TabIndex = 21;
            this.label15.Text = "Start Time";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(133, 215);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(261, 23);
            this.dateTimePicker1.TabIndex = 20;
            this.dateTimePicker1.Value = new System.DateTime(2013, 10, 19, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(42, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Lesson Date";
            // 
            // openLessonFeeTextbox
            // 
            this.openLessonFeeTextbox.Location = new System.Drawing.Point(133, 352);
            this.openLessonFeeTextbox.Name = "openLessonFeeTextbox";
            this.openLessonFeeTextbox.Size = new System.Drawing.Size(69, 23);
            this.openLessonFeeTextbox.TabIndex = 18;
            // 
            // studentLessonFeeTextbox
            // 
            this.studentLessonFeeTextbox.Location = new System.Drawing.Point(133, 318);
            this.studentLessonFeeTextbox.Name = "studentLessonFeeTextbox";
            this.studentLessonFeeTextbox.Size = new System.Drawing.Size(69, 23);
            this.studentLessonFeeTextbox.TabIndex = 18;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(133, 112);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(261, 23);
            this.textBox5.TabIndex = 18;
            // 
            // lessonLocationTextbox
            // 
            this.lessonLocationTextbox.Location = new System.Drawing.Point(133, 81);
            this.lessonLocationTextbox.Name = "lessonLocationTextbox";
            this.lessonLocationTextbox.Size = new System.Drawing.Size(261, 23);
            this.lessonLocationTextbox.TabIndex = 18;
            // 
            // lessonNameTextbox
            // 
            this.lessonNameTextbox.Location = new System.Drawing.Point(133, 49);
            this.lessonNameTextbox.Name = "lessonNameTextbox";
            this.lessonNameTextbox.Size = new System.Drawing.Size(261, 23);
            this.lessonNameTextbox.TabIndex = 18;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(278, 375);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(116, 26);
            this.button8.TabIndex = 12;
            this.button8.Text = "Submit/Update";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // openLessonFeeLabel
            // 
            this.openLessonFeeLabel.AutoSize = true;
            this.openLessonFeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openLessonFeeLabel.Location = new System.Drawing.Point(59, 355);
            this.openLessonFeeLabel.Name = "openLessonFeeLabel";
            this.openLessonFeeLabel.Size = new System.Drawing.Size(71, 17);
            this.openLessonFeeLabel.TabIndex = 3;
            this.openLessonFeeLabel.Text = "Open Fee";
            // 
            // studentLessonFeeLabel
            // 
            this.studentLessonFeeLabel.AutoSize = true;
            this.studentLessonFeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentLessonFeeLabel.Location = new System.Drawing.Point(45, 321);
            this.studentLessonFeeLabel.Name = "studentLessonFeeLabel";
            this.studentLessonFeeLabel.Size = new System.Drawing.Size(85, 17);
            this.studentLessonFeeLabel.TabIndex = 3;
            this.studentLessonFeeLabel.Text = "Student Fee";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(75, 115);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(55, 17);
            this.label30.TabIndex = 3;
            this.label30.Text = "Subject";
            // 
            // lessonLocationLabel
            // 
            this.lessonLocationLabel.AutoSize = true;
            this.lessonLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessonLocationLabel.Location = new System.Drawing.Point(18, 84);
            this.lessonLocationLabel.Name = "lessonLocationLabel";
            this.lessonLocationLabel.Size = new System.Drawing.Size(112, 17);
            this.lessonLocationLabel.TabIndex = 1;
            this.lessonLocationLabel.Text = "Lesson Location";
            // 
            // lessonNameLabel
            // 
            this.lessonNameLabel.AutoSize = true;
            this.lessonNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessonNameLabel.Location = new System.Drawing.Point(35, 52);
            this.lessonNameLabel.Name = "lessonNameLabel";
            this.lessonNameLabel.Size = new System.Drawing.Size(95, 17);
            this.lessonNameLabel.TabIndex = 1;
            this.lessonNameLabel.Text = "Lesson Name";
            // 
            // addUpdateLessonRecordsLabel
            // 
            this.addUpdateLessonRecordsLabel.AutoSize = true;
            this.addUpdateLessonRecordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUpdateLessonRecordsLabel.Location = new System.Drawing.Point(8, 9);
            this.addUpdateLessonRecordsLabel.Name = "addUpdateLessonRecordsLabel";
            this.addUpdateLessonRecordsLabel.Size = new System.Drawing.Size(240, 20);
            this.addUpdateLessonRecordsLabel.TabIndex = 0;
            this.addUpdateLessonRecordsLabel.Text = "Add/Update Lesson Records";
            // 
            // mainBannerLogo
            // 
            this.mainBannerLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainBannerLogo.BackgroundImage")));
            this.mainBannerLogo.Location = new System.Drawing.Point(0, 0);
            this.mainBannerLogo.Name = "mainBannerLogo";
            this.mainBannerLogo.Size = new System.Drawing.Size(1000, 138);
            this.mainBannerLogo.TabIndex = 1;
            this.mainBannerLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 749);
            this.Controls.Add(this.mainBannerLogo);
            this.Controls.Add(this.mainTabGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1015, 1000);
            this.MinimumSize = new System.Drawing.Size(1015, 726);
            this.Name = "Form1";
            this.Text = "Saturday Morning Music Classes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainTabGroup.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.displayStudentRecords.ResumeLayout(false);
            this.displayStudentRecords.PerformLayout();
            this.addUpdateStudent.ResumeLayout(false);
            this.addUpdateStudent.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.levelCheckboxesGroup.ResumeLayout(false);
            this.levelCheckboxesGroup.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.sheetMusicRecordPanel.ResumeLayout(false);
            this.sheetMusicRecordPanel.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.showPerformanceRecordsPanel.ResumeLayout(false);
            this.showPerformanceRecordsPanel.PerformLayout();
            this.addUpdatePerformancesPanel.ResumeLayout(false);
            this.addUpdatePerformancesPanel.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.addUpdateEnsemblePanel.ResumeLayout(false);
            this.addUpdateEnsemblePanel.PerformLayout();
            this.lessonRecordsTab.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainBannerLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabGroup;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox mainBannerLogo;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Panel addUpdateStudent;
        private System.Windows.Forms.Label addOrUpdateStudentLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox ageField;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox lastNameField;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameField;
        private System.Windows.Forms.Label streetAddressLabel;
        private System.Windows.Forms.TextBox studentTownOrCityField;
        private System.Windows.Forms.Label townOrCityLabel;
        private System.Windows.Forms.TextBox postCodeField;
        private System.Windows.Forms.Label postCodeLabel;
        private System.Windows.Forms.TextBox suburbField;
        private System.Windows.Forms.Label suburbLabel;
        private System.Windows.Forms.TextBox streetAddressField;
        private System.Windows.Forms.TextBox landlinePhoneField;
        private System.Windows.Forms.Label landlinePhoneLabel;
        private System.Windows.Forms.ComboBox lessonDropdownBox;
        private System.Windows.Forms.Label lessonLabel;
        private System.Windows.Forms.TextBox mobilePhoneField;
        private System.Windows.Forms.Label mobilePhoneLabel;
        private System.Windows.Forms.ComboBox instrumentDropdownBox;
        private System.Windows.Forms.Label instrumentLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ensembleLabel;
        private System.Windows.Forms.ComboBox ensembleDropdownBox;
        private System.Windows.Forms.TextBox instrumentFeesOwedField;
        private System.Windows.Forms.Label instrumentFeesOwedLabel;
        private System.Windows.Forms.TextBox lessonFeesOwedField;
        private System.Windows.Forms.Label lessonFeesOwedLabel;
        private System.Windows.Forms.Button submitUpdateBtn;
        private System.Windows.Forms.TextBox totalFeesOwedField;
        private System.Windows.Forms.Label totalFeesOwedLabel;
        private System.Windows.Forms.ListBox sheetMusicListBox;
        private System.Windows.Forms.Panel displayStudentRecords;
        private System.Windows.Forms.Label showStudentRecordsLabel;
        private System.Windows.Forms.ListBox studentRecordsListbox;
        private System.Windows.Forms.Button editStudentBtn;
        private System.Windows.Forms.Label editStudentLabel;
        private System.Windows.Forms.ComboBox editStudentDropdown;
        private System.Windows.Forms.ComboBox showStudentsByDropdown;
        private System.Windows.Forms.Label showStudentsByLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox showTutorsByDropdown;
        private System.Windows.Forms.Label showTutorsByLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label editSelectedTutorLabel;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ListBox showTutorRecordsListbox;
        private System.Windows.Forms.Label showTutorRecordsLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tutorMobileTextbox;
        private System.Windows.Forms.Label tutorMobileLabel;
        private System.Windows.Forms.TextBox tutorLandlineTextbox;
        private System.Windows.Forms.Label tutorLandlineLabel;
        private System.Windows.Forms.TextBox tutorTownOrCityTextbox;
        private System.Windows.Forms.Label tutorTownOrCityLabel;
        private System.Windows.Forms.TextBox tutorPostcodeTextbox;
        private System.Windows.Forms.Label tutorPostcodeLabel;
        private System.Windows.Forms.TextBox tutorSuburbTextbox;
        private System.Windows.Forms.Label tutorSuburbLabel;
        private System.Windows.Forms.TextBox tutorStreetAddressTextbox;
        private System.Windows.Forms.Label tutorStreetAddressLabel;
        private System.Windows.Forms.TextBox tutorAgeTextbox;
        private System.Windows.Forms.Label tutorAgeLabel;
        private System.Windows.Forms.TextBox tutorLastNameTextbox;
        private System.Windows.Forms.Label tutorLastNameLabel;
        private System.Windows.Forms.TextBox tutorFirstNameTextbox;
        private System.Windows.Forms.Label tutorFirstNameLabel;
        private System.Windows.Forms.Label addUpdateTutorLabel;
        private System.Windows.Forms.RichTextBox qualificationsTextbox;
        private System.Windows.Forms.Label lessonsToTeachLabel;
        private System.Windows.Forms.Label qualificationsSubLabel;
        private System.Windows.Forms.Label qualificationsLabel;
        private System.Windows.Forms.ListBox tutorEnsemblesListBox;
        private System.Windows.Forms.ListBox tutorSheetMusicListbox;
        private System.Windows.Forms.Label tutorEnsemblesLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox levelCheckboxesGroup;
        private System.Windows.Forms.CheckBox tutorLevel8Checkbox;
        private System.Windows.Forms.CheckBox tutorLevel7Checkbox;
        private System.Windows.Forms.CheckBox tutorLevel6Checkbox;
        private System.Windows.Forms.CheckBox tutorLevel5Checkbox;
        private System.Windows.Forms.CheckBox tutorLevel4Checkbox;
        private System.Windows.Forms.CheckBox tutorLevel3Checkbox;
        private System.Windows.Forms.CheckBox tutorLevel2Checkbox;
        private System.Windows.Forms.CheckBox tutorLevel1Checkbox;
        private System.Windows.Forms.Label tutorSheetMusicLabel;
        private System.Windows.Forms.ListBox lessonsToTeachListbox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button showStudentsBtn;
        private System.Windows.Forms.Button showTutorsBtn;
        private System.Windows.Forms.Panel sheetMusicRecordPanel;
        private System.Windows.Forms.Label addUpdateSheetMusicLabel;
        private System.Windows.Forms.TextBox sheetMusicComposerTextbox;
        private System.Windows.Forms.Label sheetMusicComposerLabel;
        private System.Windows.Forms.TextBox sheetMusicTitleTextbox;
        private System.Windows.Forms.Label sheetMusicTitleLabel;
        private System.Windows.Forms.Label sheetMusicDifficultyLabel;
        private System.Windows.Forms.Button sheetMusicSubmitBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button showRecordsByBtn;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label showRecordsByLabel;
        private System.Windows.Forms.Button editSheetMusicRecordBtn;
        private System.Windows.Forms.Label editSheetMusicRecordLabel;
        private System.Windows.Forms.ComboBox editSheetMusicRecordDropdown;
        private System.Windows.Forms.ListBox sheetMusicRecordsListbox;
        private System.Windows.Forms.Label showSheetMusicRecordsLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button editInstrumentBtn;
        private System.Windows.Forms.Label editInstrumentLabel;
        private System.Windows.Forms.ComboBox editInstrumentDropdown;
        private System.Windows.Forms.ListBox instrumentListbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox instrumentAuthCopiesTextbox;
        private System.Windows.Forms.Label instrumentAuthCopiesLabel;
        private System.Windows.Forms.Label instrumentStatusLabel;
        private System.Windows.Forms.Label instrumentFeeLabel;
        private System.Windows.Forms.TextBox instrumentSizeTextbox;
        private System.Windows.Forms.Label instrumentSizeLabel;
        private System.Windows.Forms.TextBox nameOfInstrumentTextbox;
        private System.Windows.Forms.Label nameOfInstrumentLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox sheetMusicAuthCopiesTextbox;
        private System.Windows.Forms.Label sheetMusicAuthCopiesLabel;
        private System.Windows.Forms.ComboBox sheetMusicDifficultyDropdown;
        private System.Windows.Forms.ComboBox instrumentStatusDropdown;
        private System.Windows.Forms.TextBox instrumentFeeTextbox;
        private System.Windows.Forms.ComboBox instrumentConditionDropdown;
        private System.Windows.Forms.Label instrumentConditionLabel;
        private System.Windows.Forms.Panel addUpdatePerformancesPanel;
        private System.Windows.Forms.Button submitUpdatePerformancesBtn;
        private System.Windows.Forms.Label performanceDateLabel;
        private System.Windows.Forms.TextBox performanceVenueTextbox;
        private System.Windows.Forms.Label performanceVenueLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label child5to17label;
        private System.Windows.Forms.Label childUnder5Label;
        private System.Windows.Forms.Label adultPriceLabel;
        private System.Windows.Forms.Label noOfAttendeesLabel;
        private System.Windows.Forms.Label ticketPricesLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label performanceTimeFinishedLabel;
        private System.Windows.Forms.Label performanceTimeStartedLabel;
        private System.Windows.Forms.TextBox performanceTimeFinishedTextbox;
        private System.Windows.Forms.TextBox performanceTimeStartedTextbox;
        private System.Windows.Forms.TextBox performanceDateTextbox;
        private System.Windows.Forms.TextBox performanceNameTextboz;
        private System.Windows.Forms.Label performanceNameLabel;
        private System.Windows.Forms.Label totalRevenueLabel;
        private System.Windows.Forms.Label totalAttendeesLabel;
        private System.Windows.Forms.TextBox totalRevenueTextbox;
        private System.Windows.Forms.TextBox beneficiaryPriceTextbox;
        private System.Windows.Forms.TextBox totalAttendeesTextbox;
        private System.Windows.Forms.TextBox studentPriceTextbox;
        private System.Windows.Forms.TextBox beneficiaryAttendeesAmtTextbox;
        private System.Windows.Forms.TextBox child5to17AttendeesAmtTextbox;
        private System.Windows.Forms.TextBox child5to17textbox;
        private System.Windows.Forms.TextBox studentAttendeesAmtTextbox;
        private System.Windows.Forms.TextBox childUnder5AttendeesAmtTextbox;
        private System.Windows.Forms.TextBox childUnder5Textbox;
        private System.Windows.Forms.TextBox adultAttendeesAmtTextbox;
        private System.Windows.Forms.TextBox adultPriceTextbox;
        private System.Windows.Forms.Label totalsLabel;
        private System.Windows.Forms.Label beneficiaryPriceLabel;
        private System.Windows.Forms.Label studentPriceLabel;
        private System.Windows.Forms.Panel showPerformanceRecordsPanel;
        private System.Windows.Forms.Button showPerformancesBtn;
        private System.Windows.Forms.ComboBox showPerformancesByDropdown;
        private System.Windows.Forms.Label showPerformancesByLabel;
        private System.Windows.Forms.Button editUpdatePerformanceBtn;
        private System.Windows.Forms.Label editUpdatePerformanceLabel;
        private System.Windows.Forms.ComboBox editUpdatePerformanceDropdown;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label showPerformanceRecordsLabel;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label showEnsembleNameLabel;
        private System.Windows.Forms.ListBox showEnsemblesListbox;
        private System.Windows.Forms.ComboBox showEnsemblesByDropdown;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button showEnsemblesByBtn;
        private System.Windows.Forms.Label showEnsemblesByLabel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label ensembleNoOfPerformancesLabel;
        private System.Windows.Forms.Label ensembleMainInstrumentUsedLabel;
        private System.Windows.Forms.Label ensembleMemberNameLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox displayEnsemblesByDropdown;
        private System.Windows.Forms.Label displayEnsemblesByLabel;
        private System.Windows.Forms.ListBox ensembleRecordsListbox;
        private System.Windows.Forms.Label showEnsembleRecordsLabel;
        private System.Windows.Forms.Panel addUpdateEnsemblePanel;
        private System.Windows.Forms.ComboBox ensembleLevelDropdown;
        private System.Windows.Forms.TextBox ensembleNameTextbox;
        private System.Windows.Forms.Button submitUpdateEnsembleBtn;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label ensembleLevelTextbox;
        private System.Windows.Forms.Label ensembleNameLabel;
        private System.Windows.Forms.Label ensembleRecordsLabel;
        private System.Windows.Forms.Label showEnsembleLevelBtn;
        private System.Windows.Forms.TabPage lessonRecordsTab;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ListBox displayLessonsListbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lessonLocationLabel;
        private System.Windows.Forms.Label lessonNameLabel;
        private System.Windows.Forms.Label addUpdateLessonRecordsLabel;
        private System.Windows.Forms.TextBox openLessonFeeTextbox;
        private System.Windows.Forms.TextBox studentLessonFeeTextbox;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox lessonLocationTextbox;
        private System.Windows.Forms.TextBox lessonNameTextbox;
        private System.Windows.Forms.Label openLessonFeeLabel;
        private System.Windows.Forms.Label studentLessonFeeLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lessonInstrumentLabel;
        private System.Windows.Forms.ComboBox lessonInstrumentDropdown;
        private System.Windows.Forms.Label lessonTutorLabel;
        private System.Windows.Forms.ComboBox lessonTutorDropdown;
        private System.Windows.Forms.TextBox emailAddressField;
        private System.Windows.Forms.Label emailAddressLabel;
    }
}

