using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmHoadon : Form
    {
        private IHoaDonRepository _iHoadonrepo;
        private ISanPhamRepository _anPhamrepo;
        private IKhachHangRepository khachHangRepository;
        private INhanVienRepository nhanVienRepository;
        private List<ViewHoaDon> _viewHoaDon;
        public FrmHoadon()
        {
            InitializeComponent();
            nhanVienRepository = new NhanVienRepository();
            khachHangRepository = new KhachHangRepository();
            _iHoadonrepo = new HoaDonRepository();
            _viewHoaDon = new List<ViewHoaDon>();
            Loaddata();
        }
        public void Loaddata()
        {
            dgrid_view.ColumnCount = 14;
            dgrid_view.Columns[0].Name = "id";
            dgrid_view.Columns[0].Visible= false;
            dgrid_view.Columns[1].Name = "Ma ";
            dgrid_view.Columns[2].Name = "Khách Hàng";
            dgrid_view.Columns[3].Name = "Sản Phẩm";
            dgrid_view.Columns[4].Name = "Nhân Viên";
            dgrid_view.Columns[5].Name = "Tên Sản Phẩm";
            dgrid_view.Columns[6].Name = "Tên Người Nhận";
            dgrid_view.Columns[7].Name = "Ngày Tạo";
            dgrid_view.Columns[8].Name = "Ngày Giao";
            dgrid_view.Columns[9].Name = "Ngày Thanh Toán";
            dgrid_view.Columns[10].Name = "Dịa Chỉ";
            dgrid_view.Columns[11].Name = "Sdt";
            dgrid_view.Columns[12].Name = "Giảm GIá";
            dgrid_view.Columns[13].Name = "Trạng Thái";
            dgrid_view.Rows.Clear();
            foreach (var x in _viewHoaDon.OrderBy(c=>c.Ma).ToList())
            {
                dgrid_view.Rows.Add(x.Id,x.Ma,x.khachhang,x.sanpham, x.nhanvien,x.TenSp, x.TenNguoiNhan, x.NgayTao,x.NgayGiao,x.NgayThanhToan,x.DiaChi,x.Sdt,x.GiamGia,x.TrangThai);
            };

        }
    }
}
