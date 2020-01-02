namespace Yaızlım_Test_Projesi.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SınavGeçmişiTBL
    {
        [Key]
        public int SinavGecmisID { get; set; }

        public int SınavID { get; set; }

        public int KonuID { get; set; }

        public int YanlisSayisi { get; set; }

        public virtual TBLKONU TBLKONU { get; set; }

        public virtual TBLSINAV TBLSINAV { get; set; }
    }
}
