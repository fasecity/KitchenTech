using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodRecipies.Models
{
    public class IngredientsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ammount  { get; set; }
        public string Prep { get; set; }
        public int RecipeModelsId { get; set; }
        public RecipiesModels Recipie { get; set; }


    }
}