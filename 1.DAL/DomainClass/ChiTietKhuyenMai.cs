using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("ChiTietKhuyenMai")]
    public partial class ChiTietKhuyenMai
    {
        public ChiTietKhuyenMai()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [Column("idKhuyenMai")]
        public Guid? IdKhuyenMai { get; set; }
        [Column("idHoaDonChiTiet")]
        public Guid? IdHoaDonChiTiet { get; set; }
        public int? TrangThai { get; set; }

        [ForeignKey(nameof(IdKhuyenMai))]
        [InverseProperty(nameof(KhuyenMai.ChiTietKhuyenMais))]
        public virtual KhuyenMai IdKhuyenMaiNavigation { get; set; }
        [InverseProperty(nameof(HoaDonChiTiet.IdKhuyenMaiNavigation))]
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
