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
    
    public partial class account
    {
        public string userNanme { get; set; }
        public Nullable<int> idnv { get; set; }
        public Nullable<int> isAdmin { get; set; }
        public string password { get; set; }
    
        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
