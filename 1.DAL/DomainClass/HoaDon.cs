﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("HoaDon")]
    public partial class HoaDon
    {
        public HoaDon()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [Column("idKhachHang")]
        public Guid? IdKhachHang { get; set; }
        [Column("idSanOham")]
        public Guid? IdSanOham { get; set; }
        [Column("idNhanVien")]
        public Guid? IdNhanVien { get; set; }
        [StringLength(10)]
        public string Ma { get; set; }
        [Column("TenSP")]
        [StringLength(50)]
        public string TenSp { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayTao { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayThanhToan { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayGiao { get; set; }
        [StringLength(50)]
        public string TenNguoiNhan { get; set; }
        [StringLength(100)]
        public string DiaChi { get; set; }
        [Column("SDT")]
        [StringLength(50)]
        public string Sdt { get; set; }
        [StringLength(10)]
        public string GiamGia { get; set; }
        public int? TrangThai { get; set; }

        [ForeignKey(nameof(IdKhachHang))]
        [InverseProperty(nameof(KhachHang.HoaDons))]
        public virtual KhachHang IdKhachHangNavigation { get; set; }
        [ForeignKey(nameof(IdNhanVien))]
        [InverseProperty(nameof(NhanVien.HoaDons))]
        public virtual NhanVien IdNhanVienNavigation { get; set; }
        [InverseProperty(nameof(HoaDonChiTiet.IdHoaDonNavigation))]
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
