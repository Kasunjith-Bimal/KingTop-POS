﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseHandler
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class kingtopEntities : DbContext
    {
        public kingtopEntities()
            : base("name=kingtopEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<debt> debts { get; set; }
        public virtual DbSet<invoiceheader> invoiceheaders { get; set; }
        public virtual DbSet<invoiceline> invoicelines { get; set; }
        public virtual DbSet<LoginDetail> LoginDetails { get; set; }
        public virtual DbSet<PaymentDetail> PaymentDetails { get; set; }
        public virtual DbSet<product1> product1 { get; set; }
        public virtual DbSet<wait> waits { get; set; }
        public virtual DbSet<waitproduct> waitproducts { get; set; }
    }
}