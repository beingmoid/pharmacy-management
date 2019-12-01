namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Entities;

    public partial class DbPharmacyContext : DbContext
    {
        public DbPharmacyContext()
            : base("Data Source=DESKTOP-M5C4BD6;Initial Catalog=dbPharmacy;Integrated Security=True")
        {
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Sessions> Sessions { get; set; } 
        public DbSet<Page>  Pages { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<UserSelectedType> UserSelectedTypes { get; set; }
        public DbSet<MedicineType> MedicineType { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Sessions>/*Child*/().HasRequired<Users>/*Parent*/(s => s.User)/*Parentobj in Child table*/
            //   .WithMany(s => s.Sessions).HasForeignKey<int>/*Datatype of foreign key*/
            //   (f => f.UserID)/*Foreignkey*/;

            modelBuilder.Entity<Sessions>().HasRequired<Users>(s => s.User)
                .WithMany(s => s.Sessions).HasForeignKey<int>(f => f.UserID);
            modelBuilder.Entity<UserRoles>().HasRequired<Users>(s => s.User)
                .WithMany(s => s.UserRoles).HasForeignKey<int>(f => f.UserID);
            modelBuilder.Entity<UserRoles>().HasRequired<Page>(s => s.Page)
                .WithMany(s => s.UserRoles).HasForeignKey<int>(f => f.PageID);
            modelBuilder.Entity<UserSelectedType>().HasRequired<Users>(s => s.Users)
                .WithMany(s => s.UserSelectedTypes).HasForeignKey<int>(f => f.UserID);
            modelBuilder.Entity<UserSelectedType>().HasRequired<UserType>(s => s.UserType)
                .WithMany(s => s.UserSelectedTypes).HasForeignKey<int>(f => f.UserTypeID);
            modelBuilder.Entity<Medicine>().HasRequired<MedicineType>(s => s.MedicineType)
                .WithMany(s => s.Medicines).HasForeignKey<int>(f => f.MedicineTypeId);
            modelBuilder.Entity<Stock>().HasRequired<Medicine>(s => s.Medicine)
                .WithMany(s => s.Stock).HasForeignKey<int>(f => f.MedicineId);
            modelBuilder.Entity<Stock>().HasRequired<Supplier>(s => s.Supplier)
                .WithMany(s => s.Stock).HasForeignKey<int>(f => f.SupplierId);
            modelBuilder.Entity<Sale>().HasRequired<Invoice>(s => s.Invoice)
              .WithMany(s => s.Sale).HasForeignKey<int>(f => f.InvoivceId);
            modelBuilder.Entity<Sale>().HasRequired<Medicine>(s => s.Medicine)
            .WithMany(s => s.Sale).HasForeignKey<int>(f => f.MedicineId);
        }
    }
}
