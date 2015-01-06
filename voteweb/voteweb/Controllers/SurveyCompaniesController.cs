using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Mal.Dal;
using Mal.DataModel;

namespace voteweb.Controllers
{
    public class SurveyCompaniesController : Controller
    {
        private VoteModel db = new VoteModel();

        // GET: SurveyCompanies
        public async Task<ActionResult> Index()
        {
            return View(await db.SurveyCompany.ToListAsync());
        }

        // GET: SurveyCompanies/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SurveyCompany surveyCompany = await db.SurveyCompany.FindAsync(id);
            if (surveyCompany == null)
            {
                return HttpNotFound();
            }
            return View(surveyCompany);
        }

        // GET: SurveyCompanies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SurveyCompanies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name")] SurveyCompany surveyCompany)
        {
            if (ModelState.IsValid)
            {
                db.SurveyCompany.Add(surveyCompany);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(surveyCompany);
        }

        // GET: SurveyCompanies/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SurveyCompany surveyCompany = await db.SurveyCompany.FindAsync(id);
            if (surveyCompany == null)
            {
                return HttpNotFound();
            }
            return View(surveyCompany);
        }

        // POST: SurveyCompanies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name")] SurveyCompany surveyCompany)
        {
            if (ModelState.IsValid)
            {
                db.Entry(surveyCompany).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(surveyCompany);
        }

        // GET: SurveyCompanies/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SurveyCompany surveyCompany = await db.SurveyCompany.FindAsync(id);
            if (surveyCompany == null)
            {
                return HttpNotFound();
            }
            return View(surveyCompany);
        }

        // POST: SurveyCompanies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            SurveyCompany surveyCompany = await db.SurveyCompany.FindAsync(id);
            db.SurveyCompany.Remove(surveyCompany);
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
