namespace Dziennik_v0._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class expUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Age", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "Weight", c => c.Single(nullable: false));
            AddColumn("dbo.AspNetUsers", "Height", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "BodyFat", c => c.Single(nullable: false));
            AddColumn("dbo.AspNetUsers", "Sex", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Sex");
            DropColumn("dbo.AspNetUsers", "BodyFat");
            DropColumn("dbo.AspNetUsers", "Height");
            DropColumn("dbo.AspNetUsers", "Weight");
            DropColumn("dbo.AspNetUsers", "Age");
        }
    }
}
