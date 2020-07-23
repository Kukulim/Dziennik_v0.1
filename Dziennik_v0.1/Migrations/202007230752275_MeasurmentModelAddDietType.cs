namespace Dziennik_v0._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MeasurmentModelAddDietType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Measurements", "DietType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Measurements", "DietType");
        }
    }
}
