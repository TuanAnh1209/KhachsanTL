//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyKhachSan
{
    using System;
    using System.Collections.Generic;
    
    public partial class quyennv
    {
        public string manv { get; set; }
        public string id { get; set; }
        public string matkhau { get; set; }
    
        public virtual nhanvien nhanvien { get; set; }
        public virtual phanquyen phanquyen { get; set; }
    }
}