﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("KieuDang")]
    public partial class KieuDang
    {
        public KieuDang()
        {
            ChiTietGiays = new HashSet<ChiTietGiay>();
        }

        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [StringLength(10)]
        public string Ma { get; set; }
        [StringLength(50)]
        public string Ten { get; set; }
        public int? TrangThai { get; set; }

        [InverseProperty(nameof(ChiTietGiay.IdKieuDangNavigation))]
        public virtual ICollection<ChiTietGiay> ChiTietGiays { get; set; }
    }
}
