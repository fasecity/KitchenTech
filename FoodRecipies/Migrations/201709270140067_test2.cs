namespace FoodRecipies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.IngredientsModels", "Quantity", c => c.Int());
            AddColumn("dbo.IngredientsModels", "RecipieName", c => c.String());
            DropColumn("dbo.IngredientsModels", "Quntity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.IngredientsModels", "Quntity", c => c.Int());
            DropColumn("dbo.IngredientsModels", "RecipieName");
            DropColumn("dbo.IngredientsModels", "Quantity");
        }
    }
}
