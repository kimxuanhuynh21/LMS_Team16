using EF_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Thu_Vien_MVC.Models;
using EF_Models.Handlers;
using System.Data.Entity;
using EF_Models.ViewModels;

namespace Thu_Vien_MVC.Controllers
{
    public class ThongKeController : Controller
    {
        private ThuVienDbContext _db = new ThuVienDbContext();
        //
        // GET: /ThongKe/
        public ActionResult Index()
        {
            ViewData["DocGia"] = _db.DocGia.ToList().Select(i => new DocGiaViewModel(i)).ToList();
            return View();
        }

        public JsonResult GetDataStatistic(FormCollection form)
        {

            var docgia_id = form["DocGiaID"];
            var datefrom = form["DateFrom"];
            var dateto = form["DateTo"];



            if (docgia_id != null && datefrom != null && dateto != null)
            {
                int id = Convert.ToInt32(docgia_id);

                var Arr_datefrom = datefrom.ToString().Split('-');
                var Arr_dateto = dateto.ToString().Split('-');

                DateTime date1 = new DateTime(Convert.ToInt32(Arr_datefrom[0]), Convert.ToInt32(Arr_datefrom[1]), Convert.ToInt32(Arr_datefrom[2])); /*new DateTime(form["FromDate"]);*/
                DateTime date2 = new DateTime(Convert.ToInt32(Arr_dateto[0]), Convert.ToInt32(Arr_dateto[1]), Convert.ToInt32(Arr_dateto[2])); /*form["ToDate"];*/

                //DateTime date1 = new DateTime(2016, 10, 20);
                //DateTime date2 = new DateTime(2016, 10, 22);

                var list = _db.PhieuMuon.Join(_db.ChiTietMuon, pm => pm.ID, ctm => ctm.PhieuMuonID, (pm, ctm) => new
                {
                    PhieuMuon = pm,
                    ChiTietMuon = ctm
                }).Join(_db.CuonSach, ctm => ctm.ChiTietMuon.CuonSachID, cs => cs.ID, (ctm, cs) => new
                {
                    ChiTietMuon = ctm,
                    CuonSach = cs
                }).Where(i => i.ChiTietMuon.PhieuMuon.DocGiaID == id &&
                i.ChiTietMuon.PhieuMuon.NgayMuon >= date1 &&
                i.ChiTietMuon.PhieuMuon.NgayMuon <= date2).Select(i => new
                {
                    NgayMuon = i.ChiTietMuon.PhieuMuon.NgayMuon,
                    PhieuMuonID = i.ChiTietMuon.PhieuMuon.ID,
                    CuonSachID = i.CuonSach.ID,
                    MaVachCuonSach = i.CuonSach.MaVach,
                    DauSachID = i.CuonSach.DauSach.ID,
                    TenDauSach = i.CuonSach.DauSach.Ten,
                }).ToList();


                var docgia = _db.DocGia.ToList().Where(i => i.ID.Equals(id)).Select(i => new DocGiaViewModel(i)).FirstOrDefault();

                var return_data = new
                {
                    Data_Statistic = list,
                    Data_reader = docgia
                };

                return Json(return_data);
            }
            else
            {
                return Json("error");
            }
        }
    }
}