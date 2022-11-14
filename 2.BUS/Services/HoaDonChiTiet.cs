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
    public class HoaDonChiTiet : IHoaDonChiTietService
    {
        private IHoaDonChiTietRipositry _IHoaDonChiTietRp;
        private IChiTietGiayRepository _IChiTietGiayRp;
        private IChiTietKhuyenMaiRepository _IChiTietKhuyenMaiRp;
        private IHoaDonRepository _IHoaDonRp;

        public HoaDonChiTiet()
        {
            _IHoaDonChiTietRp = new HoaDonChiTietRepository();
            _IChiTietGiayRp = new ChiTietGiayRepository();
            _IChiTietKhuyenMaiRp = new ChiTietKhuyenMaiReposity();
            _IHoaDonRp = new HoaDonRepository();
        }
        public string Add(ViewHoaDonChiTiet obj)
        {
            if (obj == null)
            {
                return "Không thành công";
            }
            var HDCT = obj.HoaDonChiTiet;
            if (_IHoaDonChiTietRp.Add(HDCT)) return "Thêm thành công";
            return "không thành công";
        }

        public string Delete(ViewHoaDonChiTiet obj)
        {
            if (obj == null)
            {
                return "Không thành công";
            }
            var HDCT = obj.HoaDonChiTiet;
            if (_IHoaDonChiTietRp.Delete(HDCT)) return "Xóa thành công";
            return "không thành công";
        }

        public List<ViewHoaDonChiTiet> GetAll()
        {
            List<ViewHoaDonChiTiet> lstHDCT = new List<ViewHoaDonChiTiet>();
            lstHDCT = (from a in _IHoaDonChiTietRp.GetAll()
                       join b in _IChiTietGiayRp.GetAllChiTietGiay() on a.IdChiTietGiay equals b.Id
                       join c in _IChiTietKhuyenMaiRp.GetAll() on a.IdKhuyenMai equals c.Id
                       join d in _IHoaDonRp.GetAll() on a.IdHoaDon equals d.Id
                       select new ViewHoaDonChiTiet
                       {
                           HoaDonChiTiet = a,ChiTietGiay= b,ChiTietKhuyenMai=c,HoaDon=d
                           
                       }).ToList();
            return lstHDCT;
        }

        public string Update(ViewHoaDonChiTiet obj)
        {
            if (obj == null)
            {
                return "Không thành công";
            }
            var HDCT = obj.HoaDonChiTiet;
            if (_IHoaDonChiTietRp.Update(HDCT)) return "Sửa thành công";
            return "không thành công";
        }
    }
}
