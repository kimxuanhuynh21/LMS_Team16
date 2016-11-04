using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EF_Models.Models;

namespace Thu_Vien_MVC.Controllers
{
    public class PhieuTraController : Controller
    {
        private ThuVienDbContext db = new ThuVienDbContext();

        // GET: PhieuTra
        public ActionResult Index()
        {
            PhieuTra phieuTra = db.PhieuTra.Find(1);
            var dsChiTietTra = db.ChiTietTra
                .Where(ctm => ctm.PhieuTraID == phieuTra.ID)
                .Include(p => p.CuonSach);
            return View(dsChiTietTra.ToList());
        }

        // GET: PhieuTra/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuTra phieuTra = db.PhieuTra.Find(id);
            if (phieuTra == null)
            {
                return HttpNotFound();
            }
            return View(phieuTra);
        }

        // GET: PhieuTra/Create
        public ActionResult Create()
        {
            ViewBag.DocGiaID = new SelectList(db.DocGia, "ID", "MaThe");
            ViewBag.PhieuMuonID = new SelectList(db.PhieuMuon, "ID", "MaPhieuMuon");
            return View();
        }

        // POST: PhieuTra/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,MaPhieuTra,PhieuMuonID,NgayTra,DocGiaID")] PhieuTra phieuTra)
        {
            if (ModelState.IsValid)
            {
                db.PhieuTra.Add(phieuTra);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DocGiaID = new SelectList(db.DocGia, "ID", "MaThe", phieuTra.DocGiaID);
            ViewBag.PhieuMuonID = new SelectList(db.PhieuMuon, "ID", "MaPhieuMuon", phieuTra.PhieuMuonID);
            return View(phieuTra);
        }

        // GET: PhieuTra/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuTra phieuTra = db.PhieuTra.Find(id);
            if (phieuTra == null)
            {
                return HttpNotFound();
            }
            ViewBag.DocGiaID = new SelectList(db.DocGia, "ID", "MaThe", phieuTra.DocGiaID);
            ViewBag.PhieuMuonID = new SelectList(db.PhieuMuon, "ID", "MaPhieuMuon", phieuTra.PhieuMuonID);
            return View(phieuTra);
        }

        // POST: PhieuTra/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,MaPhieuTra,PhieuMuonID,NgayTra,DocGiaID")] PhieuTra phieuTra)
        {
            if (ModelState.IsValid)
            {
                db.Entry(phieuTra).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DocGiaID = new SelectList(db.DocGia, "ID", "MaThe", phieuTra.DocGiaID);
            ViewBag.PhieuMuonID = new SelectList(db.PhieuMuon, "ID", "MaPhieuMuon", phieuTra.PhieuMuonID);
            return View(phieuTra);
        }

        // GET: PhieuTra/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuTra phieuTra = db.PhieuTra.Find(id);
            if (phieuTra == null)
            {
                return HttpNotFound();
            }
            return View(phieuTra);
        }

        // POST: PhieuTra/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PhieuTra phieuTra = db.PhieuTra.Find(id);
            db.PhieuTra.Remove(phieuTra);
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
