namespace FoodRecipies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edit2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.IngredientsModels", name: "RecipiesModels_Id", newName: "Recipie_Id");
            RenameIndex(table: "dbo.IngredientsModels", name: "IX_RecipiesModels_Id", newName: "IX_Recipie_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.IngredientsModels", name: "IX_Recipie_Id", newName: "IX_RecipiesModels_Id");
            RenameColumn(table: "dbo.IngredientsModels", name: "Recipie_Id", newName: "RecipiesModels_Id");
        }
    }
}
