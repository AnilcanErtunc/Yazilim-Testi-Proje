namespace Yaızlım_Test_Projesi.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TBLSINAV")]
    public partial class TBLSINAV
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLSINAV()
        {
            SınavGeçmişiTBL = new HashSet<SınavGeçmişiTBL>();
        }

        [Key]
        public int SınavID { get; set; }

        public int ToplamYanlış { get; set; }

        public int ToplamDoğru { get; set; }

        public int OgrenciID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SınavGeçmişiTBL> SınavGeçmişiTBL { get; set; }

        public virtual TBLOGRENCİ TBLOGRENCİ { get; set; }
    }
}
