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
    public class ChiTietMuonController : Controller
    {
        private ThuVienDbContext db = new ThuVienDbContext();

        // GET: ChiTietMuon
        public ActionResult Index()
        {
            var chiTietMuon = db.ChiTietMuon.Include(c => c.CuonSach).Include(c => c.PhieuMuon);
            return View(chiTietMuon.ToList());
        }

        // GET: ChiTietMuon/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietMuon chiTietMuon = db.ChiTietMuon.Find(id);
            if (chiTietMuon == null)
            {
                return HttpNotFound();
            }
            return View(chiTietMuon);
        }

        // GET: ChiTietMuon/Create
        public ActionResult Create()
        {
            ViewBag.CuonSachID = new SelectList(db.CuonSach, "ID", "MaVach");
            ViewBag.PhieuMuonID = new SelectList(db.PhieuMuon, "ID", "MaPhieuMuon");
            return View();
        }

        // POST: ChiTietMuon/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,PhieuMuonID,CuonSachID,TinhTrang")] ChiTietMuon chiTietMuon)
        {
            if (ModelState.IsValid)
            {
                db.ChiTietMuon.Add(chiTietMuon);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CuonSachID = new SelectList(db.CuonSach, "ID", "MaVach", chiTietMuon.CuonSachID);
            ViewBag.PhieuMuonID = new SelectList(db.PhieuMuon, "ID", "MaPhieuMuon", chiTietMuon.PhieuMuonID);
            return View(chiTietMuon);
        }

        // GET: ChiTietMuon/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietMuon chiTietMuon = db.ChiTietMuon.Find(id);
            if (chiTietMuon == null)
            {
                return HttpNotFound();
            }
            ViewBag.CuonSachID = new SelectList(db.CuonSach, "ID", "MaVach", chiTietMuon.CuonSachID);
            ViewBag.PhieuMuonID = new SelectList(db.PhieuMuon, "ID", "MaPhieuMuon", chiTietMuon.PhieuMuonID);
            return View(chiTietMuon);
        }

        // POST: ChiTietMuon/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,PhieuMuonID,CuonSachID,TinhTrang")] ChiTietMuon chiTietMuon)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chiTietMuon).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CuonSachID = new SelectList(db.CuonSach, "ID", "MaVach", chiTietMuon.CuonSachID);
            ViewBag.PhieuMuonID = new SelectList(db.PhieuMuon, "ID", "MaPhieuMuon", chiTietMuon.PhieuMuonID);
            return View(chiTietMuon);
        }

        // GET: ChiTietMuon/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietMuon chiTietMuon = db.ChiTietMuon.Find(id);
            if (chiTietMuon == null)
            {
                return HttpNotFound();
            }
            return View(chiTietMuon);
        }

        // POST: ChiTietMuon/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ChiTietMuon chiTietMuon = db.ChiTietMuon.Find(id);
            db.ChiTietMuon.Remove(chiTietMuon);
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
