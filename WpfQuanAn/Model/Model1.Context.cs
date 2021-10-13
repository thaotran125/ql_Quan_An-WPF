﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QLQUAN_ANEntities : DbContext
    {
        public QLQUAN_ANEntities()
            : base("name=QLQUAN_ANEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<account> accounts { get; set; }
        public virtual DbSet<BANAN> BANANs { get; set; }
        public virtual DbSet<BILL> BILLs { get; set; }
        public virtual DbSet<CTBILL> CTBILLs { get; set; }
        public virtual DbSet<CTPHIEUNHAP> CTPHIEUNHAPs { get; set; }
        public virtual DbSet<FOOD> FOODs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<KHUYENMAI> KHUYENMAIs { get; set; }
        public virtual DbSet<LOAIFOOD> LOAIFOODs { get; set; }
        public virtual DbSet<LOAINL> LOAINLs { get; set; }
        public virtual DbSet<NGUYENLIEU> NGUYENLIEUx { get; set; }
        public virtual DbSet<NHACUNGCAP> NHACUNGCAPs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHIEUNHAP> PHIEUNHAPs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    
        public virtual ObjectResult<getNVCreateAcc_Result> getNVCreateAcc()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getNVCreateAcc_Result>("getNVCreateAcc");
        }
    
        public virtual ObjectResult<loaddvt_Result> loaddvt()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<loaddvt_Result>("loaddvt");
        }
    
        public virtual ObjectResult<loadDvtfood_Result> loadDvtfood()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<loadDvtfood_Result>("loadDvtfood");
        }
    
        public virtual ObjectResult<loadSizi_Result> loadSizi()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<loadSizi_Result>("loadSizi");
        }
    
        public virtual ObjectResult<prDoanhThu_Result> prDoanhThu(Nullable<int> thang)
        {
            var thangParameter = thang.HasValue ?
                new ObjectParameter("thang", thang) :
                new ObjectParameter("thang", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<prDoanhThu_Result>("prDoanhThu", thangParameter);
        }
    
        public virtual ObjectResult<prDoanhThuThang_Result> prDoanhThuThang(Nullable<int> thang)
        {
            var thangParameter = thang.HasValue ?
                new ObjectParameter("thang", thang) :
                new ObjectParameter("thang", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<prDoanhThuThang_Result>("prDoanhThuThang", thangParameter);
        }
    
        public virtual ObjectResult<RPTinhTien_Result> RPTinhTien(Nullable<int> idbill, Nullable<int> tien)
        {
            var idbillParameter = idbill.HasValue ?
                new ObjectParameter("idbill", idbill) :
                new ObjectParameter("idbill", typeof(int));
    
            var tienParameter = tien.HasValue ?
                new ObjectParameter("tien", tien) :
                new ObjectParameter("tien", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RPTinhTien_Result>("RPTinhTien", idbillParameter, tienParameter);
        }
    
        public virtual ObjectResult<RP_sanPham_banChay_Result> RP_sanPham_banChay()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RP_sanPham_banChay_Result>("RP_sanPham_banChay");
        }
    
        public virtual ObjectResult<RP_doanhThuNgay_Result> RP_doanhThuNgay()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RP_doanhThuNgay_Result>("RP_doanhThuNgay");
        }
    
        public virtual ObjectResult<RP_soLuong_loai_Result> RP_soLuong_loai()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RP_soLuong_loai_Result>("RP_soLuong_loai");
        }
    
        public virtual ObjectResult<RP_soLuong_sanPham_Result> RP_soLuong_sanPham()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RP_soLuong_sanPham_Result>("RP_soLuong_sanPham");
        }
    }
}