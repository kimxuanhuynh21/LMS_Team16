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

        //Kiểm tra maThe nhận được từ browser có bằng với MaThe trong db ko? 
        //Sau đó gán vào đối tượng docGia sử dụng model DocGia
        //GET: PhieuMuon/DocGia/?maThe=dg1
        public JsonResult DocGia(string maThe)
        {
            DocGia docGia = db.DocGia.Where(c => c.MaThe == maThe).FirstOrDefault();    //lấy 1 record và gán vào model độc giả
            return new JsonResult() { Data = docGia, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        //Trả về các thuộc tính mà browser cần 
        //GET: PhieuMuon/LichSuMuon/?maThe=dg1
        public JsonResult LichSuMuon(string maThe)
        {
            var dsChiTietMuon = db.ChiTietMuon.Select(          //Lọc các thuộc tính trong ChiTietMuon (DauSach, NgayMuon)
                c => new
                {
                    ID = c.ID,
                    DauSach = c.CuonSach.DauSach.Ten,
                    NgayHetHan = c.PhieuMuon.NgayHetHan,
                    MaThe = c.PhieuMuon.DocGia.MaThe,
                    PhieuTra = db.ChiTietTra.Select(
                      ctt => new
                      {                   //Lọc các thuộc tính trong ChiTietTra (NgayTra)
                          ID = ctt.ID,
                          PhieuMuonID = ctt.PhieuTra.PhieuMuonID,
                          CuonSachID = ctt.CuonSachID,
                          NgayTra = ctt.PhieuTra.NgayTra
                      })
                      .Where(d => c.CuonSachID == d.CuonSachID && c.PhieuMuonID == d.PhieuMuonID)
                      .FirstOrDefault()        //lấy danh sách chi tiết mượn
                }).Where(dg => dg.MaThe == maThe);
            return new JsonResult() { Data = dsChiTietMuon, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        //GET: PhieuMuon/CuonSach/?maVach=VH1
        public JsonResult CuonSach(string maVach)
        {
            CuonSach cuonSach = db.CuonSach.Where(c => c.MaVach == maVach).FirstOrDefault();
            return new JsonResult() { Data = cuonSach, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        //Thêm 1 phiếu mượn vào csdl
        // POST: PhieuMuon/ChiTietPhieuMuon
        [HttpPost]
        public JsonResult ChiTietPhieuMuon(PhieuMuonModel phieuMuonJSON)
        {
            DocGia docGiaMuon = phieuMuonJSON.DocGia;
            ICollection<CuonSach> dsCuonSachMuon = phieuMuonJSON.dsCuonSach;
            PhieuMuon PhieuMuon = new PhieuMuon();
            PhieuMuon.DocGiaID = docGiaMuon.ID;
            PhieuMuon.NgayMuon = DateTime.Now;
            if (docGiaMuon.Loai == 0)
            {
                PhieuMuon.NgayHetHan = PhieuMuon.NgayMuon.AddDays(20);
            }
            else
            {
                PhieuMuon.NgayHetHan = PhieuMuon.NgayMuon.AddDays(30);
            }
            PhieuMuon.NhanVienID = 1;
            PhieuMuon.TinhTrang = 0;
            db.PhieuMuon.Add(PhieuMuon);
            db.SaveChanges();
            PhieuMuon.MaPhieuMuon = "PM" + PhieuMuon.ID;
            db.SaveChanges();
            foreach (CuonSach cuonSachMuon in dsCuonSachMuon)
            {
                ChiTietMuon chiTietMuon = new ChiTietMuon();
                DauSach dauSachUpdated = cuonSachMuon.DauSach;
                dauSachUpdated.SoLuongTon = dauSachUpdated.SoLuongTon - 1;
                db.Entry(dauSachUpdated).State = System.Data.Entity.EntityState.Modified;
                ThongKeDauSach thongKeDauSach = new ThongKeDauSach();
                db.SaveChanges();
                DateTime today = DateTime.Now;
                if (db.ThongKeDauSach.Any(a =>
                a.DauSachID == cuonSachMuon.DauSachID &&
                a.Ngay.Day == today.Day &&
                a.Ngay.Month == today.Month &&
                a.Ngay.Year == today.Year))
                {
                    thongKeDauSach = db.ThongKeDauSach.Where(a =>
                      a.DauSachID == cuonSachMuon.DauSachID &&
                      a.Ngay.Day == today.Day &&
                      a.Ngay.Month == today.Month &&
                      a.Ngay.Year == today.Year).FirstOrDefault();
                    thongKeDauSach.SoLuongHienTai = cuonSachMuon.DauSach.SoLuongTon;
                    db.Entry(thongKeDauSach).State = System.Data.Entity.EntityState.Modified;
                }
                else
                {
                    thongKeDauSach.DauSachID = cuonSachMuon.DauSachID;
                    thongKeDauSach.Ngay = today;
                    thongKeDauSach.SoLuongHienTai = cuonSachMuon.DauSach.SoLuongTon;
                    db.ThongKeDauSach.Add(thongKeDauSach);
                }
                db.SaveChanges();
                chiTietMuon.CuonSachID = cuonSachMuon.ID;
                chiTietMuon.PhieuMuonID = PhieuMuon.ID;
                chiTietMuon.TinhTrang = 0;
                db.ChiTietMuon.Add(chiTietMuon);
            }
            db.SaveChanges();
            var responsePhieuMuon = db.PhieuMuon.Select(c =>
              new
              {
                  ID = c.ID,
                  MaPhieuMuon = c.MaPhieuMuon,
                  NgayHetHan = c.NgayHetHan,
                  NgayMuon = c.NgayMuon,
                  NhanVienID = c.NhanVienID,
                  TongSoLuongMuon = c.TongSoLuongMuon,
                  TinhTrang = c.TinhTrang,
                  DocGia = c.DocGia,
                  DocGiaID = c.DocGiaID,
                  dsChiTietMuon = db.ChiTietMuon.Select(ctm =>
                   new
                   {
                       CuonSach = ctm.CuonSach,
                       PhieuMuonID = ctm.PhieuMuonID,
                       TinhTrang = ctm.TinhTrang
                   })
                  .Where(d => d.PhieuMuonID == c.ID)
              }).Where(e => e.ID == PhieuMuon.ID).FirstOrDefault();
            return new JsonResult() { Data = responsePhieuMuon, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
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

    //Tạo 1 model PhieuMuonModel với 2 đối tượng DocGia và dsCuonSach
    public class PhieuMuonModel
    {
        public DocGia DocGia { get; set; }
        public ICollection<CuonSach> dsCuonSach { get; set; }
    }
}
