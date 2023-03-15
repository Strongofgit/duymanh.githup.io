using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace DoAn_ShopGiay.Models
{
    public class Giohang
    {
        //Tạo đối tượng  data chứa dữ liệu từ model dbQLBansach đã tạo
        dbQLBanGiayDataContext data = new dbQLBanGiayDataContext();
        public int iMaGIAY { get; set; }
        public string sTenGIAY { get; set; }
        public string sAnhbia { get; set; }
        public int iMaSize { get; set; }
        public int iSize { get; set; }
        public Double dDongia { get; set; }
        public int iSoluong { get; set; }
        public Double dThanhtien
        {
            get { return iSoluong * dDongia; }
        }
        //Khởi tạo gio hàng theo Ma giay được truyền vào với số lượng mặc định là 1
        public Giohang(int MaGIAY, int MaSize)
        {
            iMaGIAY = MaGIAY;
            iMaSize = MaSize;
            GIAY giay = data.GIAYs.Single(n => n.MaGIAY == iMaGIAY);
            SIZEGIAY sizegiay = data.SIZEGIAYs.Single(n => n.MaSize == iMaSize);
            iSize = (int)sizegiay.Size;
            sTenGIAY = giay.TenGIAY;
            sAnhbia = giay.Anhbia;
            dDongia = double.Parse(giay.Giaban.ToString());
            iSoluong = 1;
        }
    }
}