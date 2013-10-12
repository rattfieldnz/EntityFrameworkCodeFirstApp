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
            this.addUpdateStudent = new System.Windows.Forms.Panel();
            this.submitUpdateBtn = new System.Windows.Forms.Button();
            this.totalFeesOwedField = new System.Windows.Forms.TextBox();
            this.totalFeesOwedLabel = new System.Windows.Forms.Label();
            this.instrumentFeesOwedField = new System.Windows.Forms.TextBox();
            this.instrumentFeesOwedLabel = new System.Windows.Forms.Label();
            this.lessonFeesOwedField = new System.Windows.Forms.TextBox();
            this.lessonFeesOwedLabel = new System.Windows.Forms.Label();
            this.ensembleDropdownBox = new System.Windows.Forms.ComboBox();
            this.ensembleLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.levelLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.instrumentDropdownBox = new System.Windows.Forms.ComboBox();
            this.instrumentLabel = new System.Windows.Forms.Label();
            this.lessonDropdownBox = new System.Windows.Forms.ComboBox();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.mainBannerLogo = new System.Windows.Forms.PictureBox();
            this._attfire1_assignment2_MusicClassesContextDataSet = new attfire1_assignment2._attfire1_assignment2_MusicClassesContextDataSet();
            this.lessonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lessonsTableAdapter = new attfire1_assignment2._attfire1_assignment2_MusicClassesContextDataSetTableAdapters.LessonsTableAdapter();
            this._attfire1_assignment2_MusicClassesContextDataSet1 = new attfire1_assignment2._attfire1_assignment2_MusicClassesContextDataSet1();
            this.instrumentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instrumentsTableAdapter = new attfire1_assignment2._attfire1_assignment2_MusicClassesContextDataSet1TableAdapters.InstrumentsTableAdapter();
            this.sheetMusicListBox = new System.Windows.Forms.ListBox();
            this._attfire1_assignment2_MusicClassesContextDataSet3 = new attfire1_assignment2._attfire1_assignment2_MusicClassesContextDataSet3();
            this.sheetMusicsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sheetMusicsTableAdapter = new attfire1_assignment2._attfire1_assignment2_MusicClassesContextDataSet3TableAdapters.SheetMusicsTableAdapter();
            this._attfire1_assignment2_MusicClassesContextDataSet4 = new attfire1_assignment2._attfire1_assignment2_MusicClassesContextDataSet4();
            this.ensemblesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ensemblesTableAdapter = new attfire1_assignment2._attfire1_assignment2_MusicClassesContextDataSet4TableAdapters.EnsemblesTableAdapter();
            this.mainTabGroup.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.addUpdateStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainBannerLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._attfire1_assignment2_MusicClassesContextDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._attfire1_assignment2_MusicClassesContextDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._attfire1_assignment2_MusicClassesContextDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheetMusicsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._attfire1_assignment2_MusicClassesContextDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ensemblesBindingSource)).BeginInit();
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
            this.tabPage1.Controls.Add(this.addUpdateStudent);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(992, 577);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Student Records";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // submitUpdateBtn
            // 
            this.submitUpdateBtn.Location = new System.Drawing.Point(267, 509);
            this.submitUpdateBtn.Name = "submitUpdateBtn";
            this.submitUpdateBtn.Size = new System.Drawing.Size(94, 37);
            this.submitUpdateBtn.TabIndex = 35;
            this.submitUpdateBtn.Text = "Submit / Update";
            this.submitUpdateBtn.UseVisualStyleBackColor = true;
            // 
            // totalFeesOwedField
            // 
            this.totalFeesOwedField.Location = new System.Drawing.Point(155, 520);
            this.totalFeesOwedField.Name = "totalFeesOwedField";
            this.totalFeesOwedField.Size = new System.Drawing.Size(100, 20);
            this.totalFeesOwedField.TabIndex = 34;
            // 
            // totalFeesOwedLabel
            // 
            this.totalFeesOwedLabel.AutoSize = true;
            this.totalFeesOwedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalFeesOwedLabel.Location = new System.Drawing.Point(33, 522);
            this.totalFeesOwedLabel.Name = "totalFeesOwedLabel";
            this.totalFeesOwedLabel.Size = new System.Drawing.Size(115, 17);
            this.totalFeesOwedLabel.TabIndex = 33;
            this.totalFeesOwedLabel.Text = "Total Fees Owed";
            // 
            // instrumentFeesOwedField
            // 
            this.instrumentFeesOwedField.Location = new System.Drawing.Point(155, 493);
            this.instrumentFeesOwedField.Name = "instrumentFeesOwedField";
            this.instrumentFeesOwedField.Size = new System.Drawing.Size(100, 20);
            this.instrumentFeesOwedField.TabIndex = 32;
            // 
            // instrumentFeesOwedLabel
            // 
            this.instrumentFeesOwedLabel.AutoSize = true;
            this.instrumentFeesOwedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instrumentFeesOwedLabel.Location = new System.Drawing.Point(-1, 495);
            this.instrumentFeesOwedLabel.Name = "instrumentFeesOwedLabel";
            this.instrumentFeesOwedLabel.Size = new System.Drawing.Size(149, 17);
            this.instrumentFeesOwedLabel.TabIndex = 31;
            this.instrumentFeesOwedLabel.Text = "Instrument Fees Owed";
            // 
            // lessonFeesOwedField
            // 
            this.lessonFeesOwedField.Location = new System.Drawing.Point(155, 467);
            this.lessonFeesOwedField.Name = "lessonFeesOwedField";
            this.lessonFeesOwedField.Size = new System.Drawing.Size(100, 20);
            this.lessonFeesOwedField.TabIndex = 30;
            // 
            // lessonFeesOwedLabel
            // 
            this.lessonFeesOwedLabel.AutoSize = true;
            this.lessonFeesOwedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessonFeesOwedLabel.Location = new System.Drawing.Point(19, 468);
            this.lessonFeesOwedLabel.Name = "lessonFeesOwedLabel";
            this.lessonFeesOwedLabel.Size = new System.Drawing.Size(129, 17);
            this.lessonFeesOwedLabel.TabIndex = 29;
            this.lessonFeesOwedLabel.Text = "Lesson Fees Owed";
            // 
            // ensembleDropdownBox
            // 
            this.ensembleDropdownBox.DataSource = this.ensemblesBindingSource;
            this.ensembleDropdownBox.DisplayMember = "EnsembleName";
            this.ensembleDropdownBox.FormattingEnabled = true;
            this.ensembleDropdownBox.Location = new System.Drawing.Point(155, 440);
            this.ensembleDropdownBox.Name = "ensembleDropdownBox";
            this.ensembleDropdownBox.Size = new System.Drawing.Size(206, 21);
            this.ensembleDropdownBox.TabIndex = 28;
            this.ensembleDropdownBox.ValueMember = "EnsembleName";
            // 
            // ensembleLabel
            // 
            this.ensembleLabel.AutoSize = true;
            this.ensembleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ensembleLabel.Location = new System.Drawing.Point(78, 441);
            this.ensembleLabel.Name = "ensembleLabel";
            this.ensembleLabel.Size = new System.Drawing.Size(70, 17);
            this.ensembleLabel.TabIndex = 27;
            this.ensembleLabel.Text = "Ensemble";
            // 
            // comboBox1
            // 
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
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 26;
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.Location = new System.Drawing.Point(106, 414);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(42, 17);
            this.levelLabel.TabIndex = 25;
            this.levelLabel.Text = "Level";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Sheet Music Items";
            // 
            // instrumentDropdownBox
            // 
            this.instrumentDropdownBox.DataSource = this.instrumentsBindingSource;
            this.instrumentDropdownBox.DisplayMember = "InstrumentName";
            this.instrumentDropdownBox.FormattingEnabled = true;
            this.instrumentDropdownBox.Location = new System.Drawing.Point(155, 300);
            this.instrumentDropdownBox.Name = "instrumentDropdownBox";
            this.instrumentDropdownBox.Size = new System.Drawing.Size(206, 21);
            this.instrumentDropdownBox.TabIndex = 22;
            this.instrumentDropdownBox.ValueMember = "InstrumentName";
            // 
            // instrumentLabel
            // 
            this.instrumentLabel.AutoSize = true;
            this.instrumentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instrumentLabel.Location = new System.Drawing.Point(26, 302);
            this.instrumentLabel.Name = "instrumentLabel";
            this.instrumentLabel.Size = new System.Drawing.Size(120, 17);
            this.instrumentLabel.TabIndex = 21;
            this.instrumentLabel.Text = "Instrument to Hire";
            // 
            // lessonDropdownBox
            // 
            this.lessonDropdownBox.DataSource = this.lessonsBindingSource;
            this.lessonDropdownBox.DisplayMember = "LessonName";
            this.lessonDropdownBox.FormattingEnabled = true;
            this.lessonDropdownBox.Location = new System.Drawing.Point(155, 273);
            this.lessonDropdownBox.Name = "lessonDropdownBox";
            this.lessonDropdownBox.Size = new System.Drawing.Size(206, 21);
            this.lessonDropdownBox.TabIndex = 20;
            this.lessonDropdownBox.ValueMember = "LessonName";
            // 
            // lessonLabel
            // 
            this.lessonLabel.AutoSize = true;
            this.lessonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessonLabel.Location = new System.Drawing.Point(26, 275);
            this.lessonLabel.Name = "lessonLabel";
            this.lessonLabel.Size = new System.Drawing.Size(122, 17);
            this.lessonLabel.TabIndex = 19;
            this.lessonLabel.Text = "Lesson to Enrol In";
            // 
            // mobilePhoneField
            // 
            this.mobilePhoneField.Location = new System.Drawing.Point(155, 247);
            this.mobilePhoneField.Name = "mobilePhoneField";
            this.mobilePhoneField.Size = new System.Drawing.Size(176, 20);
            this.mobilePhoneField.TabIndex = 18;
            // 
            // mobilePhoneLabel
            // 
            this.mobilePhoneLabel.AutoSize = true;
            this.mobilePhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobilePhoneLabel.Location = new System.Drawing.Point(54, 248);
            this.mobilePhoneLabel.Name = "mobilePhoneLabel";
            this.mobilePhoneLabel.Size = new System.Drawing.Size(94, 17);
            this.mobilePhoneLabel.TabIndex = 17;
            this.mobilePhoneLabel.Text = "Mobile Phone";
            // 
            // landlinePhoneField
            // 
            this.landlinePhoneField.Location = new System.Drawing.Point(155, 221);
            this.landlinePhoneField.Name = "landlinePhoneField";
            this.landlinePhoneField.Size = new System.Drawing.Size(177, 20);
            this.landlinePhoneField.TabIndex = 16;
            // 
            // landlinePhoneLabel
            // 
            this.landlinePhoneLabel.AutoSize = true;
            this.landlinePhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.landlinePhoneLabel.Location = new System.Drawing.Point(41, 223);
            this.landlinePhoneLabel.Name = "landlinePhoneLabel";
            this.landlinePhoneLabel.Size = new System.Drawing.Size(107, 17);
            this.landlinePhoneLabel.TabIndex = 15;
            this.landlinePhoneLabel.Text = "Landline Phone";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 195);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 20);
            this.textBox1.TabIndex = 14;
            // 
            // townOrCityLabel
            // 
            this.townOrCityLabel.AutoSize = true;
            this.townOrCityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.townOrCityLabel.Location = new System.Drawing.Point(62, 196);
            this.townOrCityLabel.Name = "townOrCityLabel";
            this.townOrCityLabel.Size = new System.Drawing.Size(86, 17);
            this.townOrCityLabel.TabIndex = 13;
            this.townOrCityLabel.Text = "Town or City";
            // 
            // postCodeField
            // 
            this.postCodeField.Location = new System.Drawing.Point(155, 169);
            this.postCodeField.Name = "postCodeField";
            this.postCodeField.Size = new System.Drawing.Size(74, 20);
            this.postCodeField.TabIndex = 12;
            // 
            // postCodeLabel
            // 
            this.postCodeLabel.AutoSize = true;
            this.postCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postCodeLabel.Location = new System.Drawing.Point(75, 170);
            this.postCodeLabel.Name = "postCodeLabel";
            this.postCodeLabel.Size = new System.Drawing.Size(73, 17);
            this.postCodeLabel.TabIndex = 11;
            this.postCodeLabel.Text = "Post Code";
            // 
            // suburbField
            // 
            this.suburbField.Location = new System.Drawing.Point(155, 143);
            this.suburbField.Name = "suburbField";
            this.suburbField.Size = new System.Drawing.Size(177, 20);
            this.suburbField.TabIndex = 10;
            // 
            // suburbLabel
            // 
            this.suburbLabel.AutoSize = true;
            this.suburbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suburbLabel.Location = new System.Drawing.Point(94, 145);
            this.suburbLabel.Name = "suburbLabel";
            this.suburbLabel.Size = new System.Drawing.Size(54, 17);
            this.suburbLabel.TabIndex = 9;
            this.suburbLabel.Text = "Suburb";
            // 
            // streetAddressField
            // 
            this.streetAddressField.Location = new System.Drawing.Point(155, 117);
            this.streetAddressField.Name = "streetAddressField";
            this.streetAddressField.Size = new System.Drawing.Size(177, 20);
            this.streetAddressField.TabIndex = 8;
            // 
            // streetAddressLabel
            // 
            this.streetAddressLabel.AutoSize = true;
            this.streetAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetAddressLabel.Location = new System.Drawing.Point(46, 118);
            this.streetAddressLabel.Name = "streetAddressLabel";
            this.streetAddressLabel.Size = new System.Drawing.Size(102, 17);
            this.streetAddressLabel.TabIndex = 7;
            this.streetAddressLabel.Text = "Street Address";
            this.streetAddressLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ageField
            // 
            this.ageField.Location = new System.Drawing.Point(155, 91);
            this.ageField.Name = "ageField";
            this.ageField.Size = new System.Drawing.Size(57, 20);
            this.ageField.TabIndex = 6;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.Location = new System.Drawing.Point(115, 92);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(33, 17);
            this.ageLabel.TabIndex = 5;
            this.ageLabel.Text = "Age";
            // 
            // lastNameField
            // 
            this.lastNameField.Location = new System.Drawing.Point(155, 66);
            this.lastNameField.Name = "lastNameField";
            this.lastNameField.Size = new System.Drawing.Size(176, 20);
            this.lastNameField.TabIndex = 4;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(72, 67);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(76, 17);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameField
            // 
            this.firstNameField.Location = new System.Drawing.Point(155, 42);
            this.firstNameField.Name = "firstNameField";
            this.firstNameField.Size = new System.Drawing.Size(176, 20);
            this.firstNameField.TabIndex = 2;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(72, 43);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(992, 577);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tutor Records";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // _attfire1_assignment2_MusicClassesContextDataSet
            // 
            this._attfire1_assignment2_MusicClassesContextDataSet.DataSetName = "_attfire1_assignment2_MusicClassesContextDataSet";
            this._attfire1_assignment2_MusicClassesContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lessonsBindingSource
            // 
            this.lessonsBindingSource.DataMember = "Lessons";
            this.lessonsBindingSource.DataSource = this._attfire1_assignment2_MusicClassesContextDataSet;
            // 
            // lessonsTableAdapter
            // 
            this.lessonsTableAdapter.ClearBeforeFill = true;
            // 
            // _attfire1_assignment2_MusicClassesContextDataSet1
            // 
            this._attfire1_assignment2_MusicClassesContextDataSet1.DataSetName = "_attfire1_assignment2_MusicClassesContextDataSet1";
            this._attfire1_assignment2_MusicClassesContextDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // instrumentsBindingSource
            // 
            this.instrumentsBindingSource.DataMember = "Instruments";
            this.instrumentsBindingSource.DataSource = this._attfire1_assignment2_MusicClassesContextDataSet1;
            // 
            // instrumentsTableAdapter
            // 
            this.instrumentsTableAdapter.ClearBeforeFill = true;
            // 
            // sheetMusicListBox
            // 
            this.sheetMusicListBox.DataSource = this.sheetMusicsBindingSource;
            this.sheetMusicListBox.DisplayMember = "Title";
            this.sheetMusicListBox.FormattingEnabled = true;
            this.sheetMusicListBox.Location = new System.Drawing.Point(155, 327);
            this.sheetMusicListBox.Name = "sheetMusicListBox";
            this.sheetMusicListBox.Size = new System.Drawing.Size(206, 82);
            this.sheetMusicListBox.TabIndex = 36;
            this.sheetMusicListBox.ValueMember = "Title";
            // 
            // _attfire1_assignment2_MusicClassesContextDataSet3
            // 
            this._attfire1_assignment2_MusicClassesContextDataSet3.DataSetName = "_attfire1_assignment2_MusicClassesContextDataSet3";
            this._attfire1_assignment2_MusicClassesContextDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sheetMusicsBindingSource
            // 
            this.sheetMusicsBindingSource.DataMember = "SheetMusics";
            this.sheetMusicsBindingSource.DataSource = this._attfire1_assignment2_MusicClassesContextDataSet3;
            // 
            // sheetMusicsTableAdapter
            // 
            this.sheetMusicsTableAdapter.ClearBeforeFill = true;
            // 
            // _attfire1_assignment2_MusicClassesContextDataSet4
            // 
            this._attfire1_assignment2_MusicClassesContextDataSet4.DataSetName = "_attfire1_assignment2_MusicClassesContextDataSet4";
            this._attfire1_assignment2_MusicClassesContextDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ensemblesBindingSource
            // 
            this.ensemblesBindingSource.DataMember = "Ensembles";
            this.ensemblesBindingSource.DataSource = this._attfire1_assignment2_MusicClassesContextDataSet4;
            // 
            // ensemblesTableAdapter
            // 
            this.ensemblesTableAdapter.ClearBeforeFill = true;
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
            this.addUpdateStudent.ResumeLayout(false);
            this.addUpdateStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainBannerLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._attfire1_assignment2_MusicClassesContextDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._attfire1_assignment2_MusicClassesContextDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._attfire1_assignment2_MusicClassesContextDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheetMusicsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._attfire1_assignment2_MusicClassesContextDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ensemblesBindingSource)).EndInit();
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
    }
}

