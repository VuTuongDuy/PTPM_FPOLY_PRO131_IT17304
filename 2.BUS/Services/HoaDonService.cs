﻿using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using Microsoft.EntityFrameworkCore.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    internal class HoaDonService : IHoaDonService
    {
        private IHoaDonRepository _hoaDonService;
        private INhanVienRepository _INhanVienRepository;
        private ISanPhamRepository _ISanPhamRepository;
        private IKhachHangRepository _ikhachHangRepository;
        
        public HoaDonService()
        {
            _ISanPhamRepository = new SanPhamRepository();
            _INhanVienRepository = new NhanVienRepository();
            _ikhachHangRepository = new KhachHangRepository();
            
        }

        public string Add(HoaDon obj)
        {
            var HoaDon = new HoaDon()
            {
                Id = obj.Id,
                IdKhachHang = obj.IdKhachHang,
                IdNhanVien = obj.IdNhanVien,
                IdSanOham = obj.IdSanOham,
                Ma = obj.Ma,
                TenSp = obj.TenSp,
                NgayTao = obj.NgayTao,
                NgayThanhToan = obj.NgayThanhToan,
                NgayGiao = obj.NgayGiao,
                TenNguoiNhan = obj.TenNguoiNhan,
                DiaChi = obj.DiaChi,
                Sdt = obj.Sdt,
                GiamGia = obj.GiamGia,
                TrangThai = obj.TrangThai,

            };
            _hoaDonService.Add(HoaDon);
            return "thành công";
        }

        public string Delete(HoaDon obj)
        {
            var HoaDon = new HoaDon()
            {
                Id = obj.Id,
                IdKhachHang = obj.IdKhachHang,
                IdNhanVien = obj.IdNhanVien,
                IdSanOham = obj.IdSanOham,
                Ma = obj.Ma,
                TenSp = obj.TenSp,
                NgayTao = obj.NgayTao,
                NgayThanhToan = obj.NgayThanhToan,
                NgayGiao = obj.NgayGiao,
                TenNguoiNhan = obj.TenNguoiNhan,
                DiaChi = obj.DiaChi,
                Sdt = obj.Sdt,
                GiamGia = obj.GiamGia,
                TrangThai = obj.TrangThai,

            };
           
            return "thành công";
        }

       
        public List<HoaDon> GetAllChucVu()
        {
            return _hoaDonService.GetAll();
        }

        public ChucVu GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(HoaDon obj)
        {
            var HoaDon = new HoaDon()
            {
                Id = obj.Id,
                IdKhachHang = obj.IdKhachHang,
                IdNhanVien = obj.IdNhanVien,
                IdSanOham = obj.IdSanOham,
                Ma = obj.Ma,
                TenSp = obj.TenSp,
                NgayTao = obj.NgayTao,
                NgayThanhToan = obj.NgayThanhToan,
                NgayGiao = obj.NgayGiao,
                TenNguoiNhan = obj.TenNguoiNhan,
                DiaChi = obj.DiaChi,
                Sdt = obj.Sdt,
                GiamGia = obj.GiamGia,
                TrangThai = obj.TrangThai,

            };
            
            return "thành công";
        }
    }
}
