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
    public class DanhSachPhieuTraController : Controller
    {
        private ThuVienDbContext db = new ThuVienDbContext();

        // GET: DanhSachPhieuTra
        public ActionResult Index(int? page)
        {
            var phieuTra = db.PhieuTra.Include(p => p.DocGia).OrderBy(j => j.MaPhieuTra);
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(phieuTra.ToPagedList(pageNumber, pageSize));
        }

        // GET: DanhSachPhieuTra/Details/5
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

        // GET: DanhSachPhieuTra/Create
        public ActionResult Create()
        {
            ViewBag.DocGiaID = new SelectList(db.DocGia, "ID", "MaThe");
            return View();
        }

        // POST: DanhSachPhieuTra/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,MaPhieuTra,NgayTra,DocGiaID")] PhieuTra phieuTra)
        {
            if (ModelState.IsValid)
            {
                db.PhieuTra.Add(phieuTra);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DocGiaID = new SelectList(db.DocGia, "ID", "MaThe", phieuTra.DocGiaID);
            return View(phieuTra);
        }


        public JsonResult getSach(string mathe, string maphieutra)
        {
            if (mathe != null && maphieutra != null)
            {
                var docgia = db.DocGia.Where(i => i.MaThe.Equals(mathe)).FirstOrDefault();
                if (docgia != null)
                {
                    var list_sachchuatra = db.PhieuMuon.Join(db.ChiTietMuon, pm => pm.ID, ctm => ctm.PhieuMuonID, (pm, ctm) => new
                    {
                        PhieuMuon = pm,
                        ChiTietMuon = ctm
                    }).Where(i => i.PhieuMuon.DocGiaID.Equals(docgia.ID) && i.ChiTietMuon.CuonSach.TinhTrang == 1).Select(i => new
                    {
                        MaVach = i.ChiTietMuon.CuonSach.MaVach,
                        TenDauSach = i.ChiTietMuon.CuonSach.DauSach.Ten,
                        TenTacGia = i.ChiTietMuon.CuonSach.DauSach.TacGia.Ten,
                        NgayHetHan = i.PhieuMuon.NgayHetHan,
                    }).ToList();


                    var list_phieutra = db.ChiTietTra.Where(i => i.PhieuTra.MaPhieuTra.Equals(maphieutra)).ToList().Select(i => new
                    {
                        MaVach = i.CuonSach.MaVach,
                        TenDauSach = i.CuonSach.DauSach.Ten,
                        TenTacGia = i.CuonSach.DauSach.TacGia.Ten,
                        NgayTra = i.PhieuTra.NgayTra
                    }).ToList();


                    return Json(new { List_SachChuaTra = list_sachchuatra, List_PhieuTra = list_phieutra });
                }

                else
                {
                    return Json("error");
                }
            }
            else
            {
                return Json("error");
            }
        }


        // GET: DanhSachPhieuTra/Edit/5
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
            return View(phieuTra);
        }

        // POST: DanhSachPhieuTra/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,MaPhieuTra,NgayTra,DocGiaID")] PhieuTra phieuTra)
        {
            if (ModelState.IsValid)
            {
                db.Entry(phieuTra).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DocGiaID = new SelectList(db.DocGia, "ID", "MaThe", phieuTra.DocGiaID);
            return View(phieuTra);
        }

        // GET: DanhSachPhieuTra/Delete/5
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

        // POST: DanhSachPhieuTra/Delete/5
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
