namespace attfire1_assignment2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Lesson_v1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Lessons", "StudentFee", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Lessons", "OpenFee", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Lessons", "LessonName", c => c.String(nullable: false));
            AlterColumn("dbo.Lessons", "Location", c => c.String(nullable: false));
            AlterColumn("dbo.Lessons", "Subject", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Lessons", "Subject", c => c.String());
            AlterColumn("dbo.Lessons", "Location", c => c.String());
            AlterColumn("dbo.Lessons", "LessonName", c => c.String());
            DropColumn("dbo.Lessons", "OpenFee");
            DropColumn("dbo.Lessons", "StudentFee");
        }
    }
}
