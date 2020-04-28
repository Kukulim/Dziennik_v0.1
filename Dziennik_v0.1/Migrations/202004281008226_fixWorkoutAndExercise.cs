namespace Dziennik_v0._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixWorkoutAndExercise : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Exercises", "Workout_Id", "dbo.Workouts");
            DropIndex("dbo.Exercises", new[] { "Workout_Id" });
            RenameColumn(table: "dbo.Exercises", name: "Workout_Id", newName: "WorkoutId");
            AddColumn("dbo.Workouts", "UserId", c => c.Int(nullable: false));
            AlterColumn("dbo.Exercises", "WorkoutId", c => c.Int(nullable: false));
            CreateIndex("dbo.Exercises", "WorkoutId");
            AddForeignKey("dbo.Exercises", "WorkoutId", "dbo.Workouts", "Id", cascadeDelete: true);
            DropColumn("dbo.Exercises", "TreningId");
            DropColumn("dbo.Workouts", "ExerciseId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Workouts", "ExerciseId", c => c.Int(nullable: false));
            AddColumn("dbo.Exercises", "TreningId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Exercises", "WorkoutId", "dbo.Workouts");
            DropIndex("dbo.Exercises", new[] { "WorkoutId" });
            AlterColumn("dbo.Exercises", "WorkoutId", c => c.Int());
            DropColumn("dbo.Workouts", "UserId");
            RenameColumn(table: "dbo.Exercises", name: "WorkoutId", newName: "Workout_Id");
            CreateIndex("dbo.Exercises", "Workout_Id");
            AddForeignKey("dbo.Exercises", "Workout_Id", "dbo.Workouts", "Id");
        }
    }
}
