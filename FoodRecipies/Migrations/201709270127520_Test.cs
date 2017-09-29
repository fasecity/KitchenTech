namespace FoodRecipies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.IngredientsModels", "RecipeModelsId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.IngredientsModels", "RecipeModelsId");
        }
    }
}
