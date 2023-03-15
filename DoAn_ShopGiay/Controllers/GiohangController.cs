using Commmon;
using DoAn_ShopGiay.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace DoAn_ShopGiay.Controllers
{
    public class GiohangController : Controller
    {
        dbQLBanGiayDataContext data = new dbQLBanGiayDataContext();
        // GET: Giohang
        // lay gio hang
        public List<Giohang> Laygiohang()
        {
            List<Giohang> lstGiohang = Session["Giohang"] as List<Giohang>;
            if (lstGiohang == null)
            {
                // Nếu gio hàng chưa tồn tại thì khởi tạo listGiohang
                lstGiohang = new List<Giohang>();

                Session["Giohang"] = lstGiohang;
            }
            return lstGiohang;
        }
        //Cập nhập phương thức ThemGiohang
        public ActionResult ThemGiohang(int iMaGIAY, string strURL, int maSize)
        {
            // lấy ra Session gio hang
            List<Giohang> lstGiohang = Laygiohang();
            // kiểm tra sách này tồn tại trong Session["Giohang"] chưa ?
            Giohang sanpham = lstGiohang.Find(n => n.iMaGIAY == iMaGIAY);

            if (sanpham == null)
            {
                sanpham = new Giohang(iMaGIAY,maSize);
                lstGiohang.Add(sanpham);
                return Redirect(strURL);
            }
            else
            {
                sanpham.iSoluong++;
                return Redirect(strURL);
            }
        }
        //Phương thức tính tổng số lượng
        private int TongSoLuong()
        {
            int iTongSoLuong = 0;
            List<Giohang> lstgiohangs = Session["GioHang"] as List<Giohang>;
            if (lstgiohangs != null)
            {
                iTongSoLuong = lstgiohangs.Sum(n => n.iSoluong);
            }
            return iTongSoLuong;
        }
        //Phương thức Tính Tổng tiền 
        private double TongTien()
        {
            double iTongTien = 0;
            List<Giohang> lstGiohang = Session["GioHang"] as List<Giohang>;
            if (lstGiohang != null)
            {
                iTongTien = lstGiohang.Sum(n => n.dThanhtien);
            }
            return iTongTien;
        }

        public ActionResult GioHang()
        {
            List<Giohang> lstGiohang = Laygiohang();

            if (lstGiohang.Count == 0)
            {
                return RedirectToAction("Index", "ShopGiay");
            }
            ViewBag.Tongsoluong = TongSoLuong();
            ViewBag.Tongtien = TongTien();

            return View(lstGiohang);
        }
        public ActionResult GiohangPartial()
        {
            ViewBag.Tongsoluong = TongSoLuong();
            ViewBag.Tongtien = TongTien();
            return PartialView();
        }
        public ActionResult XoaGiohang(int iMaSP)
        {
            // Lay gio hang tu Session
            List<Giohang> lstGiohang = Laygiohang();
            // Kiem tra sach da co trong Session["Giohang"]
            Giohang sanpham = lstGiohang.SingleOrDefault(n => n.iMaGIAY == iMaSP);
            //Neu ton tai thi cho sua so luong
            if (sanpham != null)
            {
                lstGiohang.RemoveAll(n => n.iMaGIAY == iMaSP);
                return RedirectToAction("GioHang");
            }
            if (lstGiohang.Count == 0)
            {
                return RedirectToAction("Index", "ShopGiay");
            }
            return RedirectToAction("GioHang");
        }
        // cap nhap gio hang
        public ActionResult CapnhatGiohang(int iMaSP, int iMaS, FormCollection f)
        {
            int slnhap = 0;
            // Lay gio hang tu Session
            List<Giohang> lstGiohang = Laygiohang();
            // Kiem tra sach da co trong Session["Giohang"]
            Giohang sanpham = lstGiohang.SingleOrDefault(n => n.iMaGIAY == iMaSP);
            Giohang sanphamsize = lstGiohang.SingleOrDefault(n => n.iMaSize == iMaS);
            if (sanpham != null)
            {
                sanpham.iSoluong = int.Parse(f["txtSoluong"].ToString());
                slnhap = sanpham.iSoluong;
            }
     
            var querysoluongton = from ctgiay in data.CHITIETGIAYs
                                  join sizegiay in data.SIZEGIAYs on ctgiay.MaSize equals sizegiay.MaSize
                                  where ctgiay.MaSize == iMaS
                                  && ctgiay.MaGIAY == iMaSP
                                  select ctgiay;

            List<CHITIETGIAY> listChiTietGiay = querysoluongton.ToList<CHITIETGIAY>();

            int slton = 0;

            if (listChiTietGiay.Count > 0)
            {
                slton = (int)listChiTietGiay[0].SoLuongTon;
            }

            if (slton < slnhap)
            {
                TempData["Tag"] = "Số lượng giày không đủ !!!";
                sanpham.iSoluong = slton;
            }
            
            return RedirectToAction("Giohang");
        }
        public ActionResult XoaTatcaGiohang()
        {
            List<Giohang> lstGiohang = Laygiohang();
            lstGiohang.Clear();
            return RedirectToAction("Index", "ShopGiay");
        }
        //Hien thi View Dat hang de cap nhat cac thong tin cho don hang
        [HttpGet]
        public ActionResult Dathang()
        {
            //kiem tra dang nhap
            if (Session["TaiKhoan"] == null || Session["TaiKhoan"].ToString() == "")
            {
                return RedirectToAction("Dangnhap", "Nguoidung");
            }
            if (Session["Giohang"] == null)
            {
                return RedirectToAction("Index", "ShopGiay");
            }

            // Lay gio hang tu Session
            List<Giohang> lstGiohang = Laygiohang();
            ViewBag.Tongsoluong = TongSoLuong();
            ViewBag.Tongtien = TongTien();

            return View(lstGiohang);
        }
        [HttpPost]
        public ActionResult Dathang(CHITIETGIAY ctgiay, FormCollection collection)
        {
            //Them Don hang
            DONDATHANG ddh = new DONDATHANG();
            KHACHHANG kh = (KHACHHANG)Session["TaiKhoan"];
            List<Giohang> gh = Laygiohang();
            ddh.MaKH = kh.MaKH;
            ddh.Ngaydat = DateTime.Now;
            var ngaygiao = String.Format("{0:MM/dd/yyyy}", collection["Ngaygiao"]);
            
            ddh.Tinhtranggiaohang = false;
            ddh.Dathanhtoan = false;
            ddh.Tongtien = Convert.ToDecimal(TongTien());
            data.DONDATHANGs.InsertOnSubmit(ddh);
            data.SubmitChanges();
            decimal total = Convert.ToDecimal(TongTien());
            //Them Chi tiet don hang
            foreach (var item in gh)
            {
                CHITIETDONTHANG ctdh = new CHITIETDONTHANG();
                ctdh.MaDonHang = ddh.MaDonHang;
                ctdh.MaGIAY = item.iMaGIAY;
                ctdh.Soluong = item.iSoluong;
                ctdh.Dongia = (decimal)item.dDongia;
                data.CHITIETDONTHANGs.InsertOnSubmit(ctdh);
            }

            foreach (var item in gh)
            {
                var queryctgiay = from ctgiay1 in data.CHITIETGIAYs
                                  where ctgiay1.MaGIAY == item.iMaGIAY
                                  && ctgiay1.MaSize == item.iMaSize
                                  select ctgiay1;

                List<CHITIETGIAY> listctgiay = queryctgiay.ToList<CHITIETGIAY>();
                if (listctgiay.Count > 0)
                {
                    if (listctgiay[0].MaGIAY == item.iMaGIAY && listctgiay[0].MaSize == item.iMaSize)
                    {
                        listctgiay[0].SoLuongTon = listctgiay[0].SoLuongTon - item.iSoluong;
                        ctgiay.SoLuongTon = listctgiay[0].SoLuongTon;
                        if (ctgiay.MaGIAY == item.iMaGIAY && ctgiay.MaGIAY == item.iMaSize)
                        {
                            UpdateModel(ctgiay);
                        }    
                    }    
                }    
            }
            data.SubmitChanges();
            Session["Giohang"] = null;
            
            string content = System.IO.File.ReadAllText(Server.MapPath("~/assets/template/Neworder.html"));
            content = content.Replace("{{HoTen}}", kh.HoTen);
            content = content.Replace("{{DienthoaiKH}}", kh.DienthoaiKH);
            content = content.Replace("{{Email}}", kh.Email);
            content = content.Replace("{{DiachiKH}}", kh.DiachiKH);
            content = content.Replace("{{Tongtien}}", ddh.Tongtien.ToString());
            string conten = System.IO.File.ReadAllText(Server.MapPath("~/assets/template/HtmlAd.html"));
            conten = conten.Replace("{{HoTen}}", kh.HoTen);
            conten = conten.Replace("{{DienthoaiKH}}", kh.DienthoaiKH);
            conten = conten.Replace("{{Email}}", kh.Email);
            conten = conten.Replace("{{DiachiKH}}", kh.DiachiKH);
            conten = conten.Replace("{{Tongtien}}", ddh.Tongtien.ToString());

            var toEmail = kh.Email;
            //new MailHelper().SendMail(kh.Email, "Đơn hàng mới từ Web bán giày.", content);
            //new MailHelper().SendMail(toEmail, "Đơn hàng mới từ Web bán giày.", content);
            var EmailAD = "dangduymanh2010@gmail.com";
            sendEmail(toEmail, "Bạn vừa đặt một đơn hàng mới từ Shop Giay", content);
            sendEmail(EmailAD, "Đơn hàng mới từ khách hàng: " + kh.HoTen, conten);

            return RedirectToAction("Xacnhandonhang", "Giohang");
        }

        public void sendEmail(string toEmail, string subject, string emailBody)
        {
            KHACHHANG kh = (KHACHHANG)Session["TaiKhoan"];
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("webbangiayhoanghuy@gmail.com");
            mail.Sender = new MailAddress("webbangiayhoanghuy@gmail.com");
            mail.To.Add(toEmail);

            mail.IsBodyHtml = true;
            mail.Subject = subject;
            mail.Body = emailBody;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;

            smtp.Credentials = new System.Net.NetworkCredential("dangduymanh2010@gmail.com", "myjvlunmkyqunyic");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = true;

            smtp.Timeout = 30000;
            try
            {

                smtp.Send(mail);
            }
            catch
            {     
            }
        }

        public ActionResult Xacnhandonhang()
        {

            return View();
        }
    }
}