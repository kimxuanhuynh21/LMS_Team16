using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EF_Models.Models;
using PagedList;

namespace Thu_Vien_MVC.Controllers
{
    public class DachSachPhieuMuonController : Controller
    {
        private ThuVienDbContext db = new ThuVienDbContext();

        // GET: DachSachPhieuMuon
        public ActionResult Index(int? page)
        {
            var phieuMuon = db.PhieuMuon.Include(p => p.DocGia).Include(p => p.NhanVien).OrderBy(j => j.MaPhieuMuon);
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(phieuMuon.ToPagedList(pageNumber, pageSize));
        }

        // GET: DachSachPhieuMuon/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuMuon phieuMuon = db.PhieuMuon.Find(id);
            if (phieuMuon == null)
            {
                return HttpNotFound();
            }
            return View(phieuMuon);
        }

        // GET: DachSachPhieuMuon/Create
        public ActionResult Create()
        {
            ViewBag.DocGiaID = new SelectList(db.DocGia, "ID", "MaThe");
            ViewBag.NhanVienID = new SelectList(db.NhanVien, "ID", "MaNhanVien");
            return View();
        }

        // POST: DachSachPhieuMuon/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,MaPhieuMuon,NgayMuon,DocGiaID,NhanVienID,NgayHetHan,TongSoLuongMuon,TinhTrang")] PhieuMuon phieuMuon)
        {
            if (ModelState.IsValid)
            {
                db.PhieuMuon.Add(phieuMuon);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DocGiaID = new SelectList(db.DocGia, "ID", "MaThe", phieuMuon.DocGiaID);
            ViewBag.NhanVienID = new SelectList(db.NhanVien, "ID", "MaNhanVien", phieuMuon.NhanVienID);
            return View(phieuMuon);
        }

        // GET: DachSachPhieuMuon/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuMuon phieuMuon = db.PhieuMuon.Find(id);
            if (phieuMuon == null)
            {
                return HttpNotFound();
            }
            ViewBag.DocGiaID = new SelectList(db.DocGia, "ID", "MaThe", phieuMuon.DocGiaID);
            ViewBag.NhanVienID = new SelectList(db.NhanVien, "ID", "MaNhanVien", phieuMuon.NhanVienID);
            return View(phieuMuon);
        }

        // POST: DachSachPhieuMuon/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,MaPhieuMuon,NgayMuon,DocGiaID,NhanVienID,NgayHetHan,TongSoLuongMuon,TinhTrang")] PhieuMuon phieuMuon)
        {
            if (ModelState.IsValid)
            {
                db.Entry(phieuMuon).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DocGiaID = new SelectList(db.DocGia, "ID", "MaThe", phieuMuon.DocGiaID);
            ViewBag.NhanVienID = new SelectList(db.NhanVien, "ID", "MaNhanVien", phieuMuon.NhanVienID);
            return View(phieuMuon);
        }

        // GET: DachSachPhieuMuon/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuMuon phieuMuon = db.PhieuMuon.Find(id);
            if (phieuMuon == null)
            {
                return HttpNotFound();
            }
            return View(phieuMuon);
        }

        // POST: DachSachPhieuMuon/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PhieuMuon phieuMuon = db.PhieuMuon.Find(id);
            db.PhieuMuon.Remove(phieuMuon);
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
