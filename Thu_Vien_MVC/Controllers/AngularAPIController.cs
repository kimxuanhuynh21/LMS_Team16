using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EF_Models.Models;

namespace Thu_Vien_MVC.Controllers
{
    public class AngularAPIController : Controller
    {
        private ThuVienDbContext db = new ThuVienDbContext();
        // GET: Sach
        public JsonResult dsCuonSach(string maTheDocGia)
        {
            var dsCuonSach = db.ChiTietMuon.Select(
                x => new
                {
                    ID = x.ID,
                    CuonSach = x.CuonSach,
                    MaVach = x.CuonSach.MaVach,
                    TenDauSach = x.CuonSach.DauSach.Ten,
                    NgayHetHan = x.PhieuMuon.NgayHetHan,
                    PhieuMuonID = x.PhieuMuonID,
                    MaPhieuMuon = x.PhieuMuon.MaPhieuMuon,
                    MaThe = x.PhieuMuon.DocGia.MaThe,
                    TinhTrang = x.TinhTrang
                })
                .Where(dg => dg.MaThe == maTheDocGia && dg.TinhTrang == 0)
                .ToList();
            return new JsonResult() { Data = dsCuonSach, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}