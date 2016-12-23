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


        //GET: PhieuTra/PhieuMuon/?maPhieuMuon=pm1
        public JsonResult PhieuMuon(string maPhieuMuon)
        {
            var chiTietPhieuMuon = db.PhieuMuon.Select(
               c => new
               {
                   ID = c.ID,
                   maPhieuMuon = c.MaPhieuMuon,
                   maThe = c.DocGia.MaThe,
                   tenDocGia = c.DocGia.Ten,
                   soDienThoai = c.DocGia.DienThoai,
                   chucVu = c.DocGia.Loai,
                   email = c.DocGia.Email,
                   ngayMuon = c.NgayMuon,
                   ngayHetHan = c.NgayHetHan,
                   diaChi = c.DocGia.DiaChi,
                   DocGiaID = c.DocGiaID
               }).Where(d => d.maPhieuMuon == maPhieuMuon).FirstOrDefault();
            return new JsonResult() { Data = chiTietPhieuMuon, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        //GET: PhieuTra/CuonSach/?maVach=VH1&maPhieuMuon=PM1
        public JsonResult CuonSach(string maVach, string maPhieuMuon)
        {
            var cuonSach = db.ChiTietMuon.Select(
                x => new
                {
                    ID = x.ID,
                    CuonSach = x.CuonSach,
                    NgayHetHan = x.PhieuMuon.NgayHetHan,
                    PhieuMuonID = x.PhieuMuonID,
                    MaPhieuMuon = x.PhieuMuon.MaPhieuMuon
                }).Where(dg => dg.CuonSach.MaVach == maVach && dg.MaPhieuMuon == maPhieuMuon).FirstOrDefault();
            return new JsonResult() { Data = cuonSach, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        //Thêm 1 phiếu trả vào csdl
        // POST: PhieuTra/ChiTietPhieuTra
        [HttpPost]
        public JsonResult ChiTietPhieuTra(PhieuTraModel PhieuTraJSON)
        {
            PhieuMuon phieuMuonInfo = PhieuTraJSON.PhieuMuon;
            ICollection<ChiTietMuon> dsChiTietMuon = PhieuTraJSON.dsChiTietMuon;
            PhieuTra PhieuTra = new PhieuTra();
            PhieuTra.NgayTra = DateTime.Now;
            PhieuTra.DocGiaID = phieuMuonInfo.DocGiaID;
            db.PhieuTra.Add(PhieuTra);
            db.SaveChanges();
            PhieuTra.MaPhieuTra = "PT" + PhieuTra.ID;
            db.SaveChanges();
            foreach (ChiTietMuon chiTietMuon in dsChiTietMuon)
            {
                ChiTietTra chiTietTra = new ChiTietTra();
                DauSach dauSachUpdated = db.DauSach.Find(chiTietMuon.CuonSach.DauSachID);
                db.DauSach.Attach(dauSachUpdated);
                dauSachUpdated.SoLuongTon = dauSachUpdated.SoLuongTon + 1;
                chiTietTra.CuonSachID = chiTietMuon.CuonSach.ID;
                chiTietTra.PhieuTraID = PhieuTra.ID;
                db.SaveChanges();
                //db.Entry(dauSachUpdated).State = System.Data.Entity.EntityState.Modified;
                ThongKeDauSach thongKeDauSach = new ThongKeDauSach();
                DateTime today = DateTime.Now;
                if (db.ThongKeDauSach.Any(a =>
                a.DauSachID == chiTietMuon.CuonSach.DauSachID &&
                a.Ngay.Day == today.Day &&
                a.Ngay.Month == today.Month &&
                a.Ngay.Year == today.Year))
                {
                    thongKeDauSach = db.ThongKeDauSach.Where(a =>
                      a.DauSachID == chiTietMuon.CuonSach.DauSachID &&
                      a.Ngay.Day == today.Day &&
                      a.Ngay.Month == today.Month &&
                      a.Ngay.Year == today.Year).FirstOrDefault();
                    db.ThongKeDauSach.Attach(thongKeDauSach);
                    thongKeDauSach.SoLuongHienTai = dauSachUpdated.SoLuongTon;
                    db.Entry(thongKeDauSach).State = System.Data.Entity.EntityState.Modified;
                }
                else
                {
                    thongKeDauSach.DauSachID = chiTietMuon.CuonSach.DauSachID;
                    thongKeDauSach.Ngay = today;
                    thongKeDauSach.SoLuongHienTai = dauSachUpdated.SoLuongTon;
                    db.ThongKeDauSach.Add(thongKeDauSach);
                }
                db.SaveChanges();
                chiTietTra.CuonSachID = chiTietMuon.CuonSach.ID;
                chiTietTra.PhieuTraID = PhieuTra.ID;
                db.ChiTietTra.Add(chiTietTra);
                db.SaveChanges();
            }
            var responsePhieuTra = db.PhieuTra.Select(
                c => new
                {
                    ID = c.ID,
                    DocGia = c.DocGia,
                    DocGiaID = c.DocGiaID,
                    NgayTra = c.NgayTra,
                    MaPhieuTra = c.MaPhieuTra,
                    dsChiTietTra = db.ChiTietTra.Select(ctt =>
                   new
                   {
                       CuonSach = ctt.CuonSach,
                       PhieuTraID = ctt.PhieuTraID,
                   })
                  .Where(d => d.PhieuTraID == c.ID)
                }).Where(pt => pt.ID == PhieuTra.ID).FirstOrDefault();
            return new JsonResult() { Data = responsePhieuTra, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        //Tạo 1 model PhieuTraModel với 2 đối tượng PhieuMuon và dsChiTietMuon
        public class PhieuTraModel
        {
            public PhieuMuon PhieuMuon { get; set; }
            public ICollection<ChiTietMuon> dsChiTietMuon { get; set; }
        }
    }
}
