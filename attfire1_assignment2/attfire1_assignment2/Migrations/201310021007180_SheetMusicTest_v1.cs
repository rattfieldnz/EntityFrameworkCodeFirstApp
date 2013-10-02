namespace attfire1_assignment2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SheetMusicTest_v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SheetMusics",
                c => new
                    {
                        SheetMusicId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        ComposerName = c.String(nullable: false),
                        DifficultyLevel = c.Short(nullable: false),
                        NumberOfAuthCopies = c.Short(nullable: false),
                        ScoreType = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.SheetMusicId);
            
            CreateTable(
                "dbo.PerformanceSheetMusics",
                c => new
                    {
                        SheetMusicSheetMusicId = c.Int(nullable: false),
                        PerformancePerformanceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SheetMusicSheetMusicId, t.PerformancePerformanceId })
                .ForeignKey("dbo.SheetMusics", t => t.SheetMusicSheetMusicId, cascadeDelete: true)
                .ForeignKey("dbo.Performances", t => t.PerformancePerformanceId, cascadeDelete: true)
                .Index(t => t.SheetMusicSheetMusicId)
                .Index(t => t.PerformancePerformanceId);
            
            CreateTable(
                "dbo.Performances",
                c => new
                    {
                        PerformanceId = c.Int(nullable: false, identity: true),
                        PerformanceName = c.String(),
                        DateAndTime = c.DateTime(nullable: false),
                        LocationLocationId = c.Int(),
                    })
                .PrimaryKey(t => t.PerformanceId)
                .ForeignKey("dbo.Locations", t => t.LocationLocationId)
                .Index(t => t.LocationLocationId);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        LocationId = c.Int(nullable: false, identity: true),
                        LocationName = c.String(),
                    })
                .PrimaryKey(t => t.LocationId);
            
            CreateTable(
                "dbo.PersonSheetMusics",
                c => new
                    {
                        PersonPersonId = c.Int(nullable: false),
                        SheetMusicSheetMusicId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PersonPersonId, t.SheetMusicSheetMusicId })
                .ForeignKey("dbo.People", t => t.PersonPersonId, cascadeDelete: true)
                .ForeignKey("dbo.SheetMusics", t => t.SheetMusicSheetMusicId, cascadeDelete: true)
                .Index(t => t.PersonPersonId)
                .Index(t => t.SheetMusicSheetMusicId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.PersonSheetMusics", new[] { "SheetMusicSheetMusicId" });
            DropIndex("dbo.PersonSheetMusics", new[] { "PersonPersonId" });
            DropIndex("dbo.Performances", new[] { "LocationLocationId" });
            DropIndex("dbo.PerformanceSheetMusics", new[] { "PerformancePerformanceId" });
            DropIndex("dbo.PerformanceSheetMusics", new[] { "SheetMusicSheetMusicId" });
            DropForeignKey("dbo.PersonSheetMusics", "SheetMusicSheetMusicId", "dbo.SheetMusics");
            DropForeignKey("dbo.PersonSheetMusics", "PersonPersonId", "dbo.People");
            DropForeignKey("dbo.Performances", "LocationLocationId", "dbo.Locations");
            DropForeignKey("dbo.PerformanceSheetMusics", "PerformancePerformanceId", "dbo.Performances");
            DropForeignKey("dbo.PerformanceSheetMusics", "SheetMusicSheetMusicId", "dbo.SheetMusics");
            DropTable("dbo.PersonSheetMusics");
            DropTable("dbo.Locations");
            DropTable("dbo.Performances");
            DropTable("dbo.PerformanceSheetMusics");
            DropTable("dbo.SheetMusics");
        }
    }
}
