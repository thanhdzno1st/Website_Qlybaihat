namespace OnlineShop.Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [Key]
        [StringLength(10)]
        public string MaThanhVien { get; set; }

        [StringLength(100)]
        public string HoVaTen { get; set; }

        [StringLength(15)]
        public string SoDienThoai { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(255)]
        public string MatKhau { get; set; }

        public bool? GoiThanhVien { get; set; }

        public DateTime? NgayDangKy { get; set; }
    }
}
