namespace QuanLyThuVienHVKTQS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sach")]
    public partial class sach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sach()
        {
            muonsaches = new HashSet<muonsach>();
        }

        [Key]
        public int masach { get; set; }

        [StringLength(150)]
        public string tensach { get; set; }

        [StringLength(150)]
        public string tentacgia { get; set; }

        public int? manxb { get; set; }

        public decimal? giatien { get; set; }

        public int? soluong { get; set; }

        [StringLength(50)]
        public string ngonngu { get; set; }

        public int? namxb { get; set; }

        public int? solanxb { get; set; }

        [StringLength(50)]
        public string theloai { get; set; }

        [StringLength(50)]
        public string loai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<muonsach> muonsaches { get; set; }

        public virtual nhaxuatban nhaxuatban { get; set; }
    }
}
