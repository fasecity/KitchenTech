using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FoodRecipies.Models;

namespace FoodRecipies.Controllers
{
    public class IngredientsModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: IngredientsModels
        public async Task<ActionResult> Index()
        {
            return View(await db.Ingredients.ToListAsync());
        }

        // GET: IngredientsModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IngredientsModel ingredientsModel = await db.Ingredients.FindAsync(id);
            if (ingredientsModel == null)
            {
                return HttpNotFound();
            }
            return View(ingredientsModel);
        }

        // GET: IngredientsModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IngredientsModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name,Ammount,Prep,RecipeModelsId")] IngredientsModel ingredientsModel)
        {
            if (ModelState.IsValid)
            {
                db.Ingredients.Add(ingredientsModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(ingredientsModel);
        }

        // GET: IngredientsModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IngredientsModel ingredientsModel = await db.Ingredients.FindAsync(id);
            if (ingredientsModel == null)
            {
                return HttpNotFound();
            }
            return View(ingredientsModel);
        }

        // POST: IngredientsModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name,Ammount,Prep,RecipeModelsId")] IngredientsModel ingredientsModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ingredientsModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(ingredientsModel);
        }

        // GET: IngredientsModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IngredientsModel ingredientsModel = await db.Ingredients.FindAsync(id);
            if (ingredientsModel == null)
            {
                return HttpNotFound();
            }
            return View(ingredientsModel);
        }

        // POST: IngredientsModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            IngredientsModel ingredientsModel = await db.Ingredients.FindAsync(id);
            db.Ingredients.Remove(ingredientsModel);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
