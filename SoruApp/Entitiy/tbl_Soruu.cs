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
    
    public partial class tbl_Soruu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Soruu()
        {
            this.tbl_Konu = new HashSet<tbl_Konu>();
        }
    
        public int soru_ıd { get; set; }
        public string soru_text { get; set; }
        public string sık_1 { get; set; }
        public string sık_2 { get; set; }
        public string sık_3 { get; set; }
        public string sık_dogru { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Konu> tbl_Konu { get; set; }
    }
}
