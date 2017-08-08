using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using M3PMVC.PartyModels;
using M3PMVC.Presentation;
using M3PMVC.Models;

namespace M3PMVC.Controllers
{
    public class PartyRealController : Controller
    {
        private PartyDBContext db = new PartyDBContext();

        //
        // GET: /PartyReal/DetailList

        public ActionResult List()
        {
            var query = (from mye in db.PReals
                         join pas in db.PPassports on mye.CiqPrID equals pas.CiqPrID
                         join viz in db.PVisas on mye.CiqPrID equals viz.CiqPrID
            //var query = (from mye in db.PartyIdentities
            //             join emp in db.PartyReals on mye.CiqPrID equals emp.CiqPrID
            //             join pas in db.PartyPassports on emp.CiqPrID equals pas.CiqPrID
            //             join viz in db.PartyVisas on mye.CiqPartyVisaID equals viz.CiqPartyVisaID
                         select new EmployeeList
                         {
                             ad = mye.CiqPrname,
                             sd = mye.CiqPrsurname,
                             pn = pas.CiqPartyPasno,
                             pt = pas.CiqPartyPasgec,
                             vn = viz.CiqPartyVizeno,
                             vt = viz.CiqPartyVizeson,
                         });
            return View(query);
        }

        //
        // GET: /PartyReal/

        public ActionResult Index()
        {
            return View(db.PReals.ToList());
        }

        //
        // GET: /PartyReal/Details/5

        public ActionResult Details(int id = 0)
        {
            M3PPartyReal partyreal = db.PReals.Find(id);
            if (partyreal == null)
            {
                return HttpNotFound();
            }
            return View(partyreal);
        }

        //
        // GET: /PartyReal/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /PartyReal/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(M3PPartyReal partyreal)
        {
            if (ModelState.IsValid)
            {
                db.PReals.Add(partyreal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(partyreal);
        }

        //
        // GET: /PartyReal/Edit/5

        public ActionResult Edit(int id = 0)
        {
            M3PPartyReal partyreal = db.PReals.Find(id);
            if (partyreal == null)
            {
                return HttpNotFound();
            }
            return View(partyreal);
        }

        //
        // POST: /PartyReal/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(M3PPartyReal partyreal)
        {
            if (ModelState.IsValid)
            {
                db.Entry(partyreal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(partyreal);
        }

        //
        // GET: /PartyReal/Delete/5

        public ActionResult Delete(int id = 0)
        {
            M3PPartyReal partyreal = db.PReals.Find(id);
            if (partyreal == null)
            {
                return HttpNotFound();
            }
            return View(partyreal);
        }

        //
        // POST: /PartyReal/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            M3PPartyReal partyreal = db.PReals.Find(id);
            db.PReals.Remove(partyreal);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}