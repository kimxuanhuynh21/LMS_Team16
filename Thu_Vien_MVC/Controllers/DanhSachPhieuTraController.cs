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
            if (mathe != null || maphieutra != null)
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
        [HttpPost]
        public JsonResult getSachChuaTra(string id)
        {
            if (id != null)
            {
                var docgia = db.DocGia.Where(i => i.MaThe.Equals(id)).FirstOrDefault();
                if (docgia != null)
                {
                    var list = db.PhieuMuon.Join(db.ChiTietMuon, pm => pm.ID, ctm => ctm.PhieuMuonID, (pm, ctm) => new
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

                    return Json(list);
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

        [HttpPost]
        public JsonResult getSachPhieuTra(string maphieutra)
        {
            if (maphieutra != null)
            {
                var list_phieutra = db.ChiTietTra.Where(i => i.PhieuTra.MaPhieuTra.Equals(maphieutra)).ToList().Select(i => new
                {
                    ChiTietTraID = i.ID,
                    MaVach = i.CuonSach.MaVach,
                    TenDauSach = i.CuonSach.DauSach.Ten,
                    TenTacGia = i.CuonSach.DauSach.TacGia.Ten,
                    NgayTra = i.PhieuTra.NgayTra
                }).ToList();

                return Json(list_phieutra);
            }

            else
            {
                return Json("error");
            }
        }

        [HttpPost]
        public JsonResult deleteChiTietTra(string id, string mathe)
        {
            if (id != null)
            {
                int ID = Convert.ToInt32(id);
                var cttra = db.ChiTietTra.Where(i => i.ID.Equals(ID)).FirstOrDefault();

                var docgia = db.DocGia.Where(o => o.MaThe.Equals(mathe)).FirstOrDefault();
                docgia.SoSachConLai = docgia.SoSachConLai - 1;

                var cuonsach = db.CuonSach.Where(o => o.ID.Equals(cttra.CuonSachID)).FirstOrDefault();
                cuonsach.TinhTrang = 1;

                var dausach = db.DauSach.Where(o => o.ID.Equals(cuonsach.DauSachID)).FirstOrDefault();
                dausach.SoLuongTon = dausach.SoLuongTon - 1;

                var thongkedausach = db.ThongKeDauSach.Where(o => o.DauSachID.Equals(cuonsach.DauSachID)).FirstOrDefault();

                DateTime date_thongke = thongkedausach.Ngay.Date;
                DateTime now = DateTime.Now.Date;
                if (date_thongke == now)
                {
                    thongkedausach.SoLuongHienTai = thongkedausach.SoLuongHienTai - 1;
                }
                else
                {
                    ThongKeDauSach tk = new ThongKeDauSach();
                    tk.DauSachID = cuonsach.DauSachID;
                    tk.Ngay = DateTime.Now.Date;
                    tk.SoLuongHienTai = dausach.SoLuongTon - 1;
                    db.ThongKeDauSach.Add(tk);
                }

                var ctphieumuon = db.ChiTietMuon.Where(o => o.CuonSach.ID.Equals(cuonsach.ID) && o.PhieuMuon.DocGiaID.Equals(docgia.ID)).FirstOrDefault();
                ctphieumuon.TinhTrang = 1;


                db.ChiTietTra.Remove(cttra);
                db.SaveChanges();

                return Json("ok");
            }
            else
            {
                return Json("error");
            }

        }

        [HttpPost]
        public JsonResult Post_EditChiTietTra(string sMaVach, string MaPhieuTra)
        {
            if (sMaVach != null && MaPhieuTra != null)
            {
                string[] Arr_sMaVach = sMaVach.Split(',');

                var phieutra = db.PhieuTra.Where(i => i.MaPhieuTra.Equals(MaPhieuTra)).FirstOrDefault();

                var docgia = db.DocGia.Where(o => o.ID.Equals(phieutra.DocGiaID)).FirstOrDefault();
                docgia.SoSachConLai = docgia.SoSachConLai + (Arr_sMaVach.Length - 1);

                for (int i = 0; i < Arr_sMaVach.Length - 1; i++)
                {
                    string mavach = Arr_sMaVach[i];

                    var cuonsach = db.CuonSach.Where(o => o.MaVach.Equals(mavach)).FirstOrDefault();
                    cuonsach.TinhTrang = 2;

                    var dausach = db.DauSach.Where(o => o.ID.Equals(cuonsach.DauSachID)).FirstOrDefault();
                    dausach.SoLuongTon = dausach.SoLuongTon + 1;

                    var thongkedausach = db.ThongKeDauSach.Where(o => o.DauSachID.Equals(cuonsach.DauSachID)).FirstOrDefault();

                    DateTime date_thongke = thongkedausach.Ngay.Date;
                    DateTime now = DateTime.Now.Date;
                    if (date_thongke == now)
                    {
                        thongkedausach.SoLuongHienTai = thongkedausach.SoLuongHienTai + 1;
                    }
                    else
                    {
                        ThongKeDauSach tk = new ThongKeDauSach();
                        tk.DauSachID = cuonsach.DauSachID;
                        tk.Ngay = DateTime.Now.Date;
                        tk.SoLuongHienTai = dausach.SoLuongTon + 1;
                        db.ThongKeDauSach.Add(tk);
                    }

                    //0 chua tra
                    //1 tra roi
                    var ctphieumuon = db.ChiTietMuon.Where(o => o.CuonSach.MaVach.Equals(mavach) && o.PhieuMuon.DocGiaID.Equals(docgia.ID)).FirstOrDefault();
                    ctphieumuon.TinhTrang = 1;


                    //giai quyet tinh trang phieu muon


                    ChiTietTra ctTra = new ChiTietTra();
                    ctTra.CuonSachID = cuonsach.ID;
                    ctTra.PhieuTraID = phieutra.ID;
                    db.ChiTietTra.Add(ctTra);
                }

                db.SaveChanges();

                return Json("ok");
            }
            else
            {
                return Json("error");
            }
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
