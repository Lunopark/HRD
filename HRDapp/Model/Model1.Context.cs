﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRDapp.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HRDEntities : DbContext
    {
        public HRDEntities()
            : base("name=HRDEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_applicant_personal> tbl_applicant_personal { get; set; }
        public virtual DbSet<tbl_department> tbl_department { get; set; }
        public virtual DbSet<tbl_grad> tbl_grad { get; set; }
        public virtual DbSet<tbl_hsc> tbl_hsc { get; set; }
        public virtual DbSet<tbl_mas> tbl_mas { get; set; }
        public virtual DbSet<tbl_position> tbl_position { get; set; }
        public virtual DbSet<tbl_ssc> tbl_ssc { get; set; }
    }
}
