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
    public class HoaDonService : IHoaDonService
    {
        private IHoaDonRepository _iHoaDonRepository;
        private INhanVienRepository _INhanVienRepository;
        private ISanPhamRepository _ISanPhamRepository;
        private IKhachHangRepository _ikhachHangRepository;
        private List<HoaDon> _lstHoadon;
        private List<ViewHoaDon> _viewHoaDons;
        public HoaDonService()
        {
            _iHoaDonRepository = new HoaDonRepository();
            _ISanPhamRepository = new SanPhamRepository();
            _INhanVienRepository = new NhanVienRepository();
            _ikhachHangRepository = new KhachHangRepository();
            _lstHoadon = new List<HoaDon>();


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
            _iHoaDonRepository.Add(HoaDon);
            return "thành công";
        }

        public string Delete(ViewHoaDon obj)
        {
            var temp = _iHoaDonRepository.GetAll().FirstOrDefault(c => c.Id == id);
            _iHoaDonRepository.Delete(temp);
            return "thành công";
        }

<<<<<<< HEAD
       
        public List<HoaDon> GetAllChucVu()
        {
            return _hoaDonService.GetAll();
=======
        public List<ViewHoaDon> GetAll()
        {
            _viewHoaDons = (from hd in _iHoaDonRepository.GetAll()
                            join kh in _ikhachHangRepository.GetAll() on hd.IdKhachHang equals kh.Id
                            join nv in _INhanVienRepository.GetAll() on hd.IdNhanVien equals nv.Id
                            join sp in _ISanPhamRepository.GetAllSanPham() on hd.IdSanOham equals sp.Id
                            select new ViewHoaDon
                            {
                               
                               Id = hd.Id,
                               khachhang = kh.Ten,
                               sanpham = sp.Ten,
                               nhanvien = nv.Ten,
                               Ma = hd.Ma,
                               TenSp = hd.TenSp,
                               NgayGiao = hd.NgayTao,
                               NgayThanhToan = hd.NgayThanhToan,
                               NgayTao = hd.NgayTao,
                               TenNguoiNhan = hd.TenNguoiNhan,
                               DiaChi = hd.DiaChi,
                               Sdt = hd.Sdt,
                               GiamGia =hd.GiamGia,
                               TrangThai = hd.TrangThai


                            }).ToList();
            return _viewHoaDons;
>>>>>>> 7717df2b40c51f1d2545b12f66d24651841b3b69
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
            _iHoaDonRepository.Update(HoaDon);
            return "thành công";
        }
    }
}
