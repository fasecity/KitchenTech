using FoodRecipies.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodRecipies.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            
            //List<RecipiesModels> recipies;
            FoodInventory f = new FoodInventory()
            {
                FoodInventoryId =1,
                Category = "DOUGH",
                Ingredients = "PIZZA-DOUGH",
                Staff = "Mark",
                Status = Status.Low,
                Station ="COLD",
                Spec= "step 1,step 2",
                

            };
            FoodInventory f2 = new FoodInventory()
            {
                FoodInventoryId = 2,
                Category = "Deserts",
                Ingredients = "shatika",
                Staff = "MARK",
                Status = Status.Okay,
                Station = "GM",
                Spec = "cook all",
            };
            FoodInventory f3 = new FoodInventory()
            {
                FoodInventoryId = 3,
                Category = "MEAT",
                Ingredients = "ribeye",
                Staff = "Mohamed",
                Status = Status.Low,
                Station = "GM",
                Spec = "cook all mid well",
            };
            FoodInventory f4 = new FoodInventory()
            {
                FoodInventoryId = 4,
                Category = "MEAT",
                Ingredients = "ribeye",
                Staff = "Matt",
                Status = Status.Low,
                Station = "GM",
                Spec = "cook all mid well",
            };
            FoodInventory f5 = new FoodInventory()
            {
                FoodInventoryId = 5,
                Category = "spaggetti",
                Ingredients = "ribeye",
                Staff = "Matt",
                Status = Status.Low,
                Station = "GM",
                Spec = "cook all mid well",
            };
            FoodInventory f6 = new FoodInventory()
            {
                FoodInventoryId = 6,
                Category = "DOUGH",
                Ingredients = "bread",
                Staff = "Matt",
                Status = Status.Low,
                Station = "GM",
                Spec = "bake all",
            };

            List<FoodInventory> foodlist = new List<FoodInventory>();
            foodlist.Add(f);
            foodlist.Add(f2);
            foodlist.Add(f3);
            foodlist.Add(f5);
            foodlist.Add(f6);
            foodlist.Add(f4);
            foodlist = foodlist.OrderBy(x => x.Category.ToLower()).ToList();
            IEnumerable<FoodInventory> lowstatus = foodlist.FindAll(x => x.Status == Status.Low).ToList();
           // lowstatus.OrderBy(x => x.GetType().GetProperty("Category").GetValue(x,null));
          
            return View(lowstatus);
        }

        public ActionResult Contact()
        {
            //category
            List<Category> categoryList = new List<Category>();// imagine this is dbset category
            Category c1 = new Category() { Id = 1, Name = "Dairy" };
            Category c2 = new Category() { Id = 2, Name = "Dough" };
            Category c3 = new Category() { Id = 3, Name = "Meat" };
            categoryList.Add(c1);
            categoryList.Add(c2);
            categoryList.Add(c3);
           
            //station
            List<Station> stationList = new List<Station>();
            Station s1 = new Station() { Id = 1, Name = "COLD" };
            Station s2 = new Station() { Id = 2, Name = "HOT" };
            Station s3 = new Station() { Id = 3, Name = "Desert" };

            stationList.Add(s1);
            stationList.Add(s2);
            stationList.Add(s3);
           
            //staff
            List<Staff> staffList = new List<Staff>();
            Staff st1 = new Staff() { Id = 1, Name = "Mohamed" };
            Staff st2 = new Staff() { Id = 1, Name = "Mark" };
            Staff st3 = new Staff() { Id = 1, Name = "Rob" };

            staffList.Add(st1);
            staffList.Add(st2);
            staffList.Add(st3);

            //for enum dropdown
            List<StatusLevel> stats = new List<StatusLevel>();
            stats.Add(StatusLevel.Low);
            stats.Add(StatusLevel.Okay);
            stats.Add(StatusLevel.Order);
            stats.Add(StatusLevel.Surplus);

            //pass data to drop downs
            ViewBag.Category = new SelectList(categoryList, "Id", "Name");
            ViewBag.Station = new SelectList(stationList, "Id", "Name");
            ViewBag.Staff = new SelectList(staffList, "Id", "Name");
            ViewBag.stats = new SelectList(stats);

            FoodVT food = new FoodVT();



            return View();
        }
    }
}