namespace QuanLyThuVienHVKTQS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("nhanvien")]
    public partial class nhanvien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nhanvien()
        {
            muonsaches = new HashSet<muonsach>();
        }

        [Key]
        [StringLength(250)]
        public string tendangnhap { get; set; }

        [StringLength(50)]
        public string tennv { get; set; }

        [StringLength(50)]
        public string sdt { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaysinh { get; set; }

        [StringLength(10)]
        public string gioitinh { get; set; }

        [StringLength(50)]
        public string diachi { get; set; }

        [StringLength(50)]
        public string socmtnd { get; set; }

        [StringLength(50)]
        public string anh { get; set; }

        [StringLength(50)]
        public string quyenhan { get; set; }

        [StringLength(50)]
        public string matkhau { get; set; }

        [StringLength(250)]
        public string note { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<muonsach> muonsaches { get; set; }
    }
}
