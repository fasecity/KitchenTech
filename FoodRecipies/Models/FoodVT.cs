using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodRecipies.Models
{
    public class FoodVT
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public Station Station { get; set; }
        public Staff Staff { get; set; }
        public StatusLevel StatusLevel { get; set; }
        public string Ingredients { get; set; }
        public string Spec { get; set; }

        public override string ToString()
        {
            return "Attention station: " + Station.Name.ToString()
                + " This is running "
                + StatusLevel.ToString()
                + " in " + Ingredients.ToString() +
              " at category " + Category.Name.ToString() +
              " get on this "
              + Staff.Name.ToString()
              + ",Prep directions: " + Spec.ToString();
        }


    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Station
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public enum StatusLevel
    {
        Low,
        Okay,
        Order,
        Surplus
    }
}