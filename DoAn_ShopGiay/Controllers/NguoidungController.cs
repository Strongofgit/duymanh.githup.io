using DoAn_ShopGiay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace DoAn_ShopGiay.Controllers
{
    public class NguoidungController : Controller
    {
        dbQLBanGiayDataContext data = new dbQLBanGiayDataContext();
        // GET: NguoiDung
        private static string codecheck;
        private static string emailcheck;

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangKy(FormCollection collection, KHACHHANG kh)
        {
            var hoten = collection["HotenKH"];
            var tendn = collection["TenDN"];
            var matkhau = collection["MatKhau"];
            var matkhaunhaplai = collection["MatKhaunhaplai"];
            var email = collection["Email"];
            var diachi = collection["DiaChi"];
            var dienthoai = collection["DienThoai"];
            var ngaysinh = String.Format("{0:MM/dd/yyyy}", collection["Ngaysinh"]);
            if (String.IsNullOrEmpty(hoten))
            {
                ViewData["Loi1"] = "Họ Tên khách hàng không được để trống";
            }
            else if (String.IsNullOrEmpty(tendn))
            {
                ViewData["Loi2"] = "Phải nhập tên đăng nhập";
            }
            else if (String.IsNullOrEmpty(matkhau))
            {
                ViewData["Loi3"] = "Phải nhập mật khẩu";
            }
            else if (String.IsNullOrEmpty(matkhaunhaplai))
            {
                ViewData["Loi4"] = "Phải nhập lại mật khẩu";
            }
            else if (String.IsNullOrEmpty(email))
            {
                ViewData["Loi5"] = "Email không được bỏ trống";
            }
            else if (String.IsNullOrEmpty(dienthoai))
            {
                ViewData["Loi6"] = "Phải nhập số điện thoại";
            }
            else
            {
                //gắn giá trị cho đối tượng được tạo mới (kh)
                kh.HoTen = hoten;
                kh.Taikhoan = tendn;
                kh.Matkhau = matkhau;
                kh.Email = email;
                kh.DiachiKH = diachi;
                kh.DienthoaiKH = dienthoai;
                kh.Ngaysinh = DateTime.Parse(ngaysinh);
                data.KHACHHANGs.InsertOnSubmit(kh);
                data.SubmitChanges();
                return RedirectToAction("Dangnhap");
            }
            
            return this.DangKy();
        }
        [HttpGet]
        public ActionResult Dangnhap()
        {
            return View();
        }
        public ActionResult Dangnhap(FormCollection collection)
        {
            
            var tendn = collection["TenDN"];
            var matkhau = collection["MatKhau"];
            if (String.IsNullOrEmpty(tendn))
            {
                ViewData["Loi1"] = "Phải nhập tên đăng nhập";              
            }
            else if (String.IsNullOrEmpty(matkhau))
            {
                ViewData["Loi2"] = "Phải nhập mật khẩu";
            }
            else
            {
                KHACHHANG kh = data.KHACHHANGs.SingleOrDefault(n => n.Taikhoan == tendn && n.Matkhau == matkhau);
                if (kh != null)
                {
                    ViewBag.Thongbao = "Đăng Nhập thành công";
                    Session["Taikhoan"] = kh;

                    return RedirectToAction("Index", "ShopGiay");
                }
                else
                {
                    ViewBag.Thongbao = "Tên đăng nhập hoặc mật khẩu không đúng ";
                   
                }
            }
            return this.Dangnhap();
        }

        public void sendEmail(string toEmail, string subject, string emailBody)
        {            
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("webbangiayhoanghuy@gmail.com");
            mail.Sender = new MailAddress("webbangiayhoanghuy@gmail.com");
            mail.To.Add(toEmail);        
            mail.Subject = subject;
            mail.Body = emailBody;
            mail.IsBodyHtml = true;
            mail.BodyEncoding = UTF8Encoding.UTF8;

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

        public ActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ForgotPassword(FormCollection collection)
        {
            Random rnd = new Random();
            emailcheck = collection["email"];
            KHACHHANG kh = data.KHACHHANGs.SingleOrDefault(n => n.Email.Equals(emailcheck));
            codecheck = rnd.Next(100000, 1000000).ToString();
            if (!emailcheck.Contains("@"))
            {
                ViewData["error1"] = "Nhập sai địa chỉ email!";
                return this.View();
            }
            else
            {
                if (kh == null)
                {
                    ViewData["error2"] = "Địa chỉ email không tồn tại!";
                    return this.View();
                }
                else
                {
                    sendEmail(emailcheck, "Code xác thực tài khoản", "Bạn vừa yêu cầu đổi lại mật khẩu tại ShopGiay.\nCode xác thực: " + codecheck);
                    return RedirectToAction("WriteCode", "NguoiDung");
                }
            }
        }
        public ActionResult WriteCode()
        {
            ViewData["email"] = emailcheck;
            return View();
        }
        [HttpPost]
        public ActionResult WriteCode(FormCollection collection)
        {
            var code = collection["code"];
            if (code.Equals(codecheck))
            {
                return RedirectToAction("ChangePassword", "NguoiDung");
            }
            ViewData["error"] = "Nhập sai! Vui lòng nhập lại.";
            return this.View();
        }
        public ActionResult ChangePassword()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ChangePassword(FormCollection collection)
        {
            var pass = collection["pass"];
            var rppass = collection["rppass"];
            if ((pass == null) || (rppass == null))
            {
                return RedirectToAction("ChangePassword", "NguoiDung"); //Json(new { msg = "Vui lòng điền đầy đủ thông tin!", url = "/NguoiDung/ChangePassword" });
            }
            if (!pass.Equals(rppass))
            {
                return RedirectToAction("ChangePassword", "NguoiDung");//Json(new { msg = "Mật khẩu không trùng khớp!", url = "/NguoiDung/ChangePassword" });
            }
            KHACHHANG kh = data.KHACHHANGs.SingleOrDefault(n => n.Email == emailcheck);
            kh.Matkhau = pass;
            data.SubmitChanges();
            codecheck = null;
            emailcheck = null;

            return RedirectToAction("Dangnhap", "NguoiDung");//Json(new { msg = "Đổi mật khẩu thành công!", url = "/NguoiDung/Dangnhap" });
        }
    }
}