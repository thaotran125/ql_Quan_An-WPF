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
    
    public partial class FOOD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FOOD()
        {
            this.CTBILLs = new HashSet<CTBILL>();
        }
    
        public int idfood { get; set; }
        public int idloaifood { get; set; }
        public string tenfood { get; set; }
        public string size { get; set; }
        public Nullable<decimal> gia { get; set; }
        public string DVT { get; set; }
        public Nullable<int> idkm { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTBILL> CTBILLs { get; set; }
        public virtual KHUYENMAI KHUYENMAI { get; set; }
        public virtual LOAIFOOD LOAIFOOD { get; set; }
    }
}
