namespace Yaızlım_Test_Projesi.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TBLKONU")]
    public partial class TBLKONU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLKONU()
        {
            SınavGeçmişiTBL = new HashSet<SınavGeçmişiTBL>();
            TBLSORUs = new HashSet<TBLSORU>();
        }

        [Key]
        public int KonuID { get; set; }

        [Required]
        [StringLength(50)]
        public string Adı { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SınavGeçmişiTBL> SınavGeçmişiTBL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSORU> TBLSORUs { get; set; }
    }
}
