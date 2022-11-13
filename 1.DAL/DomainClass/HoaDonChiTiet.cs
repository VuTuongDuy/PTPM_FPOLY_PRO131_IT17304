using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("HoaDonChiTiet")]
    public partial class HoaDonChiTiet
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [Column("idChiTietGiay")]
        public Guid? IdChiTietGiay { get; set; }
        [Column("idHoaDon")]
        public Guid? IdHoaDon { get; set; }
        [Column("idTichDIem")]
        public Guid? IdTichDiem { get; set; }
        [Column("idKhuyenMai")]
        public Guid? IdKhuyenMai { get; set; }
        public Guid? IdCongThuc { get; set; }
        public int? SoLuong { get; set; }
        [StringLength(50)]
        public string DonGia { get; set; }
        [StringLength(50)]
        public string ThanhTien { get; set; }
        public int? TrangThai { get; set; }

        [ForeignKey(nameof(IdChiTietGiay))]
        [InverseProperty(nameof(ChiTietGiay.HoaDonChiTiets))]
        public virtual ChiTietGiay IdChiTietGiayNavigation { get; set; }
        [ForeignKey(nameof(IdHoaDon))]
        [InverseProperty(nameof(HoaDon.HoaDonChiTiets))]
        public virtual HoaDon IdHoaDonNavigation { get; set; }
        [ForeignKey(nameof(IdKhuyenMai))]
        [InverseProperty(nameof(ChiTietKhuyenMai.HoaDonChiTiets))]
        public virtual ChiTietKhuyenMai IdKhuyenMaiNavigation { get; set; }
    }
}
