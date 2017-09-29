namespace FoodRecipies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edit1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RecipiesModels", "Name", c => c.Int(nullable: false));
            DropColumn("dbo.IngredientsModels", "Quantity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.IngredientsModels", "Quantity", c => c.Int());
            DropColumn("dbo.RecipiesModels", "Name");
        }
    }
}
