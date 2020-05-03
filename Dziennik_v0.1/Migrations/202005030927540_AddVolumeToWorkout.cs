namespace Dziennik_v0._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddVolumeToWorkout : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Workouts", "WorkoutVolume", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Workouts", "WorkoutVolume");
        }
    }
}
