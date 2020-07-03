namespace Dziennik_v0._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AchievementsAddUrlAndDescription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Achievements", "Description", c => c.String());
            AddColumn("dbo.Achievements", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Achievements", "ImageUrl");
            DropColumn("dbo.Achievements", "Description");
        }
    }
}
