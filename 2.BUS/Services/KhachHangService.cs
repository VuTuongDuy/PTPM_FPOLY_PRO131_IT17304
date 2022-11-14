using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class KhachHangService : IKhachHangService
    {
        private IKhachHangRepository _ikhachHangRepository;
        public KhachHangService()
        {
            //_ikhachHangRepository = new KhachHangRepository();
        }
        public bool Add(ViewKhachHang obj)
        {
            var kh = new KhachHang()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TenDem = obj.TenDem,
                Ho = obj.Ho,
                NgaySinh = obj.NgaySinh,
                Sdt = obj.Sdt,
                DiaChi = obj.DiaChi,
                QuocGia = obj.QuocGia,
                TrangThai = obj.TrangThai,

            };
            _ikhachHangRepository.Add(kh);
            return true;
        }
        public bool Delete(ViewKhachHang obj)
        {
            var kh = new KhachHang()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TenDem = obj.TenDem,
                Ho = obj.Ho,
                NgaySinh = obj.NgaySinh,
                Sdt = obj.Sdt,
                DiaChi = obj.DiaChi,
                QuocGia = obj.QuocGia,
                TrangThai = obj.TrangThai,

            };
            return _ikhachHangRepository.Delete(kh);
            return true;

        }
        public List<ViewKhachHang> GetAll()
        {
            List<ViewKhachHang> _lstKhachHang = new List<ViewKhachHang>();
            _lstKhachHang = (
                from a in _ikhachHangRepository.GetAll()
                select new ViewKhachHang()
                {
                    Id = a.Id,
                    Ma = a.Ma,
                    Ten = a.Ten,
                    TenDem = a.TenDem,
                    Ho = a.Ho,
                    NgaySinh = a.NgaySinh,
                    Sdt = a.Sdt,
                    DiaChi = a.DiaChi,
                    QuocGia = a.QuocGia,
                    TrangThai= a.TrangThai,
                }).ToList();
            return _lstKhachHang;
        }
        public bool Update(ViewKhachHang obj)
        {
            var kh = new KhachHang()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TenDem = obj.TenDem,
                Ho = obj.Ho,
                NgaySinh = obj.NgaySinh,
                Sdt = obj.Sdt,
                DiaChi = obj.DiaChi,
                QuocGia = obj.QuocGia,
                TrangThai = obj.TrangThai,
            };
            _ikhachHangRepository.Update(kh);
            return true;
        }
    }
}
