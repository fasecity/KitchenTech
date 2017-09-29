namespace FoodRecipies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.IngredientsModels", "Dated");
        }
        
        public override void Down()
        {
            AddColumn("dbo.IngredientsModels", "Dated", c => c.DateTime(nullable: false));
        }
    }
}
