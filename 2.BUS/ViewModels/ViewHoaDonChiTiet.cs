using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ViewHoaDonChiTiet
    {
        public Guid Id { get; set; }

        public Guid? IdChiTietGiay { get; set; }

        public Guid? IdHoaDon { get; set; }

        public Guid? IdTichDiem { get; set; }

        public Guid? IdKhuyenMai { get; set; }
        public Guid? IdCongThuc { get; set; }
        public int? SoLuong { get; set; }

        public string DonGia { get; set; }

        public string ThanhTien { get; set; }
        public int? TrangThai { get; set; }
    }
}
