using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoAn_ShopGiay.Models;
using PagedList;
using PagedList.Mvc;
namespace DoAn_ShopGiay.Controllers
{
    public class ShopGiayController : Controller
    {
        // GET: ShopGiay
        dbQLBanGiayDataContext data = new dbQLBanGiayDataContext();

        public dbQLBanGiayDataContext Data { get => data; set => data = value; }

        private List<GIAY> laygiaymoi(int count)
        {
            // sắp xếp theo ngày 
            return Data.GIAYs.OrderByDescending(a => a.Ngaycapnhat).ToList();
        }

        public ActionResult Index(int ? page)
        {
            //Tạo biến quy định số sản phẩm trên mỗi trang
            int pageSize =9;
            // Tao bien so trang
            int pageNum = (page ?? 1);
            //lay 10 giay moi nhat
            var giaymoi = laygiaymoi(67);
            
            return View(giaymoi.ToPagedList(pageNum, pageSize));
        }
    
        public ActionResult Loai()
        {
            var loai = from l in Data.LOAIs select l;
            return PartialView(loai);
        }
        public ActionResult Hang()
        {
            var hang = from h in Data.HANGs select h;
            return PartialView(hang);
        }
        public ActionResult SPTheoLOAI(int id, int? page)
        {
            int pageSize = 9;
            // Tao bien so trang
            int pageNum = (page ?? 1);
            //
            var giay = from l in Data.GIAYs where l.MaLOAI == id select l;
            return View(giay.ToPagedList(pageNum, pageSize));
        }
        public ActionResult SPTheoHANG(int id,int? page)
        {
            int pageSize = 9;
            // Tao bien so trang
            int pageNum = (page ?? 1);
            //
            var giay = from l in Data.GIAYs where l.MaHANG == id select l;
            return View(giay.ToPagedList(pageNum, pageSize));
        }
        public ActionResult Details(int id)
        {
            var giay = from g in Data.GIAYs
                       where g.MaGIAY == id
                       select g;


            var querysize = from ctgiay in Data.CHITIETGIAYs
                           join sizegiay in Data.SIZEGIAYs on ctgiay.MaSize equals sizegiay.MaSize
                            where (ctgiay.MaGIAY == id) && (ctgiay.SoLuongTon > 0)
                            select sizegiay; 

            List < SIZEGIAY > listSizeGiay = querysize.ToList<SIZEGIAY>();
            if (listSizeGiay.Count == 0)
            {
                TempData["Tag"] = "Hết hàng!";
            }
            ViewBag.MaSize = new SelectList(listSizeGiay.OrderBy(n => n.Size), "MaSize", "Size");

            return View(giay.Single());
        }
        [HttpGet]
        public ActionResult TimKiem(string tukhoa, int? page)
        {
            ViewBag.TuKhoa = tukhoa;
            List<GIAY> listtk = Data.GIAYs.Where(n => n.TenGIAY.Contains(tukhoa)).ToList();
            //phan trang cho kq tim kiem
            int pageSize = 9;
            // Tao bien so trang
            int pageNum = (page ?? 1);
            //lay 10 giay moi nhat
            var giaymoi = laygiaymoi(67);
            if (listtk.Count == 0)
            {
                ViewBag.ThongBao = "Không tìm thấy sản phẩm nào có từ khóa này";
                ViewBag.ThongBao2 = "Dưới đây là một số sản phẩm! Mời bạn xem!";
                return View(Data.GIAYs.OrderBy(n => n.TenGIAY).ToPagedList(pageNum, pageSize));
            }
            ViewBag.ThongBao = "Đã tìm thấy " + listtk.Count + " kết quả!";
            return View(listtk.OrderBy(n => n.TenGIAY).ToPagedList(pageNum, pageSize));
        }
        [HttpPost]
        public ActionResult TimKiem(FormCollection f, int? page)
        {
            string tukhoa = f["txtTimKiem"].ToString();
            ViewBag.TuKhoa = tukhoa;
            List<GIAY> listtk = Data.GIAYs.Where(n => n.TenGIAY.Contains(tukhoa)).ToList();
            //phan trang cho kq tim kiem
            int pageSize = 9;
            // Tao bien so trang
            int pageNum = (page ?? 1);
            //lay 10 giay moi nhat
            var giaymoi = laygiaymoi(67);
            if (listtk.Count == 0)
            {
                ViewBag.ThongBao = "Không tìm thấy sản phẩm nào có từ khóa này";
                ViewBag.ThongBao2 = "Dưới đây là một số sản phẩm của shop! Mời bạn xem!";
                return View(Data.GIAYs.OrderBy(n => n.TenGIAY).ToPagedList(pageNum,pageSize));
            }
            ViewBag.ThongBao = "Đã tìm thấy " + listtk.Count + " kết quả!";
            return View(listtk.OrderBy(n => n.TenGIAY).ToPagedList(pageNum, pageSize));
        }
    }
}