using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodRecipies.Models
{
    public class FoodInventory
    {
        public int FoodInventoryId { get; set; }

        public string Ingredients { get; set; }

        public Status Status { get; set; }

        public string Staff { get; set; }

        public string Category { get; set; }

        public string Station { get; set; }

        public string Spec { get; set; }


        public override string ToString()
        {
            return "Attention station: " + Station.ToString() + " This is running "+ Status.ToString()+" in "+ Ingredients.ToString() +
              " at category "  + Category.ToString()+ " get on this " + Staff.ToString() + ",Prep directions: " + Spec.ToString();
        }


    }

    public enum Status
    {
        Low,
        Okay,
        Order,
        Surplus
    }
}