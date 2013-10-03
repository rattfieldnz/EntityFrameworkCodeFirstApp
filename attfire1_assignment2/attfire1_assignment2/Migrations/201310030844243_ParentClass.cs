namespace attfire1_assignment2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ParentClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Parents",
                c => new
                    {
                        ParentId = c.Int(nullable: false, identity: true),
                        PersonPersonId = c.Int(nullable: false),
                        ParentParentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ParentId)
                .ForeignKey("dbo.People", t => t.PersonPersonId, cascadeDelete: true)
                .ForeignKey("dbo.Parents", t => t.ParentParentId)
                .Index(t => t.PersonPersonId)
                .Index(t => t.ParentParentId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        Age = c.Short(nullable: false),
                        PersonPersonId = c.Int(nullable: false),
                        InstrumentInstrumentId = c.Int(),
                        ParentParentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.People", t => t.PersonPersonId, cascadeDelete: true)
                .ForeignKey("dbo.Instruments", t => t.InstrumentInstrumentId)
                .ForeignKey("dbo.Parents", t => t.ParentParentId, cascadeDelete: true)
                .Index(t => t.PersonPersonId)
                .Index(t => t.InstrumentInstrumentId)
                .Index(t => t.ParentParentId);
            
            CreateTable(
                "dbo.StudentLessons",
                c => new
                    {
                        StudentStudentId = c.Int(nullable: false),
                        LessonLessonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.StudentStudentId, t.LessonLessonId })
                .ForeignKey("dbo.Students", t => t.StudentStudentId, cascadeDelete: true)
                .ForeignKey("dbo.Lessons", t => t.LessonLessonId, cascadeDelete: true)
                .Index(t => t.StudentStudentId)
                .Index(t => t.LessonLessonId);
            
            CreateTable(
                "dbo.Lessons",
                c => new
                    {
                        LessonId = c.Int(nullable: false, identity: true),
                        LessonName = c.String(),
                        Location = c.String(),
                        Subject = c.String(),
                        MaxStudents = c.Short(nullable: false),
                        TutorTutorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LessonId)
                .ForeignKey("dbo.Tutors", t => t.TutorTutorId, cascadeDelete: true)
                .Index(t => t.TutorTutorId);
            
            CreateTable(
                "dbo.Tutors",
                c => new
                    {
                        TutorId = c.Int(nullable: false, identity: true),
                        PersonPersonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TutorId)
                .ForeignKey("dbo.People", t => t.PersonPersonId, cascadeDelete: true)
                .Index(t => t.PersonPersonId);
            
            CreateTable(
                "dbo.TutorPositionsHelds",
                c => new
                    {
                        PositionsHeldPositionId = c.Int(nullable: false),
                        TutorTutorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PositionsHeldPositionId, t.TutorTutorId })
                .ForeignKey("dbo.PositionsHelds", t => t.PositionsHeldPositionId, cascadeDelete: true)
                .ForeignKey("dbo.Tutors", t => t.TutorTutorId, cascadeDelete: true)
                .Index(t => t.PositionsHeldPositionId)
                .Index(t => t.TutorTutorId);
            
            CreateTable(
                "dbo.PositionsHelds",
                c => new
                    {
                        PositionId = c.Int(nullable: false, identity: true),
                        PositionName = c.String(),
                    })
                .PrimaryKey(t => t.PositionId);
            
            CreateTable(
                "dbo.Instruments",
                c => new
                    {
                        InstrumentId = c.Int(nullable: false, identity: true),
                        InstrumentName = c.String(),
                        HireFee = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Condition = c.String(),
                        RepairStatus = c.String(),
                    })
                .PrimaryKey(t => t.InstrumentId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.TutorPositionsHelds", new[] { "TutorTutorId" });
            DropIndex("dbo.TutorPositionsHelds", new[] { "PositionsHeldPositionId" });
            DropIndex("dbo.Tutors", new[] { "PersonPersonId" });
            DropIndex("dbo.Lessons", new[] { "TutorTutorId" });
            DropIndex("dbo.StudentLessons", new[] { "LessonLessonId" });
            DropIndex("dbo.StudentLessons", new[] { "StudentStudentId" });
            DropIndex("dbo.Students", new[] { "ParentParentId" });
            DropIndex("dbo.Students", new[] { "InstrumentInstrumentId" });
            DropIndex("dbo.Students", new[] { "PersonPersonId" });
            DropIndex("dbo.Parents", new[] { "ParentParentId" });
            DropIndex("dbo.Parents", new[] { "PersonPersonId" });
            DropForeignKey("dbo.TutorPositionsHelds", "TutorTutorId", "dbo.Tutors");
            DropForeignKey("dbo.TutorPositionsHelds", "PositionsHeldPositionId", "dbo.PositionsHelds");
            DropForeignKey("dbo.Tutors", "PersonPersonId", "dbo.People");
            DropForeignKey("dbo.Lessons", "TutorTutorId", "dbo.Tutors");
            DropForeignKey("dbo.StudentLessons", "LessonLessonId", "dbo.Lessons");
            DropForeignKey("dbo.StudentLessons", "StudentStudentId", "dbo.Students");
            DropForeignKey("dbo.Students", "ParentParentId", "dbo.Parents");
            DropForeignKey("dbo.Students", "InstrumentInstrumentId", "dbo.Instruments");
            DropForeignKey("dbo.Students", "PersonPersonId", "dbo.People");
            DropForeignKey("dbo.Parents", "ParentParentId", "dbo.Parents");
            DropForeignKey("dbo.Parents", "PersonPersonId", "dbo.People");
            DropTable("dbo.Instruments");
            DropTable("dbo.PositionsHelds");
            DropTable("dbo.TutorPositionsHelds");
            DropTable("dbo.Tutors");
            DropTable("dbo.Lessons");
            DropTable("dbo.StudentLessons");
            DropTable("dbo.Students");
            DropTable("dbo.Parents");
        }
    }
}
