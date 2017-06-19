namespace CarComparison.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        CarID = c.Int(nullable: false, identity: true),
                        Make = c.String(),
                        Model = c.String(),
                        color = c.String(),
                        year = c.Int(nullable: false),
                        price = c.Double(nullable: false),
                        TCCRating = c.Single(nullable: false),
                        HwyMPG = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.CarID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cars");
        }
    }
}
