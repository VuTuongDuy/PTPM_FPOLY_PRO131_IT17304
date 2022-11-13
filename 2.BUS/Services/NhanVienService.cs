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
    public class NhanVienService : INhanVienService
    {
        private INhanVienRepository _iNhanVienRepository;
        private IChucVuRepository _ichucVuRepository;
        private IHoaDonRepository _hoaDonRepository;
        
        public NhanVienService()
        {
            _iNhanVienRepository = new NhanVienRepository();
            _ichucVuRepository = new ChucVuRepository();
            
            
        }

        public string Add(ViewNhanVien obj)
        {

            var nv = new NhanVien()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TenDem = obj.TenDem,
                Ho = obj.Ho,
                GioiTinh = obj.GioiTinh,
                NgaySinh = obj.NgaySinh,
                DiaChi = obj.DiaChi,
                Sdt = obj.Sdt,
                MatKhau = obj.MatKhau,
                IdChucVu= obj.IdChucVu,
                TrangThai = obj.TrangThai,
            };
            _iNhanVienRepository.Add(nv);
            return "Thành công";
        }

        public string Delete(ViewNhanVien obj)
        {
            var vnv = new NhanVien()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TenDem = obj.TenDem,
                Ho = obj.Ho,
                GioiTinh = obj.GioiTinh,
                NgaySinh = obj.NgaySinh,
                DiaChi = obj.DiaChi,
                Sdt = obj.Sdt,
                MatKhau = obj.MatKhau,
                IdChucVu = obj.IdChucVu,
                TrangThai = obj.TrangThai,

            };
            _iNhanVienRepository.Delete(vnv);
            return "Thành công";
        }

        public List<ViewNhanVien> GetAll()
        {
            List<ViewNhanVien> _lstNhanVien = new List<ViewNhanVien>();
            _lstNhanVien = (from nv in _iNhanVienRepository.GetAll()
                            join cv in _ichucVuRepository.GetAll() on nv.IdChucVu equals cv.Id
                            select new ViewNhanVien
                            {
                                Id = nv.Id,
                                Ma = nv.Ma,
                                Ten = nv.Ten,
                                TenDem = nv.TenDem,
                                Ho = nv.Ho,
                                GioiTinh = nv.GioiTinh,
                                NgaySinh = nv.NgaySinh,
                                DiaChi = nv.DiaChi,
                                Sdt = nv.Sdt,
                                MatKhau = nv.MatKhau,

                                TrangThai = nv.TrangThai,

                            }).ToList();
            return _lstNhanVien;
        }

        public string Update(ViewNhanVien obj)
        {
            throw new NotImplementedException();
        }
    }
   
}
