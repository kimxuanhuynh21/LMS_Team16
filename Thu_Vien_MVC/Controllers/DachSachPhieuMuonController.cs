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
        public ActionResult Edit(EditPhieuMuonRequest phieuMuonRequest)
        {
            PhieuMuon phieuMuonUpdate = db.PhieuMuon.Find(phieuMuonRequest.ID);
            phieuMuonUpdate.DocGiaID = phieuMuonRequest.DocGiaID;
            db.SaveChanges();
            ViewBag.DocGiaID = new SelectList(db.DocGia, "ID", "MaThe", phieuMuonUpdate.DocGiaID);
            ViewBag.NhanVienID = new SelectList(db.NhanVien, "ID", "MaNhanVien", phieuMuonUpdate.NhanVienID);
            ICollection<ChiTietMuon> dsChiTietMuonCu = db.ChiTietMuon
                .Where(x => x.PhieuMuonID == phieuMuonRequest.ID)
                .ToList();
            foreach (EditChiTietMuon chiTietMuonRequest in phieuMuonRequest.dsChiTietMuon)
            {
                //Nếu chi tiết mượn đã tồn tại và bị xóa trên giao diện thì tiến hành xóa trong CSDL
                //và cập nhật lại tình trạng
                if (chiTietMuonRequest.isOld == true && chiTietMuonRequest.isDeleted == true)
                {
                    //Tìm chi tiết mượn theo id để xóa
                    ChiTietMuon chiTietMuonDeleted = db.ChiTietMuon.Find(chiTietMuonRequest.ChiTietMuonId);
                    //Chỉ cập nhật và thống kê nếu chi tiết mượn này chưa được trả, tức là tình trạng cuốn sách là đang được mượn
                    if (chiTietMuonDeleted.CuonSach.TinhTrang == 1)
                    {
                        //Tiến hành cập nhật lại số lượng tồn kho và số lượng còn lại của độc giả và thống kê đầu sách
                        //Cập nhật lại tình trạng cuốn sách là còn trong kho
                        CuonSach cuonSachMuon = db.CuonSach.Find(chiTietMuonRequest.cuonSachMuonId);
                        cuonSachMuon.TinhTrang = 2;
                        //Cập nhật lại số lượng tồn của đầu sách
                        DauSach dauSachUpdated = db.DauSach.Find(cuonSachMuon.DauSachID);
                        dauSachUpdated.SoLuongTon = dauSachUpdated.SoLuongTon + 1;
                        db.DauSach.Attach(dauSachUpdated);
                        //Cập nhật lại số sách còn lại của độc giả
                        DocGia docGiaUpdated = db.DocGia.Find(phieuMuonRequest.DocGiaID);
                        docGiaUpdated.SoSachConLai = docGiaUpdated.SoSachConLai + 1;
                        //gán biến dauSachUpdated vào db Dau Sach
                        db.SaveChanges();
                        //Thêm hoặc cập nhật thống kê
                        ThongKeDauSach thongKeDauSach = new ThongKeDauSach();
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
                            db.ThongKeDauSach.Attach(thongKeDauSach);
                            thongKeDauSach.SoLuongHienTai = dauSachUpdated.SoLuongTon;
                            db.Entry(thongKeDauSach).State = System.Data.Entity.EntityState.Modified;
                        }
                        else
                        {
                            thongKeDauSach.DauSachID = cuonSachMuon.DauSachID;
                            thongKeDauSach.Ngay = today;
                            thongKeDauSach.SoLuongHienTai = dauSachUpdated.SoLuongTon;
                            db.ThongKeDauSach.Add(thongKeDauSach);
                        }
                    }
                    db.ChiTietMuon.Remove(chiTietMuonDeleted);
                    phieuMuonUpdate.TongSoLuongMuon = phieuMuonUpdate.TongSoLuongMuon - 1;
                    db.SaveChanges();
                }
                //Nếu chi tiết mượn là mới thì tiến hành thêm như bình thường
                if (chiTietMuonRequest.isOld == false && chiTietMuonRequest.isDeleted == false)
                {
                    CuonSach cuonSachMuon = db.CuonSach.Find(chiTietMuonRequest.cuonSachMuonId);
                    ChiTietMuon chiTietMuon = new ChiTietMuon();
                    //Tiến hành cập nhật lại số lượng tồn kho và số lượng còn lại của độc giả và thống kê đầu sách
                    DauSach dauSachUpdated = db.DauSach.Find(cuonSachMuon.DauSachID);
                    DocGia docGiaUpdated = db.DocGia.Find(phieuMuonRequest.DocGiaID);
                    db.DauSach.Attach(dauSachUpdated);
                    //gán biến dauSachUpdated vào db Dau Sach
                    dauSachUpdated.SoLuongTon = dauSachUpdated.SoLuongTon - 1;
                    docGiaUpdated.SoSachConLai = docGiaUpdated.SoSachConLai - 1;
                    cuonSachMuon.TinhTrang = 1;
                    db.SaveChanges();
                    //db.Entry(dauSachUpdated).State = System.Data.Entity.EntityState.Modified;
                    ThongKeDauSach thongKeDauSach = new ThongKeDauSach();
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
                        db.ThongKeDauSach.Attach(thongKeDauSach);
                        thongKeDauSach.SoLuongHienTai = dauSachUpdated.SoLuongTon;
                        db.Entry(thongKeDauSach).State = System.Data.Entity.EntityState.Modified;
                    }
                    else
                    {
                        thongKeDauSach.DauSachID = cuonSachMuon.DauSachID;
                        thongKeDauSach.Ngay = today;
                        thongKeDauSach.SoLuongHienTai = dauSachUpdated.SoLuongTon;
                        db.ThongKeDauSach.Add(thongKeDauSach);
                    }
                    db.SaveChanges();
                    chiTietMuon.CuonSachID = cuonSachMuon.ID;
                    chiTietMuon.PhieuMuonID = phieuMuonUpdate.ID;
                    chiTietMuon.TinhTrang = 0;
                    db.ChiTietMuon.Add(chiTietMuon);
                    phieuMuonUpdate.TongSoLuongMuon = phieuMuonUpdate.TongSoLuongMuon + 1;
                    db.SaveChanges();
                }
            }
            return View(phieuMuonUpdate);
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

    public class EditPhieuMuonRequest
    {
        public int ID { get; set; }
        public int DocGiaID { get; set; }
        public ICollection<EditChiTietMuon> dsChiTietMuon { get; set; }
    }

    public class EditChiTietMuon
    {
        public int ChiTietMuonId { get; set; }
        public int cuonSachMuonId { get; set; }
        public bool isOld { get; set; }
        public bool isDeleted { get; set; }
    }
}
