using _2.BUS.IServices;
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
    public partial class FrmBanHang : Form
    {
        private ISanPhamService _iSanPham;
        private IHoaDonService _iHoaDonService;
        private IChiTietGiayService _iChiTietGiayServices;
        private IMauSacService _iMauSac;
        private INhaSanXuatService _iNSX;
        List<ViewChiTietGiay> listChiTietGiay;
        public FrmBanHang()
        {
            InitializeComponent();
            _iSanPham = new SanPhamService();
            _iHoaDonService = new HoaDonService();
            _iChiTietGiayServices = new ChiTietGiayService();
            _iMauSac = new MauSacService();
            _iNSX = new NhaSanXuatService();
            loadSanPham();
        }
        private void loadSanPham()
        {
            dgrid_DsSanPham.Rows.Clear();
            dgrid_DsSanPham.ColumnCount = 11;
            dgrid_DsSanPham.Columns[0].Name = "Id";
            dgrid_DsSanPham.Columns[0].Visible = false;
            dgrid_DsSanPham.Columns[1].Name = "Mã";
            dgrid_DsSanPham.Columns[2].Name = "Tên";
            dgrid_DsSanPham.Columns[3].Name = "Số Lượng tồn";
            dgrid_DsSanPham.Columns[4].Name = "Đơn giá";
            dgrid_DsSanPham.Columns[5].Name = "Màu Sắc";
            dgrid_DsSanPham.Columns[6].Name = "NSX";
            dgrid_DsSanPham.Columns[7].Name = "Chất liệu";
            dgrid_DsSanPham.Columns[8].Name = "Kiểu dáng";
            dgrid_DsSanPham.Columns[9].Name = "Đế giày";
            dgrid_DsSanPham.Columns[10].Name = "Trạng thái";
            listChiTietGiay = _iChiTietGiayServices.GetViewChiTietGiay();
            listChiTietGiay = listChiTietGiay.OrderBy(p => p.Ma).ToList();
            foreach (var item in listChiTietGiay )
            {
                dgrid_DsSanPham.Rows.Add(item.Id, item.Ma, item.TenSanPham, item.SoLuongTon, item.GiaBan, item.TenMauSac, item.TenNSX, item.TenChatLieu, item.TenKieuDang, item.TenDeGiay, item.TrangThai==1? "Còn hàng": "Hết hàng");
            }
        }

    }
}