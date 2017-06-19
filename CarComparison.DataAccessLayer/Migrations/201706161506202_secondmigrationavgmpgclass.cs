namespace CarComparison.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondmigrationavgmpgclass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AvgMpgs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        year = c.Int(nullable: false),
                        AvgMPG = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AvgMpgs");
        }
    }
}
