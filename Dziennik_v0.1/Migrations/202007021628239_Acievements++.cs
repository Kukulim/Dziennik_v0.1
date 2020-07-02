namespace Dziennik_v0._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Acievements : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Achievements", "Value", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "AchievementsPoints", c => c.Int(nullable: false));
            AlterColumn("dbo.Achievements", "TraningType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Achievements", "TraningType", c => c.String());
            DropColumn("dbo.AspNetUsers", "AchievementsPoints");
            DropColumn("dbo.Achievements", "Value");
        }
    }
}
