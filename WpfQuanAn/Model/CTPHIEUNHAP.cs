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
    
    public partial class CTPHIEUNHAP
    {
        public int idpn { get; set; }
        public int idnl { get; set; }
        public Nullable<int> slnhap { get; set; }
    
        public virtual NGUYENLIEU NGUYENLIEU { get; set; }
        public virtual PHIEUNHAP PHIEUNHAP { get; set; }
    }
}