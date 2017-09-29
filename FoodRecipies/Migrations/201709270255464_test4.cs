namespace FoodRecipies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test4 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.IngredientsModels", "RecipieName");
            DropColumn("dbo.RecipiesModels", "PostedDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RecipiesModels", "PostedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.IngredientsModels", "RecipieName", c => c.String());
        }
    }
}
