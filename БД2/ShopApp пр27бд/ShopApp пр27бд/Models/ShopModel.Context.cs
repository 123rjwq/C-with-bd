﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopApp_пр27бд.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Shop_liissaEntities : DbContext
    {
        private static Shop_liissaEntities _context;
        public Shop_liissaEntities()
            : base("name=Shop_liissaEntities")
        {
        }
        public static Shop_liissaEntities GetContext()
        {
            if (_context == null)
            { _context = new Shop_liissaEntities(); }
            return _context;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Good> Goods { get; set; }
        public virtual DbSet<Sell> Sells { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
