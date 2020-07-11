namespace Dziennik_v0._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AchievUserNewProps : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Achievements", "IsNew", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "Target", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Target");
            DropColumn("dbo.Achievements", "IsNew");
        }
    }
}
