namespace Dziennik_v0._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WorkoutValidationAdded : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Workouts", "LengthOfTraining", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Workouts", "LengthOfTraining", c => c.String());
        }
    }
}
