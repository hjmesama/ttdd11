using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopConnection;

namespace DoanLTW.Models.BUS
{
    public class ShopOnlineBUS
    {
        public static IEnumerable <SanPham> DanhSach()
        {
            var db = new ShopConnectionDB();
            return db.Query<SanPham>("select * from SanPham where TinhTrang = 0");
        }
        public static SanPham ChiTiet(String a)
        {
            var db = new ShopConnectionDB();
            return db.SingleOrDefault<SanPham>("select * from SanPham where MaSanPham = @0",a);
        }
        public static IEnumerable<SanPham> Top4New()
        {
            var db = new ShopConnectionDB();
            return db.Query<SanPham>("select Top 4 * from SanPham where GhiChu = N'New' ");
        }
        public static IEnumerable<SanPham> TopHot()
        {
            var db = new ShopConnectionDB();
            return db.Query<SanPham>("select Top 4 * from SanPham where LuotView >0 ");
        }

        //---------------------------------------------------------
        public static IEnumerable<SanPham> DanhSachSP()
        {
            var db = new ShopConnectionDB();
            return db.Query<SanPham>("select * from SanPham");
        }
        public static void InsertSP(SanPham sp)
        {
            var db = new ShopConnectionDB();
            db.Insert(sp);
        }
        public static void UpdateSP(string id, SanPham sp)
        {
            var db = new ShopConnectionDB();
            db.Update(sp,id);
        }
    }
}