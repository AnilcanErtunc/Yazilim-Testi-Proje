namespace Yaızlım_Test_Projesi.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TBLOGRETMEN")]
    public partial class TBLOGRETMan
    {
        [Key]
        public int OgretmenID { get; set; }

        [Required]
        [StringLength(50)]
        public string OgretmenAdiSoyadi { get; set; }

        [Column("e-posta")]
        [Required]
        [StringLength(100)]
        public string e_posta { get; set; }

        [Required]
        [StringLength(50)]
        public string sifre { get; set; }
    }
}
