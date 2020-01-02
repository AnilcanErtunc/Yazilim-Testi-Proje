namespace Yaızlım_Test_Projesi.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBLOGRENCİ
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLOGRENCİ()
        {
            TBLSINAVs = new HashSet<TBLSINAV>();
        }

        [Key]
        public int OgrenciID { get; set; }

        [Required]
        [StringLength(50)]
        public string OgrenciAdiSoyadi { get; set; }

        [Required]
        [StringLength(100)]
        public string e_posta { get; set; }

        [Required]
        [StringLength(50)]
        public string sifre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSINAV> TBLSINAVs { get; set; }
    }
}
