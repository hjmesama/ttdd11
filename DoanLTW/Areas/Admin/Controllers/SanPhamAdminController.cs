using DoanLTW.Models.BUS;
using ShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoanLTW.Areas.Admin.Controllers
{
    public class SanPhamAdminController : Controller
    {
        // GET: Admin/SanPhamAdmin
        public ActionResult Index()
        {
           
            return View(ShopOnlineBUS.DanhSachSP());
        }

        // GET: Admin/SanPhamAdmin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/SanPhamAdmin/Create
        public ActionResult Create()
        {
            ViewBag.MaNhaSanXuat = new SelectList(NhaSanXuatBUS.DanhSach(), "MaNhaSanXuat", "TenNhaSanXuat");
            ViewBag.MaLoaiSanPham = new SelectList(LoaiSanPhamBUS.DanhSach(), "MaLoaiSanPham", "TenLoaiSanPham");
            return View();
        }

        // POST: Admin/SanPhamAdmin/Create
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(SanPham sp)
        {
            try
            {
                var hpf = HttpContext.Request.Files[0];
                if (hpf.ContentLength > 0)
                {
                    string fileName = sp.MaSanPham;
                    string fullPatchWithFileName = "~/Asset/img/" + fileName + ".jpg";
                    hpf.SaveAs(Server.MapPath(fullPatchWithFileName));
                    sp.HinhChinh = sp.MaSanPham + ".jpg";
                }
                //1
                 hpf = HttpContext.Request.Files[1];
                if (hpf.ContentLength > 0)
                {
                    string fileName = sp.MaSanPham;
                    string fullPatchWithFileName = "~/Asset/img/" + fileName + "_1.jpg";
                    hpf.SaveAs(Server.MapPath(fullPatchWithFileName));
                    sp.Hinh1 = sp.MaSanPham + "_1.jpg";
                }
                //2
                 hpf = HttpContext.Request.Files[2];
                if (hpf.ContentLength > 0)
                {
                    string fileName = sp.MaSanPham;
                    string fullPatchWithFileName = "~/Asset/img/" + fileName + "_2.jpg";
                    hpf.SaveAs(Server.MapPath(fullPatchWithFileName));
                    sp.Hinh2 = sp.MaSanPham + "_2.jpg";
                }
                //3
                 hpf = HttpContext.Request.Files[3];
                if (hpf.ContentLength > 0)
                {
                    string fileName = sp.MaSanPham;
                    string fullPatchWithFileName = "~/Asset/img/" + fileName + "_3.jpg";
                    hpf.SaveAs(Server.MapPath(fullPatchWithFileName));
                    sp.Hinh3 = sp.MaSanPham + "_3.jpg";
                }
                //4
                hpf = HttpContext.Request.Files[4];
                if (hpf.ContentLength > 0)
                {
                    string fileName = sp.MaSanPham;
                    string fullPatchWithFileName = "~/Asset/img/" + fileName + "_4.jpg";
                    hpf.SaveAs(Server.MapPath(fullPatchWithFileName));
                    sp.Hinh4 = sp.MaSanPham + "_4.jpg";
                }

                sp.TinhTrang = "0";
                sp.SoLuongDaBan = 0;
                sp.LuotView = 0;
                //--TODO: ADD INSERT LOGIC HERE
                ShopOnlineBUS.InsertSP(sp);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/SanPhamAdmin/Edit/5
        public ActionResult Edit(string id)
        {

            ViewBag.MaNhaSanXuat = new SelectList(NhaSanXuatBUS.DanhSach(), "MaNhaSanXuat", "TenNhaSanXuat", ShopOnlineBUS.ChiTiet(id).MaNhaSanXuat);
            ViewBag.MaLoaiSanPham = new SelectList(LoaiSanPhamBUS.DanhSach(), "MaLoaiSanPham", "TenLoaiSanPham",ShopOnlineBUS.ChiTiet(id).MaLoaiSanPham);

            return View(ShopOnlineBUS.ChiTiet(id));
        }

        // POST: Admin/SanPhamAdmin/Edit/5
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(String id, SanPham sp)
        
        {
            var tam = ShopOnlineBUS.ChiTiet(id);
            try
            {
                var hpf = HttpContext.Request.Files[0];
                if (hpf.ContentLength > 0)
                {
                    string fileName = sp.MaSanPham;
                    string fullPatchWithFileName = "~/Asset/img/" + fileName + ".jpg";
                    hpf.SaveAs(Server.MapPath(fullPatchWithFileName));
                    sp.HinhChinh = sp.MaSanPham + ".jpg";
                }
                else { sp.HinhChinh = tam.HinhChinh; }
                //1
                hpf = HttpContext.Request.Files[1];
                if (hpf.ContentLength > 0)
                {
                    string fileName = sp.MaSanPham;
                    string fullPatchWithFileName = "~/Asset/img/" + fileName + "_1.jpg";
                    hpf.SaveAs(Server.MapPath(fullPatchWithFileName));
                    sp.Hinh1 = sp.MaSanPham + "_1.jpg";
                }
                else { sp.Hinh1 = tam.Hinh1; }
                //2
                hpf = HttpContext.Request.Files[2];
                if (hpf.ContentLength > 0)
                {
                    string fileName = sp.MaSanPham;
                    string fullPatchWithFileName = "~/Asset/img/" + fileName + "_2.jpg";
                    hpf.SaveAs(Server.MapPath(fullPatchWithFileName));
                    sp.Hinh2 = sp.MaSanPham + "_2.jpg";
                }
                else { sp.Hinh2 = tam.Hinh2; }
                //3
                hpf = HttpContext.Request.Files[3];
                if (hpf.ContentLength > 0)
                {
                    string fileName = sp.MaSanPham;
                    string fullPatchWithFileName = "~/Asset/img/" + fileName + "_3.jpg";
                    hpf.SaveAs(Server.MapPath(fullPatchWithFileName));
                    sp.Hinh3 = sp.MaSanPham + "_3.jpg";
                }
                else { sp.Hinh3 = tam.Hinh3; }
                //4
                hpf = HttpContext.Request.Files[4];
                if (hpf.ContentLength > 0)
                {
                    string fileName = sp.MaSanPham;
                    string fullPatchWithFileName = "~/Asset/img/" + fileName + "_4.jpg";
                    hpf.SaveAs(Server.MapPath(fullPatchWithFileName));
                    sp.Hinh4 = sp.MaSanPham + "_4.jpg";
                }
                else { sp.Hinh4 = tam.Hinh4; }
                if (sp.SoLuongDaBan>10000)
                    {
                    sp.SoLuongDaBan = 0;
                }else { sp.SoLuongDaBan = tam.SoLuongDaBan; }
                if (sp.LuotView > 10000) { sp.LuotView = 0; } else { sp.LuotView = tam.LuotView; }
                sp.TinhTrang = tam.TinhTrang;
                ShopOnlineBUS.UpdateSP(id, sp);
               
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/SanPhamAdmin/Delete/5
        public ActionResult Delete(string id)
        {

            return View(ShopOnlineBUS.ChiTiet(id));
        }

        // POST: Admin/SanPhamAdmin/Delete/5
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Delete(string id, SanPham sp)
        {
            var tam = ShopOnlineBUS.ChiTiet(id);
            try
            {
                // TODO: Add delete logic here

               
                //
                if (tam.SoLuongDaBan > 10000)
                {
                    tam.SoLuongDaBan = 0;
                }
              
                if (tam.LuotView > 10000) { tam.LuotView = 0; }
                if(tam.TinhTrang == "1         ") { tam.TinhTrang = "0         "; }
                else 
                {
                    tam.TinhTrang = "1         ";
                }

                ShopOnlineBUS.UpdateSP(id, tam);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
