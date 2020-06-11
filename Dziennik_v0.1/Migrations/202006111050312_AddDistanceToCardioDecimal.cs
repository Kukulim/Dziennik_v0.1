namespace Dziennik_v0._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDistanceToCardioDecimal : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cardios", "Distance", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cardios", "Distance", c => c.Double(nullable: false));
        }
    }
}
