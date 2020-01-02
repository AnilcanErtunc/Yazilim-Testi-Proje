namespace Yaızlım_Test_Projesi.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SinavDB : DbContext
    {
        public SinavDB()
            : base("name=SinavDB")
        {
        }

        public virtual DbSet<SınavGeçmişiTBL> SınavGeçmişiTBL { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TBLKONU> TBLKONUs { get; set; }
        public virtual DbSet<TBLOGRENCİ> TBLOGRENCİ { get; set; }
        public virtual DbSet<TBLOGRETMan> TBLOGRETMEN { get; set; }
        public virtual DbSet<TBLSINAV> TBLSINAVs { get; set; }
        public virtual DbSet<TBLSORU> TBLSORUs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TBLKONU>()
                .HasMany(e => e.SınavGeçmişiTBL)
                .WithRequired(e => e.TBLKONU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBLKONU>()
                .HasMany(e => e.TBLSORUs)
                .WithRequired(e => e.TBLKONU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBLOGRENCİ>()
                .HasMany(e => e.TBLSINAVs)
                .WithRequired(e => e.TBLOGRENCİ)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBLSINAV>()
                .HasMany(e => e.SınavGeçmişiTBL)
                .WithRequired(e => e.TBLSINAV)
                .WillCascadeOnDelete(false);
        }
    }
}
