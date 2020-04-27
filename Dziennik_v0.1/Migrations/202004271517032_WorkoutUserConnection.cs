namespace Dziennik_v0._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WorkoutUserConnection : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Name", c => c.String());
            AddColumn("dbo.Workouts", "User_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Workouts", "User_Id");
            AddForeignKey("dbo.Workouts", "User_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Workouts", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Workouts", new[] { "User_Id" });
            DropColumn("dbo.Workouts", "User_Id");
            DropColumn("dbo.AspNetUsers", "Name");
        }
    }
}
