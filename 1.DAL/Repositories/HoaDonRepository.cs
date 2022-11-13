﻿using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    internal class HoaDonRepository : IHoaDonRepository
    {
        private FpolyDBContext _dbContext;
        public HoaDonRepository()
        {
         _dbContext = new FpolyDBContext();
        }
        public bool Add(HoaDon obj)
        {
            if (obj == null) return false;
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(HoaDon obj)
        {
           if(obj == null) return false;
            var temp = _dbContext.HoaDons.FirstOrDefault(c => c.Id == obj.Id);
            _dbContext.Remove(temp);
            _dbContext.SaveChanges();
            return true;
        }

        public List<HoaDon> GetAll()
        {
            return _dbContext.HoaDons.ToList();
        }

        public HoaDon GetAllById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.HoaDons.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(HoaDon obj)
        {
            if (obj == null) return false;
            var temp = _dbContext.HoaDons.FirstOrDefault(c => c.Id == obj.Id);
            temp.Ma = obj.Ma;
            temp.TenSp = obj.TenSp;
            temp.NgayGiao = obj.NgayGiao;
            temp.NgayTao = obj.NgayTao;
            temp.NgayThanhToan = obj.NgayThanhToan;
            temp.TenNguoiNhan = obj.TenNguoiNhan;
            temp.DiaChi = obj.DiaChi;
            temp.Sdt = obj.Sdt;
            temp.GiamGia = obj.GiamGia;
            temp.TrangThai = obj.TrangThai;
            temp.IdKhachHang = obj.IdKhachHang;
            temp.IdNhanVien = obj.IdNhanVien;
            temp.IdSanOham = obj.IdSanOham;
            _dbContext.HoaDons.Update(temp);
            _dbContext.SaveChanges();
            return true;
        }
    }
}