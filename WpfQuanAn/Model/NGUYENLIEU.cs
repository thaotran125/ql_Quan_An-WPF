//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfQuanAn.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class NGUYENLIEU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NGUYENLIEU()
        {
            this.CTPHIEUNHAPs = new HashSet<CTPHIEUNHAP>();
        }
    
        public int idnl { get; set; }
        public int idloainl { get; set; }
        public int idnhacc { get; set; }
        public string ten { get; set; }
        public string DVT { get; set; }
        public Nullable<decimal> gia { get; set; }
        public Nullable<int> slton { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPHIEUNHAP> CTPHIEUNHAPs { get; set; }
        public virtual LOAINL LOAINL { get; set; }
        public virtual NHACUNGCAP NHACUNGCAP { get; set; }
    }
}
