using _1.DAL.DomainClass;
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
            _viewHoaDons = new List<ViewHoaDon>();
        }

        public string Add(ViewHoaDon obj)
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

        public string Delete(Guid obj)
        {
            var temp = _iHoaDonRepository.GetAll().FirstOrDefault(c => c.Id == obj);
            _iHoaDonRepository.Delete(temp);
            return "thành công";
        }

        public List<HoaDon> GetallHoadon()
        {
            return _iHoaDonRepository.GetAll();
        }
        public List<ViewHoaDon> GetAll()
        {
            List<ViewHoaDon> _viewHoaDons = new List<ViewHoaDon>();
            _viewHoaDons = (from hd in _iHoaDonRepository.GetAll()
                            join kh in _ikhachHangRepository.GetAll() on hd.IdKhachHang equals kh.Id
                            join nv in _INhanVienRepository.GetAllNhanVien() on hd.IdNhanVien equals nv.Id
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

        }

        public ChucVu GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(ViewHoaDon obj)
        {
            var x = _iHoaDonRepository.GetAll().FirstOrDefault(p => p.Id == obj.Id);
            x.IdKhachHang = obj.IdKhachHang;
            x.IdNhanVien = obj.IdNhanVien;
            x.IdSanOham = obj.IdSanOham;
            x.Ma = obj.Ma;
            x.TenSp = obj.TenSp;
            x.NgayTao = obj.NgayTao;
            x.NgayThanhToan = obj.NgayThanhToan;
            x.NgayGiao = obj.NgayGiao;
            x.TenNguoiNhan = obj.TenNguoiNhan;
            x.DiaChi = obj.DiaChi;
            x.Sdt = obj.Sdt;
            x.GiamGia = obj.GiamGia;
            x.TrangThai = obj.TrangThai;

            
            _iHoaDonRepository.Update(x);
            return "thành công";
        }
    }
}
