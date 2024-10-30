namespace OnlineShop.Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaiHat")]
    public partial class BaiHat
    {
        [Key]
        [StringLength(10)]
        public string maBaiHat { get; set; }

        [StringLength(50)]
        public string tenBaiHat { get; set; }

        [StringLength(50)]
        public string ngheSi { get; set; }

        [StringLength(50)]
        public string theLoai { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngayPhatHanh { get; set; }

        [StringLength(50)]
        public string lienketAmThanh { get; set; }

        [StringLength(50)]
        public string anhBaiHat { get; set; }

        [StringLength(50)]
        public string loiBaiHat { get; set; }
    }
}
