using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using FitnessClub.Models;

namespace FitnessClub.Controllers
{
    public class ShiftsTestContorller : Controller
    {
        private FitnessDbContext db = new FitnessDbContext();

        // GET: ShiftsTestContorller
        public ActionResult Index()
        {
            return View(db.Shifts.ToList());
        }

        // GET: ShiftsTestContorller/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shifts shifts = db.Shifts.Find(id);
            if (shifts == null)
            {
                return HttpNotFound();
            }
            return View(shifts);
        }

        // GET: ShiftsTestContorller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShiftsTestContorller/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Trainer,Shift,ShiftTime")] Shifts shifts)
        {
            if (ModelState.IsValid)
            {
                db.Shifts.Add(shifts);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(shifts);
        }

        // GET: ShiftsTestContorller/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shifts shifts = db.Shifts.Find(id);
            if (shifts == null)
            {
                return HttpNotFound();
            }
            return View(shifts);
        }

        // POST: ShiftsTestContorller/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Trainer,Shift,ShiftTime")] Shifts shifts)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shifts).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shifts);
        }

        // GET: ShiftsTestContorller/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shifts shifts = db.Shifts.Find(id);
            if (shifts == null)
            {
                return HttpNotFound();
            }
            return View(shifts);
        }

        // POST: ShiftsTestContorller/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Shifts shifts = db.Shifts.Find(id);
            db.Shifts.Remove(shifts);
            db.SaveChanges();
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
