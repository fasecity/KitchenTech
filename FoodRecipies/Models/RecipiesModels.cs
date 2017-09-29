using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodRecipies.Models
{
    public class RecipiesModels
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public virtual List<IngredientsModel> Ingredients { get; set; }
        public string Description { get; set; }
        public string Directions  { get; set; }
        public int Cooktime { get; set; }
        public int Servings { get; set; }
        public RecipiesModels()
        {
            Ingredients = new List<IngredientsModel>();
        }

        

    }
}