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
    
    public partial class tbl_Ogretmen
    {
        public int ogretmen_ıd { get; set; }
    
        public virtual tbl_Kullanıcı tbl_Kullanıcı { get; set; }
    }
}
