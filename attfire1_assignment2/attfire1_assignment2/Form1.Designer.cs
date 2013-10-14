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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainTabGroup = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.displayStudentRecords = new System.Windows.Forms.Panel();
            this.showStudentsByDropdown = new System.Windows.Forms.ComboBox();
            this.showStudentsByLabel = new System.Windows.Forms.Label();
            this.editStudentBtn = new System.Windows.Forms.Button();
            this.editStudentLabel = new System.Windows.Forms.Label();
            this.editStudentDropdown = new System.Windows.Forms.ComboBox();
            this.studentRecordsListbox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.showStudentRecordsLabel = new System.Windows.Forms.Label();
            this.addUpdateStudent = new System.Windows.Forms.Panel();
            this.sheetMusicListBox = new System.Windows.Forms.ListBox();
            this.sheetMusicsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._attfire1_assignment2_MusicClassesContextDataSet3 = new attfire1_assignment2._attfire1_assignment2_MusicClassesContextDataSet3();
            this.submitUpdateBtn = new System.Windows.Forms.Button();
            this.totalFeesOwedField = new System.Windows.Forms.TextBox();
            this.totalFeesOwedLabel = new System.Windows.Forms.Label();
            this.instrumentFeesOwedField = new System.Windows.Forms.TextBox();
            this.instrumentFeesOwedLabel = new System.Windows.Forms.Label();
            this.lessonFeesOwedField = new System.Windows.Forms.TextBox();
            this.lessonFeesOwedLabel = new System.Windows.Forms.Label();
            this.ensembleDropdownBox = new System.Windows.Forms.ComboBox();
            this.ensemblesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._attfire1_assignment2_MusicClassesContextDataSet4 = new attfire1_assignment2._attfire1_assignment2_MusicClassesContextDataSet4();
            this.ensembleLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.levelLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.instrumentDropdownBox = new System.Windows.Forms.ComboBox();
            this.instrumentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._attfire1_assignment2_MusicClassesContextDataSet1 = new attfire1_assignment2._attfire1_assignment2_MusicClassesContextDataSet1();
            this.instrumentLabel = new System.Windows.Forms.Label();
            this.lessonDropdownBox = new System.Windows.Forms.ComboBox();
            this.lessonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._attfire1_assignment2_MusicClassesContextDataSet = new attfire1_assignment2._attfire1_assignment2_MusicClassesContextDataSet();
            this.lessonLabel = new System.Windows.Forms.Label();
            this.mobilePhoneField = new System.Windows.Forms.TextBox();
            this.mobilePhoneLabel = new System.Windows.Forms.Label();
            this.landlinePhoneField = new System.Windows.Forms.TextBox();
            this.landlinePhoneLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.showTutorsByDropdown = new System.Windows.Forms.ComboBox();
            this.showTutorsByLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.editSelectedTutorLabel = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.showTutorRecordsListbox = new System.Windows.Forms.ListBox();
            this.displayAllTutorsBtn = new System.Windows.Forms.Button();
            this.showTutorRecordsLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.mainBannerLogo = new System.Windows.Forms.PictureBox();
            this.lessonsTableAdapter = new attfire1_assignment2._attfire1_assignment2_MusicClassesContextDataSetTableAdapters.LessonsTableAdapter();
            this.instrumentsTableAdapter = new attfire1_assignment2._attfire1_assignment2_MusicClassesContextDataSet1TableAdapters.InstrumentsTableAdapter();
            this.sheetMusicsTableAdapter = new attfire1_assignment2._attfire1_assignment2_MusicClassesContextDataSet3TableAdapters.SheetMusicsTableAdapter();
            this.ensemblesTableAdapter = new attfire1_assignment2._attfire1_assignment2_MusicClassesContextDataSet4TableAdapters.EnsemblesTableAdapter();
            this.qualificationsTextbox = new System.Windows.Forms.RichTextBox();
            this.qualificationsLabel = new System.Windows.Forms.Label();
            this.qualificationsSubLabel = new System.Windows.Forms.Label();
            this.lessonsToTeachLabel = new System.Windows.Forms.Label();
            this.lessonsToTeachListbox = new System.Windows.Forms.ListBox();
            this.tutorSheetMusicListbox = new System.Windows.Forms.ListBox();
            this.tutorSheetMusicLabel = new System.Windows.Forms.Label();
            this.levelCheckboxesGroup = new System.Windows.Forms.GroupBox();
            this.tutorLevel8Checkbox = new System.Windows.Forms.CheckBox();
            this.tutorLevel7Checkbox = new System.Windows.Forms.CheckBox();
            this.tutorLevel6Checkbox = new System.Windows.Forms.CheckBox();
            this.tutorLevel5Checkbox = new System.Windows.Forms.CheckBox();
            this.tutorLevel4Checkbox = new System.Windows.Forms.CheckBox();
            this.tutorLevel3Checkbox = new System.Windows.Forms.CheckBox();
            this.tutorLevel2Checkbox = new System.Windows.Forms.CheckBox();
            this.tutorLevel1Checkbox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tutorEnsemblesLabel = new System.Windows.Forms.Label();
            this.tutorEnsemblesListBox = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.showStudentsBtn = new System.Windows.Forms.Button();
            this.showTutorsBtn = new System.Windows.Forms.Button();
            this.mainTabGroup.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.displayStudentRecords.SuspendLayout();
            this.addUpdateStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sheetMusicsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._attfire1_assignment2_MusicClassesContextDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ensemblesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._attfire1_assignment2_MusicClassesContextDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._attfire1_assignment2_MusicClassesContextDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._attfire1_assignment2_MusicClassesContextDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainBannerLogo)).BeginInit();
            this.levelCheckboxesGroup.SuspendLayout();
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
            this.mainTabGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTabGroup.ItemSize = new System.Drawing.Size(166, 30);
            this.mainTabGroup.Location = new System.Drawing.Point(0, 137);
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
            this.displayStudentRecords.Controls.Add(this.button1);
            this.displayStudentRecords.Controls.Add(this.showStudentRecordsLabel);
            this.displayStudentRecords.Location = new System.Drawing.Point(395, 18);
            this.displayStudentRecords.Name = "displayStudentRecords";
            this.displayStudentRecords.Size = new System.Drawing.Size(588, 553);
            this.displayStudentRecords.TabIndex = 1;
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(4, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Display All Students";
            this.button1.UseVisualStyleBackColor = true;
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
            this.addUpdateStudent.Controls.Add(this.comboBox1);
            this.addUpdateStudent.Controls.Add(this.levelLabel);
            this.addUpdateStudent.Controls.Add(this.label1);
            this.addUpdateStudent.Controls.Add(this.instrumentDropdownBox);
            this.addUpdateStudent.Controls.Add(this.instrumentLabel);
            this.addUpdateStudent.Controls.Add(this.lessonDropdownBox);
            this.addUpdateStudent.Controls.Add(this.lessonLabel);
            this.addUpdateStudent.Controls.Add(this.mobilePhoneField);
            this.addUpdateStudent.Controls.Add(this.mobilePhoneLabel);
            this.addUpdateStudent.Controls.Add(this.landlinePhoneField);
            this.addUpdateStudent.Controls.Add(this.landlinePhoneLabel);
            this.addUpdateStudent.Controls.Add(this.textBox1);
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
            this.sheetMusicListBox.DataSource = this.sheetMusicsBindingSource;
            this.sheetMusicListBox.DisplayMember = "Title";
            this.sheetMusicListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sheetMusicListBox.FormattingEnabled = true;
            this.sheetMusicListBox.Location = new System.Drawing.Point(132, 327);
            this.sheetMusicListBox.Name = "sheetMusicListBox";
            this.sheetMusicListBox.Size = new System.Drawing.Size(229, 82);
            this.sheetMusicListBox.TabIndex = 36;
            this.sheetMusicListBox.ValueMember = "Title";
            // 
            // sheetMusicsBindingSource
            // 
            this.sheetMusicsBindingSource.DataMember = "SheetMusics";
            this.sheetMusicsBindingSource.DataSource = this._attfire1_assignment2_MusicClassesContextDataSet3;
            // 
            // _attfire1_assignment2_MusicClassesContextDataSet3
            // 
            this._attfire1_assignment2_MusicClassesContextDataSet3.DataSetName = "_attfire1_assignment2_MusicClassesContextDataSet3";
            this._attfire1_assignment2_MusicClassesContextDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.ensembleDropdownBox.DataSource = this.ensemblesBindingSource;
            this.ensembleDropdownBox.DisplayMember = "EnsembleName";
            this.ensembleDropdownBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ensembleDropdownBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ensembleDropdownBox.FormattingEnabled = true;
            this.ensembleDropdownBox.Location = new System.Drawing.Point(155, 440);
            this.ensembleDropdownBox.Name = "ensembleDropdownBox";
            this.ensembleDropdownBox.Size = new System.Drawing.Size(206, 24);
            this.ensembleDropdownBox.TabIndex = 28;
            this.ensembleDropdownBox.ValueMember = "EnsembleName";
            // 
            // ensemblesBindingSource
            // 
            this.ensemblesBindingSource.DataMember = "Ensembles";
            this.ensemblesBindingSource.DataSource = this._attfire1_assignment2_MusicClassesContextDataSet4;
            // 
            // _attfire1_assignment2_MusicClassesContextDataSet4
            // 
            this._attfire1_assignment2_MusicClassesContextDataSet4.DataSetName = "_attfire1_assignment2_MusicClassesContextDataSet4";
            this._attfire1_assignment2_MusicClassesContextDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1 (One)",
            "2 (Two)",
            "3 (Three)",
            "4 (Four)",
            "5 (Five)",
            "6 (Six)",
            "7 (Seven)",
            "8 (Eight)"});
            this.comboBox1.Location = new System.Drawing.Point(155, 413);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 26;
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.Location = new System.Drawing.Point(110, 416);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(42, 17);
            this.levelLabel.TabIndex = 25;
            this.levelLabel.Text = "Level";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Sheet Music Items";
            // 
            // instrumentDropdownBox
            // 
            this.instrumentDropdownBox.DataSource = this.instrumentsBindingSource;
            this.instrumentDropdownBox.DisplayMember = "InstrumentName";
            this.instrumentDropdownBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.instrumentDropdownBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instrumentDropdownBox.FormattingEnabled = true;
            this.instrumentDropdownBox.Location = new System.Drawing.Point(132, 300);
            this.instrumentDropdownBox.Name = "instrumentDropdownBox";
            this.instrumentDropdownBox.Size = new System.Drawing.Size(206, 24);
            this.instrumentDropdownBox.TabIndex = 22;
            this.instrumentDropdownBox.ValueMember = "InstrumentName";
            // 
            // instrumentsBindingSource
            // 
            this.instrumentsBindingSource.DataMember = "Instruments";
            this.instrumentsBindingSource.DataSource = this._attfire1_assignment2_MusicClassesContextDataSet1;
            // 
            // _attfire1_assignment2_MusicClassesContextDataSet1
            // 
            this._attfire1_assignment2_MusicClassesContextDataSet1.DataSetName = "_attfire1_assignment2_MusicClassesContextDataSet1";
            this._attfire1_assignment2_MusicClassesContextDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // instrumentLabel
            // 
            this.instrumentLabel.AutoSize = true;
            this.instrumentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instrumentLabel.Location = new System.Drawing.Point(9, 303);
            this.instrumentLabel.Name = "instrumentLabel";
            this.instrumentLabel.Size = new System.Drawing.Size(120, 17);
            this.instrumentLabel.TabIndex = 21;
            this.instrumentLabel.Text = "Instrument to Hire";
            // 
            // lessonDropdownBox
            // 
            this.lessonDropdownBox.DataSource = this.lessonsBindingSource;
            this.lessonDropdownBox.DisplayMember = "LessonName";
            this.lessonDropdownBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lessonDropdownBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessonDropdownBox.FormattingEnabled = true;
            this.lessonDropdownBox.Location = new System.Drawing.Point(132, 273);
            this.lessonDropdownBox.Name = "lessonDropdownBox";
            this.lessonDropdownBox.Size = new System.Drawing.Size(206, 24);
            this.lessonDropdownBox.TabIndex = 20;
            this.lessonDropdownBox.ValueMember = "LessonName";
            // 
            // lessonsBindingSource
            // 
            this.lessonsBindingSource.DataMember = "Lessons";
            this.lessonsBindingSource.DataSource = this._attfire1_assignment2_MusicClassesContextDataSet;
            // 
            // _attfire1_assignment2_MusicClassesContextDataSet
            // 
            this._attfire1_assignment2_MusicClassesContextDataSet.DataSetName = "_attfire1_assignment2_MusicClassesContextDataSet";
            this._attfire1_assignment2_MusicClassesContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lessonLabel
            // 
            this.lessonLabel.AutoSize = true;
            this.lessonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessonLabel.Location = new System.Drawing.Point(7, 276);
            this.lessonLabel.Name = "lessonLabel";
            this.lessonLabel.Size = new System.Drawing.Size(122, 17);
            this.lessonLabel.TabIndex = 19;
            this.lessonLabel.Text = "Lesson to Enrol In";
            // 
            // mobilePhoneField
            // 
            this.mobilePhoneField.Location = new System.Drawing.Point(132, 247);
            this.mobilePhoneField.Name = "mobilePhoneField";
            this.mobilePhoneField.Size = new System.Drawing.Size(176, 23);
            this.mobilePhoneField.TabIndex = 18;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 195);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 23);
            this.textBox1.TabIndex = 14;
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
            this.streetAddressLabel.Click += new System.EventHandler(this.label1_Click_1);
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
            this.firstNameLabel.Click += new System.EventHandler(this.label1_Click);
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
            this.panel1.Controls.Add(this.displayAllTutorsBtn);
            this.panel1.Controls.Add(this.showTutorRecordsLabel);
            this.panel1.Location = new System.Drawing.Point(395, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 553);
            this.panel1.TabIndex = 3;
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
            // displayAllTutorsBtn
            // 
            this.displayAllTutorsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayAllTutorsBtn.Location = new System.Drawing.Point(4, 34);
            this.displayAllTutorsBtn.Name = "displayAllTutorsBtn";
            this.displayAllTutorsBtn.Size = new System.Drawing.Size(142, 29);
            this.displayAllTutorsBtn.TabIndex = 1;
            this.displayAllTutorsBtn.Text = "Display All Tutors";
            this.displayAllTutorsBtn.UseVisualStyleBackColor = true;
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
            this.addUpdateTutorLabel.Click += new System.EventHandler(this.label14_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(992, 577);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sheet Music Records";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(992, 577);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Instrument Records";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 34);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(992, 577);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Performance Records";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 34);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(992, 577);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Ensemble Records";
            this.tabPage6.UseVisualStyleBackColor = true;
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
            // lessonsTableAdapter
            // 
            this.lessonsTableAdapter.ClearBeforeFill = true;
            // 
            // instrumentsTableAdapter
            // 
            this.instrumentsTableAdapter.ClearBeforeFill = true;
            // 
            // sheetMusicsTableAdapter
            // 
            this.sheetMusicsTableAdapter.ClearBeforeFill = true;
            // 
            // ensemblesTableAdapter
            // 
            this.ensemblesTableAdapter.ClearBeforeFill = true;
            // 
            // qualificationsTextbox
            // 
            this.qualificationsTextbox.Location = new System.Drawing.Point(132, 273);
            this.qualificationsTextbox.Name = "qualificationsTextbox";
            this.qualificationsTextbox.Size = new System.Drawing.Size(231, 61);
            this.qualificationsTextbox.TabIndex = 19;
            this.qualificationsTextbox.Text = "";
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
            // lessonsToTeachListbox
            // 
            this.lessonsToTeachListbox.DataSource = this.lessonsBindingSource;
            this.lessonsToTeachListbox.DisplayMember = "LessonName";
            this.lessonsToTeachListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessonsToTeachListbox.FormattingEnabled = true;
            this.lessonsToTeachListbox.Location = new System.Drawing.Point(131, 339);
            this.lessonsToTeachListbox.Name = "lessonsToTeachListbox";
            this.lessonsToTeachListbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lessonsToTeachListbox.Size = new System.Drawing.Size(231, 43);
            this.lessonsToTeachListbox.TabIndex = 23;
            this.lessonsToTeachListbox.ValueMember = "LessonName";
            // 
            // tutorSheetMusicListbox
            // 
            this.tutorSheetMusicListbox.DataSource = this.sheetMusicsBindingSource;
            this.tutorSheetMusicListbox.DisplayMember = "Title";
            this.tutorSheetMusicListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorSheetMusicListbox.FormattingEnabled = true;
            this.tutorSheetMusicListbox.Location = new System.Drawing.Point(131, 386);
            this.tutorSheetMusicListbox.Name = "tutorSheetMusicListbox";
            this.tutorSheetMusicListbox.Size = new System.Drawing.Size(231, 56);
            this.tutorSheetMusicListbox.TabIndex = 38;
            this.tutorSheetMusicListbox.ValueMember = "Title";
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
            // tutorEnsemblesListBox
            // 
            this.tutorEnsemblesListBox.DataSource = this.ensemblesBindingSource;
            this.tutorEnsemblesListBox.DisplayMember = "EnsembleName";
            this.tutorEnsemblesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorEnsemblesListBox.FormattingEnabled = true;
            this.tutorEnsemblesListBox.Location = new System.Drawing.Point(86, 481);
            this.tutorEnsemblesListBox.Name = "tutorEnsemblesListBox";
            this.tutorEnsemblesListBox.Size = new System.Drawing.Size(178, 69);
            this.tutorEnsemblesListBox.TabIndex = 43;
            this.tutorEnsemblesListBox.ValueMember = "EnsembleName";
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
            ((System.ComponentModel.ISupportInitialize)(this.sheetMusicsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._attfire1_assignment2_MusicClassesContextDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ensemblesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._attfire1_assignment2_MusicClassesContextDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._attfire1_assignment2_MusicClassesContextDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._attfire1_assignment2_MusicClassesContextDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainBannerLogo)).EndInit();
            this.levelCheckboxesGroup.ResumeLayout(false);
            this.levelCheckboxesGroup.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox1;
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label levelLabel;
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
        private _attfire1_assignment2_MusicClassesContextDataSet _attfire1_assignment2_MusicClassesContextDataSet;
        private System.Windows.Forms.BindingSource lessonsBindingSource;
        private _attfire1_assignment2_MusicClassesContextDataSetTableAdapters.LessonsTableAdapter lessonsTableAdapter;
        private _attfire1_assignment2_MusicClassesContextDataSet1 _attfire1_assignment2_MusicClassesContextDataSet1;
        private System.Windows.Forms.BindingSource instrumentsBindingSource;
        private _attfire1_assignment2_MusicClassesContextDataSet1TableAdapters.InstrumentsTableAdapter instrumentsTableAdapter;
        private System.Windows.Forms.ListBox sheetMusicListBox;
        private _attfire1_assignment2_MusicClassesContextDataSet3 _attfire1_assignment2_MusicClassesContextDataSet3;
        private System.Windows.Forms.BindingSource sheetMusicsBindingSource;
        private _attfire1_assignment2_MusicClassesContextDataSet3TableAdapters.SheetMusicsTableAdapter sheetMusicsTableAdapter;
        private _attfire1_assignment2_MusicClassesContextDataSet4 _attfire1_assignment2_MusicClassesContextDataSet4;
        private System.Windows.Forms.BindingSource ensemblesBindingSource;
        private _attfire1_assignment2_MusicClassesContextDataSet4TableAdapters.EnsemblesTableAdapter ensemblesTableAdapter;
        private System.Windows.Forms.Panel displayStudentRecords;
        private System.Windows.Forms.Label showStudentRecordsLabel;
        private System.Windows.Forms.ListBox studentRecordsListbox;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.Button displayAllTutorsBtn;
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
    }
}

