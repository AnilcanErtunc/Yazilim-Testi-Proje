namespace Yaızlım_Test_Projesi.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TBLSORU")]
    public partial class TBLSORU
    {
        [Key]
        public int SoruID { get; set; }

        [Required]
        public string Soru { get; set; }

        [Required]
        [StringLength(50)]
        public string A { get; set; }

        [Required]
        [StringLength(50)]
        public string B { get; set; }

        [Required]
        [StringLength(50)]
        public string C { get; set; }

        [Required]
        [StringLength(50)]
        public string D { get; set; }

        public int KonuID { get; set; }

        [Required]
        [StringLength(50)]
        public string DogruCevap { get; set; }

        public virtual TBLKONU TBLKONU { get; set; }
    }
}
