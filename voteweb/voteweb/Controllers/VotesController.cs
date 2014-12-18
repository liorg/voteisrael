using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using voteweb.Dal;

namespace voteweb.Controllers
{
    public class VotesController : Controller
    {
        private VoteModel db = new VoteModel();

        // GET: Votes
        public async Task<ActionResult> Index()
        {
            var vote = db.Vote.Include(v => v.PoliticalParty).Include(v => v.SurveyCompany);
            return View(await vote.ToListAsync());
        }

        // GET: Votes/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vote vote = await db.Vote.FindAsync(id);
            if (vote == null)
            {
                return HttpNotFound();
            }
            return View(vote);
        }

        // GET: Votes/Create
        public ActionResult Create()
        {
            ViewBag.PoliticalPartyId = new SelectList(db.PoliticalParty, "Id", "Name");
            ViewBag.SurveyCompanyId = new SelectList(db.SurveyCompany, "Id", "Name");
            return View();
        }

        // POST: Votes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,SurveyCompanyId,PoliticalPartyId,date,votes")] Vote vote)
        {
            if (ModelState.IsValid)
            {
                db.Vote.Add(vote);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.PoliticalPartyId = new SelectList(db.PoliticalParty, "Id", "Name", vote.PoliticalPartyId);
            ViewBag.SurveyCompanyId = new SelectList(db.SurveyCompany, "Id", "Name", vote.SurveyCompanyId);
            return View(vote);
        }

        // GET: Votes/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vote vote = await db.Vote.FindAsync(id);
            if (vote == null)
            {
                return HttpNotFound();
            }
            ViewBag.PoliticalPartyId = new SelectList(db.PoliticalParty, "Id", "Name", vote.PoliticalPartyId);
            ViewBag.SurveyCompanyId = new SelectList(db.SurveyCompany, "Id", "Name", vote.SurveyCompanyId);
            return View(vote);
        }

        // POST: Votes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,SurveyCompanyId,PoliticalPartyId,date,votes")] Vote vote)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vote).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.PoliticalPartyId = new SelectList(db.PoliticalParty, "Id", "Name", vote.PoliticalPartyId);
            ViewBag.SurveyCompanyId = new SelectList(db.SurveyCompany, "Id", "Name", vote.SurveyCompanyId);
            return View(vote);
        }

        // GET: Votes/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vote vote = await db.Vote.FindAsync(id);
            if (vote == null)
            {
                return HttpNotFound();
            }
            return View(vote);
        }

        // POST: Votes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Vote vote = await db.Vote.FindAsync(id);
            db.Vote.Remove(vote);
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
