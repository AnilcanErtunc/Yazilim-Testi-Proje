//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoruApp.Entitiy
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Ogrenci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Ogrenci()
        {
            this.tbl_Sınav = new HashSet<tbl_Sınav>();
        }
    
        public int ogrenci_ıd { get; set; }
    
        public virtual tbl_Kullanıcı tbl_Kullanıcı { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Sınav> tbl_Sınav { get; set; }
    }
}
