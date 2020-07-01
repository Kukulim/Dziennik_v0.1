namespace Dziennik_v0._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class achievementModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Achievements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Acquired = c.Boolean(nullable: false),
                        AcquiredDate = c.DateTime(nullable: false),
                        TraningType = c.String(),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Achievements", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Achievements", new[] { "UserId" });
            DropTable("dbo.Achievements");
        }
    }
}
