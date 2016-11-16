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
    public class PhieuMuonController : Controller
    {
        private ThuVienDbContext db = new ThuVienDbContext();

        // GET: PhieuMuon
        public ActionResult Index()
        {
            //var phieuMuon = db.PhieuMuon.Include(p => p.DocGia).Include(p => p.NhanVien);
            PhieuMuon phieuMuon = db.PhieuMuon.Find(1);
            var dsChiTietMuon = db.ChiTietMuon
                .Where(ctm => ctm.PhieuMuonID == phieuMuon.ID)
                .Include(p => p.CuonSach);
            return View(dsChiTietMuon.ToList());
        }

        // GET: PhieuMuon/Details/5
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

        // GET: PhieuMuon/Create
        public ActionResult Create()
        {
            //ViewBag.DocGiaID = new SelectList(db.DocGia, "ID", "MaThe");
            //ViewBag.NhanVienID = new SelectList(db.NhanVien, "ID", "MaNhanVien");
            PhieuMuon phieuMuon = db.PhieuMuon.Find(1);
            var dsChiTietMuon = db.ChiTietMuon
                .Where(ctm => ctm.PhieuMuonID == phieuMuon.ID)
                .Include(p => p.CuonSach);
            return View(dsChiTietMuon.ToList());
        }

        // POST: PhieuMuon/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,MaPhieuMuon,NgayMuon,DocGiaID,NhanVienID,NgayHetHan,TongSoLuongMuon,SoLuongTra,TinhTrang")] PhieuMuon phieuMuon)
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

        // GET: PhieuMuon/Edit/5
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

        // POST: PhieuMuon/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,MaPhieuMuon,NgayMuon,DocGiaID,NhanVienID,NgayHetHan,TongSoLuongMuon,SoLuongTra,TinhTrang")] PhieuMuon phieuMuon)
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

        // GET: PhieuMuon/Delete/5
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

        // POST: PhieuMuon/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PhieuMuon phieuMuon = db.PhieuMuon.Find(id);
            db.PhieuMuon.Remove(phieuMuon);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //GET: PhieuMuon/DocGia/1
        public JsonResult DocGia(string maThe)
        {
            DocGia docGia = db.DocGia.Where(c => c.MaThe.Contains(maThe)).FirstOrDefault();
            return new JsonResult() { Data = docGia, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
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
