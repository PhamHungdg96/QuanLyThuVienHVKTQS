namespace QuanLyThuVienHVKTQS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("docgia")]
    public partial class docgia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public docgia()
        {
            muonsaches = new HashSet<muonsach>();
        }

        [Key]
        public int sothe { get; set; }

        [StringLength(50)]
        public string hoten { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaysinh { get; set; }

        [StringLength(10)]
        public string gioitinh { get; set; }

        [StringLength(50)]
        public string diachi { get; set; }

        [StringLength(50)]
        public string socmtnd { get; set; }

        [StringLength(50)]
        public string anhthe { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaylamthe { get; set; }

        [Column(TypeName = "date")]
        public DateTime? handungthe { get; set; }

        [StringLength(250)]
        public string note { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<muonsach> muonsaches { get; set; }
    }
}
