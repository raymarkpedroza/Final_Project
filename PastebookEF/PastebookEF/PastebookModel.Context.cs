﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PastebookEF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PASTEBOOKEntities : DbContext
    {
        public PASTEBOOKEntities()
            : base("name=PASTEBOOKEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<PASTEBOOK_COMMENT> PASTEBOOK_COMMENT { get; set; }
        public virtual DbSet<PASTEBOOK_FRIEND> PASTEBOOK_FRIEND { get; set; }
        public virtual DbSet<PASTEBOOK_LIKE> PASTEBOOK_LIKE { get; set; }
        public virtual DbSet<PASTEBOOK_NOTIFICATION> PASTEBOOK_NOTIFICATION { get; set; }
        public virtual DbSet<PASTEBOOK_POST> PASTEBOOK_POST { get; set; }
        public virtual DbSet<PASTEBOOK_USER> PASTEBOOK_USER { get; set; }
        public virtual DbSet<REF_COUNTRY> REF_COUNTRY { get; set; }
    }
}
