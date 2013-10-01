namespace attfire1_assignment2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ensembles",
                c => new
                    {
                        EnsembleId = c.Int(nullable: false, identity: true),
                        EnsembleName = c.String(),
                        EnsembleLevel = c.Short(nullable: false),
                        EnsembleLevelDesc = c.String(),
                    })
                .PrimaryKey(t => t.EnsembleId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        StreetAddress = c.String(),
                        Suburb = c.String(),
                        Postcode = c.Short(nullable: false),
                        EnsembleEnsembleId = c.Int(),
                    })
                .PrimaryKey(t => t.PersonId)
                .ForeignKey("dbo.Ensembles", t => t.EnsembleEnsembleId)
                .Index(t => t.EnsembleEnsembleId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.People", new[] { "EnsembleEnsembleId" });
            DropForeignKey("dbo.People", "EnsembleEnsembleId", "dbo.Ensembles");
            DropTable("dbo.People");
            DropTable("dbo.Ensembles");
        }
    }
}
