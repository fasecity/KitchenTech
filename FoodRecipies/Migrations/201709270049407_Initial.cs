namespace FoodRecipies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IngredientsModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Ammount = c.String(),
                        Quntity = c.Int(),
                        Prep = c.String(),
                        Dated = c.DateTime(nullable: false),
                        RecipiesModels_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RecipiesModels", t => t.RecipiesModels_Id)
                .Index(t => t.RecipiesModels_Id);
            
            CreateTable(
                "dbo.RecipiesModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PostedDate = c.DateTime(nullable: false),
                        Description = c.String(),
                        Directions = c.String(),
                        Cooktime = c.Int(nullable: false),
                        Servings = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IngredientsModels", "RecipiesModels_Id", "dbo.RecipiesModels");
            DropIndex("dbo.IngredientsModels", new[] { "RecipiesModels_Id" });
            DropTable("dbo.RecipiesModels");
            DropTable("dbo.IngredientsModels");
        }
    }
}
