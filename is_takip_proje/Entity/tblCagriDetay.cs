//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace is_takip_proje.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCagriDetay
    {
        public int ID { get; set; }
        public Nullable<int> Cagri { get; set; }
        public string Aciklama { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public string saat { get; set; }
    
        public virtual tblCagrilar tblCagrilar { get; set; }
    }
}
