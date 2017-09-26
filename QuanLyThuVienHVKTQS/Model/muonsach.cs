namespace QuanLyThuVienHVKTQS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("muonsach")]
    public partial class muonsach
    {
        public long id { get; set; }

        public int masach { get; set; }

        [Required]
        [StringLength(250)]
        public string tennv { get; set; }

        public int sothe { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaymuon { get; set; }

        [Column(TypeName = "date")]
        public DateTime? hantra { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaytra { get; set; }

        public virtual docgia docgia { get; set; }

        public virtual sach sach { get; set; }

        public virtual nhanvien nhanvien { get; set; }
    }
}
