namespace Dziennik_v0._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserIdIsString : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Workouts", new[] { "User_Id" });
            DropColumn("dbo.Workouts", "UserId");
            RenameColumn(table: "dbo.Workouts", name: "User_Id", newName: "UserId");
            AlterColumn("dbo.Workouts", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Workouts", "UserId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Workouts", new[] { "UserId" });
            AlterColumn("dbo.Workouts", "UserId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Workouts", name: "UserId", newName: "User_Id");
            AddColumn("dbo.Workouts", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Workouts", "User_Id");
        }
    }
}
