﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThucTapChuyenMon
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DatabaseQLTSEntities : DbContext
    {
        public DatabaseQLTSEntities()
            : base("name=DatabaseQLTSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<CTDoUong> CTDoUongs { get; set; }
        public virtual DbSet<CTHoaDon> CTHoaDons { get; set; }
        public virtual DbSet<CTPhieuNhap> CTPhieuNhaps { get; set; }
        public virtual DbSet<CTPhieuXuat> CTPhieuXuats { get; set; }
        public virtual DbSet<DoUong> DoUongs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiDoUong> LoaiDoUongs { get; set; }
        public virtual DbSet<LoaiKhachHang> LoaiKhachHangs { get; set; }
        public virtual DbSet<NguyenLieu> NguyenLieux { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public virtual DbSet<PhieuXuat> PhieuXuats { get; set; }
        public virtual DbSet<Uudai> Uudais { get; set; }
    
        [DbFunction("DatabaseQLTSEntities", "doanhso")]
        public virtual IQueryable<doanhso_Result> doanhso(Nullable<int> nam)
        {
            var namParameter = nam.HasValue ?
                new ObjectParameter("nam", nam) :
                new ObjectParameter("nam", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<doanhso_Result>("[DatabaseQLTSEntities].[doanhso](@nam)", namParameter);
        }
    
        [DbFunction("DatabaseQLTSEntities", "Function")]
        public virtual IQueryable<Function_Result> Function()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<Function_Result>("[DatabaseQLTSEntities].[Function]()");
        }
    
        public virtual ObjectResult<getdskhachhang_Result> getdskhachhang(Nullable<int> maloai)
        {
            var maloaiParameter = maloai.HasValue ?
                new ObjectParameter("maloai", maloai) :
                new ObjectParameter("maloai", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getdskhachhang_Result>("getdskhachhang", maloaiParameter);
        }
    
        public virtual ObjectResult<reporthoadon_Result> reporthoadon(Nullable<int> mahd)
        {
            var mahdParameter = mahd.HasValue ?
                new ObjectParameter("mahd", mahd) :
                new ObjectParameter("mahd", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<reporthoadon_Result>("reporthoadon", mahdParameter);
        }
    
        public virtual ObjectResult<RPhoadon_Result> RPhoadon(Nullable<int> mahd)
        {
            var mahdParameter = mahd.HasValue ?
                new ObjectParameter("mahd", mahd) :
                new ObjectParameter("mahd", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RPhoadon_Result>("RPhoadon", mahdParameter);
        }
    
        public virtual ObjectResult<RPHoaDonNgay_Result> RPHoaDonNgay(Nullable<System.DateTime> ngay)
        {
            var ngayParameter = ngay.HasValue ?
                new ObjectParameter("ngay", ngay) :
                new ObjectParameter("ngay", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RPHoaDonNgay_Result>("RPHoaDonNgay", ngayParameter);
        }
    
        public virtual ObjectResult<RPHoaDonThang_Result> RPHoaDonThang(Nullable<int> month, Nullable<int> year)
        {
            var monthParameter = month.HasValue ?
                new ObjectParameter("month", month) :
                new ObjectParameter("month", typeof(int));
    
            var yearParameter = year.HasValue ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RPHoaDonThang_Result>("RPHoaDonThang", monthParameter, yearParameter);
        }
    
        public virtual ObjectResult<RPPhieuNhapNgay_Result> RPPhieuNhapNgay(Nullable<System.DateTime> ngay)
        {
            var ngayParameter = ngay.HasValue ?
                new ObjectParameter("ngay", ngay) :
                new ObjectParameter("ngay", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RPPhieuNhapNgay_Result>("RPPhieuNhapNgay", ngayParameter);
        }
    
        public virtual ObjectResult<RPPhieuNhapThang_Result> RPPhieuNhapThang(Nullable<int> month, Nullable<int> year)
        {
            var monthParameter = month.HasValue ?
                new ObjectParameter("month", month) :
                new ObjectParameter("month", typeof(int));
    
            var yearParameter = year.HasValue ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RPPhieuNhapThang_Result>("RPPhieuNhapThang", monthParameter, yearParameter);
        }
    
        public virtual ObjectResult<RPPhieuXuatMonth_Result> RPPhieuXuatMonth(Nullable<int> month, Nullable<int> year)
        {
            var monthParameter = month.HasValue ?
                new ObjectParameter("month", month) :
                new ObjectParameter("month", typeof(int));
    
            var yearParameter = year.HasValue ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RPPhieuXuatMonth_Result>("RPPhieuXuatMonth", monthParameter, yearParameter);
        }
    
        public virtual ObjectResult<RPPhieuXuatNgay_Result> RPPhieuXuatNgay(Nullable<System.DateTime> ngay)
        {
            var ngayParameter = ngay.HasValue ?
                new ObjectParameter("ngay", ngay) :
                new ObjectParameter("ngay", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RPPhieuXuatNgay_Result>("RPPhieuXuatNgay", ngayParameter);
        }
    
        public virtual int ThemKhachHang(string makh, string ten, string sdt, string diachi, string email)
        {
            var makhParameter = makh != null ?
                new ObjectParameter("makh", makh) :
                new ObjectParameter("makh", typeof(string));
    
            var tenParameter = ten != null ?
                new ObjectParameter("ten", ten) :
                new ObjectParameter("ten", typeof(string));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ThemKhachHang", makhParameter, tenParameter, sdtParameter, diachiParameter, emailParameter);
        }
    
        public virtual int themloaidouong(string tenloai)
        {
            var tenloaiParameter = tenloai != null ?
                new ObjectParameter("tenloai", tenloai) :
                new ObjectParameter("tenloai", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("themloaidouong", tenloaiParameter);
        }
    
        public virtual int themsukien(string tenuudai, Nullable<System.DateTime> ngaybd, Nullable<System.DateTime> ngaykt, Nullable<double> giamgia)
        {
            var tenuudaiParameter = tenuudai != null ?
                new ObjectParameter("tenuudai", tenuudai) :
                new ObjectParameter("tenuudai", typeof(string));
    
            var ngaybdParameter = ngaybd.HasValue ?
                new ObjectParameter("ngaybd", ngaybd) :
                new ObjectParameter("ngaybd", typeof(System.DateTime));
    
            var ngayktParameter = ngaykt.HasValue ?
                new ObjectParameter("ngaykt", ngaykt) :
                new ObjectParameter("ngaykt", typeof(System.DateTime));
    
            var giamgiaParameter = giamgia.HasValue ?
                new ObjectParameter("giamgia", giamgia) :
                new ObjectParameter("giamgia", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("themsukien", tenuudaiParameter, ngaybdParameter, ngayktParameter, giamgiaParameter);
        }
    
        public virtual int updateCTdu(Nullable<int> madu, string size, Nullable<int> gia)
        {
            var maduParameter = madu.HasValue ?
                new ObjectParameter("madu", madu) :
                new ObjectParameter("madu", typeof(int));
    
            var sizeParameter = size != null ?
                new ObjectParameter("size", size) :
                new ObjectParameter("size", typeof(string));
    
            var giaParameter = gia.HasValue ?
                new ObjectParameter("gia", gia) :
                new ObjectParameter("gia", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updateCTdu", maduParameter, sizeParameter, giaParameter);
        }
    
        public virtual ObjectResult<xuatdskhachhang_Result> xuatdskhachhang(Nullable<int> maloai)
        {
            var maloaiParameter = maloai.HasValue ?
                new ObjectParameter("maloai", maloai) :
                new ObjectParameter("maloai", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<xuatdskhachhang_Result>("xuatdskhachhang", maloaiParameter);
        }
    }
}