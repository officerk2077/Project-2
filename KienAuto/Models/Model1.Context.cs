﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KienAuto.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KienAutoEntities1 : DbContext
    {
        public KienAutoEntities1()
            : base("name=KienAutoEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tb_Adv> tb_Adv { get; set; }
        public virtual DbSet<tb_Contact> tb_Contact { get; set; }
        public virtual DbSet<tb_News> tb_News { get; set; }
        public virtual DbSet<tb_Order> tb_Order { get; set; }
        public virtual DbSet<tb_OrderDetail> tb_OrderDetail { get; set; }
        public virtual DbSet<tb_Post> tb_Post { get; set; }
        public virtual DbSet<tb_Product> tb_Product { get; set; }
        public virtual DbSet<tb_ProductCategory> tb_ProductCategory { get; set; }
        public virtual DbSet<tb_Subscribe> tb_Subscribe { get; set; }
        public virtual DbSet<tb_SystemSetting> tb_SystemSetting { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
