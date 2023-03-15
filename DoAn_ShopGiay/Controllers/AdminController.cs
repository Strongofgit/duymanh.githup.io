using DoAn_ShopGiay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using System.IO;

namespace DoAn_ShopGiay.Controllers
{
    public class AdminController : Controller
    {

        // GET: Admin
        dbQLBanGiayDataContext data = new dbQLBanGiayDataContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Giay(int ? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 5;
            //return View(data.GIAYs.ToList());
            return View(data.GIAYs.ToList().OrderBy(n => n.MaGIAY).ToPagedList(pageNumber, pageSize));
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection f)
        {
            var tendn = f["txtuser"];
            var matkhau = f["txtpass"];
            if (String.IsNullOrEmpty(tendn))
                ViewData["Loi1"] = "Vui lòng nhập tài khoản";
            else if (String.IsNullOrEmpty(matkhau))
                ViewData["Loi2"] = "Vui lòng nhập mật khẩu";
            else
            {
                var ad = data.Admins.FirstOrDefault(n => n.UserAdmin == tendn && n.PassAdmin == matkhau);
                if (ad != null)
                {
                    Session["Taikhoanadmin"] = ad;
                    return RedirectToAction("Index", "Admin");
                }
                else
                    ViewBag.Thongbao = "Tên đăng nhập hoặc mật khẩu không hợp lệ";
            }

            return View();
        }
        [HttpGet]
        public ActionResult ThemmoiGiay()
        {
            ViewBag.MaLOAI = new SelectList(data.LOAIs.ToList().OrderBy(n => n.TenLOAI), "MaLOAI", "TenLOAI");
            ViewBag.MaHANG = new SelectList(data.HANGs.ToList().OrderBy(n => n.TenHANG), "MaHANG", "TenHANG");
            return View();
        }
        [HttpPost]
        public ActionResult ThemmoiGiay(GIAY giaymoine, HttpPostedFileBase fileupload)
        {
            ViewBag.MaLOAI = new SelectList(data.LOAIs.ToList().OrderBy(n => n.TenLOAI), "MaLOAI", "TenLOAI");
            ViewBag.MaHANG = new SelectList(data.HANGs.ToList().OrderBy(n => n.TenHANG), "MaHANG", "TenHANG");
            if (fileupload == null)
            {
                ViewBag.Thongbao = "Vui lòng chọn ảnh bìa";
                return View();
            }
            else
            {
                if (ModelState.IsValid)
                {
                    //Luu ten file, luu y bo sung thu vien using System.IO;
                    var fileName = Path.GetFileName(fileupload.FileName);
                    // luu duong dan cua file
                    var path = Path.Combine(Server.MapPath("~/Hinhsanpham"), fileName);
                    //Kiem tra hinh anh ton tai chua ?
                    if (System.IO.File.Exists(path))
                    {
                        ViewBag.Thongbao = "Hình ảnh đã tồn tại";
                    }
                    else
                    {
                        // luu hinh anh vao duong dan
                        fileupload.SaveAs(path);
                    }
                    giaymoine.Anhbia = fileName;
                    data.GIAYs.InsertOnSubmit(giaymoine);
                    data.SubmitChanges();
                }
                return RedirectToAction("Giay");
            }
        }
        public ActionResult Chitietgiay(int id)
        {
            //lay ra doi tuong sach theo ma
            GIAY giay = data.GIAYs.SingleOrDefault(n => n.MaGIAY == id);
            ViewBag.MaGIAY = giay.MaGIAY;
            if (giay == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(giay);
        }
        //xoa san pham
        [HttpGet]
        public ActionResult Xoagiay(int id)
        {
            GIAY giay = data.GIAYs.SingleOrDefault(n => n.MaGIAY == id);
            ViewBag.MaGIAY = giay.MaGIAY;
            if (giay == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(giay);
        }
        [HttpPost, ActionName("Xoagiay")]
        public ActionResult Xacnhanxoa(int id)
        {
            GIAY sach = data.GIAYs.SingleOrDefault(n => n.MaGIAY == id);
            ViewBag.MaGIAY = sach.MaGIAY;
            if (sach == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            data.GIAYs.DeleteOnSubmit(sach);
            data.SubmitChanges();
            return RedirectToAction("Giay");
        }
        [HttpGet]
        public ActionResult Suagiay(int id)
        {
            /*GIAY giay = data.GIAYs.SingleOrDefault(n => n.MaGIAY == id);
            if (giay == null)
            {
                Response.StatusCode = 404;
                return null;
            }*/
            var E_giay = data.GIAYs.First(m => m.MaGIAY == id);

            ViewBag.MaLOAI = new SelectList(data.LOAIs.ToList().OrderBy(n => n.TenLOAI), "MaLOAI", "TenLOAI", E_giay.MaLOAI);
            ViewBag.MaHANG = new SelectList(data.HANGs.ToList().OrderBy(n => n.TenHANG), "MaHANG", "TenHANG", E_giay.MaHANG);
            return View(E_giay);
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Suagiay(/*GIAY giay*/int id, FormCollection collection, HttpPostedFileBase fileupload)
        {
            var giay = data.GIAYs.First(m => m.MaGIAY == id);
            var E_tengiay = collection["TenGIAY"];
            ViewBag.MaLOAI = new SelectList(data.LOAIs.ToList().OrderBy(n => n.TenLOAI), "MaLOAI", "TenLOAI", giay.MaLOAI);
            ViewBag.MaHANG = new SelectList(data.HANGs.ToList().OrderBy(n => n.TenHANG), "MaHANG", "TenHANG", giay.MaHANG);
            giay.MaGIAY = id;
            if(string.IsNullOrEmpty(E_tengiay))
            {
                ViewData["Error"] = "Don't Empty!";
            }    
            else
            {
                giay.TenGIAY = E_tengiay;
                UpdateModel(giay);
                data.SubmitChanges();
                return RedirectToAction("Giay");
            }
            return this.Suagiay(id);
            
            /*if (fileupload == null)
            {
                ViewBag.Thongbao = "Vui lòng chọn ảnh bìa";
                return View();
            }
            else
            {
                if (ModelState.IsValid)
                {
                    var fileName = Path.GetFileName(fileupload.FileName);
                    var path = Path.Combine(Server.MapPath("~/Hinhsanpham"), fileName);
                    if (System.IO.File.Exists(path))
                        ViewBag.Thongbao = "Hình ảnh đã tồn tại";
                    else
                    {
                        fileupload.SaveAs(path);
                    }
                    giay.Anhbia = fileName;
                    GIAY g = data.GIAYs.FirstOrDefault(gi => gi.MaGIAY == giay.MaGIAY);
                    g.MaGIAY = giay.MaGIAY;
                    g.Anhbia = giay.Anhbia;
                    g.Giaban = giay.Giaban;
                    g.MaHANG = giay.MaHANG;
                    g.MaLOAI = giay.MaLOAI;
                    g.Mota = giay.Mota;
                    g.Ngaycapnhat = giay.Ngaycapnhat;
                    g.TenGIAY = giay.TenGIAY;
                    data.SubmitChanges();
                }
            }
            return RedirectToAction("Giay");
            */
        }

        //************************************************** LOAI **********************************************************
        public ActionResult Loai()
        {
            return View(data.LOAIs.ToList());
        }
        [HttpGet]
        public ActionResult ThemmoiLoai()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ThemmoiLoai(LOAI loai)
        {                           
                data.LOAIs.InsertOnSubmit(loai);
                data.SubmitChanges();
                return RedirectToAction("Loai");
            
        }

        [HttpGet]
        public ActionResult Xoaloai(int id)
        {
            LOAI loai = data.LOAIs.SingleOrDefault(n => n.MaLOAI == id);
            ViewBag.MaLOAI = loai.MaLOAI;
            if (loai == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(loai);
        }
        [HttpPost, ActionName("Xoaloai")]
        public ActionResult Xacnhanxoaloai(int id)
        {

                LOAI loai = data.LOAIs.SingleOrDefault(n => n.MaLOAI == id);
                ViewBag.MaLOAI = loai.MaLOAI;
                if (loai == null)
                {
                    Response.StatusCode = 404;
                    return null;
                }
                data.LOAIs.DeleteOnSubmit(loai);
                data.SubmitChanges();


            return RedirectToAction("Loai");
        }

        [HttpGet]
        public ActionResult Sualoai(int id)
        {
            LOAI loai = data.LOAIs.SingleOrDefault(n => n.MaLOAI == id);
            if (loai == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(loai);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Sualoai( LOAI loai)
        {
            LOAI l = data.LOAIs.FirstOrDefault(t => t.MaLOAI == loai.MaLOAI);
            if(l != null)
            {
                l.TenLOAI = loai.TenLOAI;
                data.SubmitChanges();
            }           
            return RedirectToAction("Loai");
        }

        /*
        [HttpPost]
        public ActionResult Sualoai(LOAI loai)
        {
            UpdateModel(loai);
            data.SubmitChanges();
            return RedirectToAction("Loai");
        }
        */

        //******************************************************* HANG *************************************************************
        public ActionResult Hang()
        {
            return View(data.HANGs.ToList());
        }
        [HttpGet]
        public ActionResult ThemmoiHang()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ThemmoiHang(HANG hang)
        {
            data.HANGs.InsertOnSubmit(hang);
            data.SubmitChanges();
            return RedirectToAction("Hang");
        }
        

        [HttpGet]
        public ActionResult Xoahang(int id)
        {
            HANG hang = data.HANGs.SingleOrDefault(n => n.MaHANG == id);
            ViewBag.MaHANG = hang.MaHANG;
            if (hang == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(hang);
        }
        [HttpPost, ActionName("Xoahang")]
        public ActionResult Xacnhanxoahang(int id)
        {

                HANG hang = data.HANGs.SingleOrDefault(n => n.MaHANG == id);
                ViewBag.MaHANG = hang.MaHANG;
                if (hang == null)
                {
                    Response.StatusCode = 404;
                    return null;
                }
                data.HANGs.DeleteOnSubmit(hang);
                data.SubmitChanges();
            return RedirectToAction("Hang");
        }

        [HttpGet]
        public ActionResult Suahang(int id)
        {
            /*
            HANG hang = data.HANGs.SingleOrDefault(n => n.MaHANG == id);
            if (hang == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            */
            var E_hang = data.HANGs.First(m => m.MaHANG == id);
            return View(E_hang);
        }

        [HttpPost]
        public ActionResult Suahang(/*HANG hang*/ int id, FormCollection collection)
        {
            /*HANG h = data.HANGs.FirstOrDefault(t => t.MaHANG == hang.MaHANG);
            if (h != null)
            {
                h.TenHANG = hang.TenHANG;
                h.Diachi = hang.Diachi;
                h.DienThoai = hang.DienThoai;
                data.SubmitChanges();
            }
                return RedirectToAction("Hang");
            */
            var hang = data.HANGs.First(m => m.MaHANG == id);
            var E_tenhang = collection["TenHANG"];
            hang.MaHANG = id;
            if (string.IsNullOrEmpty(E_tenhang))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                hang.TenHANG = E_tenhang;
                UpdateModel(hang);
                data.SubmitChanges();
                return RedirectToAction("Hang");
            }
            return this.Suahang(id);
        }
        //*************************************************** KHACH HANG ************************************************
        public ActionResult Khachhang(int ? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 10;
            //return View(data.GIAYs.ToList());
            return View(data.KHACHHANGs.ToList().OrderBy(n => n.MaKH).ToPagedList(pageNumber, pageSize));
        }
        public ActionResult Chitietkhachhang(int id)
        {
            //lay ra doi tuong sach theo ma
            KHACHHANG kh = data.KHACHHANGs.SingleOrDefault(n => n.MaKH == id);
            ViewBag.MaGIAY = kh.MaKH;
            if (kh == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(kh);
        }

        [HttpGet]
        public ActionResult Xoakhachhang(int id)
        {
            KHACHHANG kh = data.KHACHHANGs.SingleOrDefault(n => n.MaKH == id);
            ViewBag.MaKH = kh.MaKH;
            if (kh == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(kh);
        }
        [HttpPost, ActionName("Xoakhachhang")]
        public ActionResult Xacnhanxoakhachhang(int id)
        {
            KHACHHANG kh = data.KHACHHANGs.SingleOrDefault(n => n.MaKH == id);
            ViewBag.MaKH = kh.MaKH;
            if (kh == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            data.KHACHHANGs.DeleteOnSubmit(kh);
            data.SubmitChanges();
            return RedirectToAction("Khachhang");
        }

        [HttpGet]
        public ActionResult Suakhachhang(int id)
        {
            /*
            KHACHHANG kh = data.KHACHHANGs.SingleOrDefault(n => n.MaKH == id);
            if (kh == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(kh);
            */
            var kh = data.KHACHHANGs.First(m => m.MaKH == id);
            return View(kh);
        }

        [HttpPost]
        public ActionResult Suakhachhang(/*KHACHHANG kh*/int id, FormCollection collection)
        {
            /*
            UpdateModel(kh);
            data.SubmitChanges();
            return RedirectToAction("Khachhang");
            */
            var khachhang = data.KHACHHANGs.First(m => m.MaKH == id);
            var E_tenkh = collection["HoTen"];
            khachhang.MaKH = id;
            if (string.IsNullOrEmpty(E_tenkh))
            {
                ViewData["Error"] = "Don't empty!";
            }    
            else
            {
                khachhang.HoTen = E_tenkh;
                UpdateModel(khachhang);
                data.SubmitChanges();
                return RedirectToAction("Khachhang");
            }
            return this.Suakhachhang(id);
        }

        //********************************************************* Quản lý Size ***********************************
        public ActionResult Size()
        {
            return View(data.SIZEGIAYs.ToList());
        }
        [HttpGet]
        public ActionResult ThemmoiSize()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ThemmoiSize(SIZEGIAY sizegiay)
        {
            data.SIZEGIAYs.InsertOnSubmit(sizegiay);
            data.SubmitChanges();
            return RedirectToAction("Size");

        }

        [HttpGet]
        public ActionResult XoaSize(int id)
        {
            SIZEGIAY sizegiay = data.SIZEGIAYs.SingleOrDefault(n => n.MaSize == id);
            ViewBag.MaSize = sizegiay.MaSize;
            if (sizegiay == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(sizegiay);
        }

        [HttpPost, ActionName("XoaSize")]
        public ActionResult XacnhanxoaSize(int id)
        {
            SIZEGIAY sizegiay = data.SIZEGIAYs.SingleOrDefault(n => n.MaSize == id);
            ViewBag.MaSize = sizegiay.MaSize;
            if (sizegiay == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            data.SIZEGIAYs.DeleteOnSubmit(sizegiay);
            data.SubmitChanges();
            return RedirectToAction("Size");
        }

        [HttpGet]
        public ActionResult SuaSize(int id)
        {
            var size = data.SIZEGIAYs.First(m => m.MaSize == id);
            return View(size);
        }

        [HttpPost]
        public ActionResult SuaSize(/*SIZEGIAY sizegiay*/ int id, FormCollection collection)
        {
            /*
            UpdateModel(sizegiay);
            data.SubmitChanges();
            return RedirectToAction("Size");
            */
            var size = data.SIZEGIAYs.First(m => m.MaSize == id);
            var E_size = collection["Size"];
            size.MaSize = id;
            if (string.IsNullOrEmpty(E_size))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                size.Size = Convert.ToInt32(E_size);
                UpdateModel(size);
                data.SubmitChanges();
                return RedirectToAction("Size");
            }
            return this.Suakhachhang(id);
        }
        //************************************************************** NhapSLGiay ***********************************************
        public ActionResult NhapSLGiay(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 20;
            //return View(data.GIAYs.ToList());
            return View(data.CHITIETGIAYs.ToList().OrderBy(n => n.MaGIAY).ToPagedList(pageNumber, pageSize));
        }
        [HttpGet]
        public ActionResult ThemmoiSLGiay()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ThemmoiSLGiay(CHITIETGIAY ctgiay)
        {
            data.CHITIETGIAYs.InsertOnSubmit(ctgiay);
            if(ctgiay != null)
            {
                data.SubmitChanges();
                
            }    
            else
            {
                ViewData["error"] = "Vui lòng nhập đầy đủ thông tin.";
            }
            return RedirectToAction("NhapSLGiay");
        }

        [HttpGet]
        public ActionResult XoaSLGiay(int id)
        {
            /*CHITIETGIAY ctgiay = data.CHITIETGIAYs.SingleOrDefault(n => n.MaGIAY == id) ;
            ViewBag.MaGIAY = ctgiay.MaGIAY; 
            if (ctgiay == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(ctgiay);
            */
            var D_SLGiay = data.CHITIETGIAYs.First(m => m.MaGIAY == id);
            return View(D_SLGiay);
        }

        [HttpPost, ActionName("XoaSLGiay")]
        public ActionResult XacnhanxoaSLGiay(int id, FormCollection collection)
        {
            /*CHITIETGIAY ctgiay = data.CHITIETGIAYs.SingleOrDefault(n => n.MaGIAY == id);
            ViewBag.MaSize = ctgiay.MaGIAY;
            if (ctgiay == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            */
            var D_SL = data.CHITIETGIAYs.Where(m => m.MaGIAY == id).First();
            data.CHITIETGIAYs.DeleteOnSubmit(D_SL);
            data.SubmitChanges();
            return RedirectToAction("NhapSLGiay");
        }

        [HttpGet]
        public ActionResult SuaSLGiay(int id)
        {
            var ctgiay = data.CHITIETGIAYs.First(m => m.MaGIAY == id);         
            return View(ctgiay);
        }

        [HttpPost]
        public ActionResult SuaSLGiay(/*CHITIETGIAY ctgiay*/int id, FormCollection collection)
        {
            /*
            UpdateModel(ctgiay);
            data.SubmitChanges();
            return RedirectToAction("NhapSLGiay");
            */
            var ctgiay = data.CHITIETGIAYs.First(m => m.MaGIAY == id);
            var E_SLTon = collection["SoLuongTon"];
            ctgiay.MaGIAY = id;
            if (string.IsNullOrEmpty(E_SLTon))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                ctgiay.SoLuongTon = Convert.ToInt32(E_SLTon);
                UpdateModel(ctgiay);
                data.SubmitChanges();
                return RedirectToAction("NhapSLGiay");
            }
            return this.Suakhachhang(id);

        }
        //************************************************************* DOANH THU *********************************************


        public ActionResult Chitietdonhang(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 20;
            return View(data.CHITIETDONTHANGs.ToList().OrderBy(n => n.MaDonHang).ToPagedList(pageNumber, pageSize));
        }

        public ActionResult Dondathang(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 20;
            return View(data.DONDATHANGs.ToList().OrderBy(n => n.MaDonHang).ToPagedList(pageNumber, pageSize));
        }
    }
}