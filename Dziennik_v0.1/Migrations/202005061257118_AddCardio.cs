namespace Dziennik_v0._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCardio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cardios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        LengthOfTraining = c.String(nullable: false),
                        CardioType = c.Int(nullable: false),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cardios", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Cardios", new[] { "UserId" });
            DropTable("dbo.Cardios");
        }
    }
}
