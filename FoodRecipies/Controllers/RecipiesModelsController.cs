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
    public class RecipiesModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: RecipiesModels
        public async Task<ActionResult> Index()
        {
            return View(await db.Recipies.ToListAsync());
        }

        // GET: RecipiesModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RecipiesModels recipiesModels = await db.Recipies.FindAsync(id);
            if (recipiesModels == null)
            {
                return HttpNotFound();
            }
            return View(recipiesModels);
        }

        // GET: RecipiesModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RecipiesModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name,Description,Directions,Cooktime,Servings")] RecipiesModels recipiesModels)
        {
            if (ModelState.IsValid)
            {
                db.Recipies.Add(recipiesModels);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(recipiesModels);
        }

        // GET: RecipiesModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RecipiesModels recipiesModels = await db.Recipies.FindAsync(id);
            if (recipiesModels == null)
            {
                return HttpNotFound();
            }
            return View(recipiesModels);
        }

        // POST: RecipiesModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name,Description,Directions,Cooktime,Servings")] RecipiesModels recipiesModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recipiesModels).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(recipiesModels);
        }

        // GET: RecipiesModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RecipiesModels recipiesModels = await db.Recipies.FindAsync(id);
            if (recipiesModels == null)
            {
                return HttpNotFound();
            }
            return View(recipiesModels);
        }

        // POST: RecipiesModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            RecipiesModels recipiesModels = await db.Recipies.FindAsync(id);
            db.Recipies.Remove(recipiesModels);
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
