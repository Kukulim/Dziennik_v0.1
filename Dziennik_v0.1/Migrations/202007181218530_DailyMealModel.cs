namespace Dziennik_v0._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DailyMealModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DailyMenus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DailyMenuDate = c.DateTime(nullable: false),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.FoodModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Calories = c.Int(nullable: false),
                        Protein = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Carbohydrates = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Fat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weight = c.Int(nullable: false),
                        MealType = c.Int(nullable: false),
                        DailyMenuId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DailyMenus", t => t.DailyMenuId, cascadeDelete: true)
                .Index(t => t.DailyMenuId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DailyMenus", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.FoodModels", "DailyMenuId", "dbo.DailyMenus");
            DropIndex("dbo.FoodModels", new[] { "DailyMenuId" });
            DropIndex("dbo.DailyMenus", new[] { "UserId" });
            DropTable("dbo.FoodModels");
            DropTable("dbo.DailyMenus");
        }
    }
}
