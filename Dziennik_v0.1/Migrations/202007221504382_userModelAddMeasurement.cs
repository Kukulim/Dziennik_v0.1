namespace Dziennik_v0._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userModelAddMeasurement : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Measurements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Weight = c.Single(nullable: false),
                        Date = c.DateTime(nullable: false),
                        CaloricRequirement = c.Single(nullable: false),
                        UserId = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            DropColumn("dbo.AspNetUsers", "Weight");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Weight", c => c.Single(nullable: false));
            DropForeignKey("dbo.Measurements", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Measurements", new[] { "ApplicationUser_Id" });
            DropTable("dbo.Measurements");
        }
    }
}
