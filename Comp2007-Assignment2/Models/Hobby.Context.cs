﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Comp2007_Assignment2.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DefaultConnectionEF : DbContext
    {
        public DefaultConnectionEF()
            : base("name=DefaultConnectionEF")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AspNetUsers> AspNetUsers1 { get; set; }
        public virtual DbSet<Books> Books1 { get; set; }
        public virtual DbSet<Games> Games1 { get; set; }
        public virtual DbSet<Records> Records1 { get; set; }
        public virtual DbSet<Shows> Shows1 { get; set; }
    }
}
