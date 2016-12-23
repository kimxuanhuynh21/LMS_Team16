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
        // GET: dsCuonSach
        public JsonResult dsCuonSach()
        {
            var dsCuonSach = db.CuonSach
                .Where(dg => dg.TinhTrang == 2)
                .ToList();
            return new JsonResult() { Data = dsCuonSach, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        // GET: dsCuonSachDaMuon
        public JsonResult dsCuonSachDaMuon(string maTheDocGia)
        {
            var dsCuonSach = db.ChiTietMuon
                .Select(x => new
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
                .Where(dg => dg.MaThe == maTheDocGia && dg.CuonSach.TinhTrang == 1)
                .ToList();
            return new JsonResult() { Data = dsCuonSach, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        // GET: dsChiTietMuon
        public JsonResult dsChiTietMuon(int PhieuMuonId)
        {
            var dsChiTietMuon = db.ChiTietMuon
                .Select(x => new
                {
                    ID = x.CuonSach.ID,
                    ChiTietMuonId = x.ID,
                    SoSachConLai = x.PhieuMuon.DocGia.SoSachConLai,
                    PhieuMuonId = x.PhieuMuonID,
                    MaVach = x.CuonSach.MaVach,
                    DauSach = x.CuonSach.DauSach,
                    DauSachID = x.CuonSach.DauSachID,
                    isDeleted = false
                })
                .Where(dg => dg.PhieuMuonId == PhieuMuonId)
                .ToList();
            return new JsonResult() { Data = dsChiTietMuon, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }



    }
}