namespace Dziennik_v0._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDistanceToCardio : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cardios", "Distance", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cardios", "Distance");
        }
    }
}
