namespace CodeFirstYaklasimi.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using CodeFirstYaklasimi.Migrations;

    public partial class SatisContext : DbContext
    {
        //        //Migration ektif etmek i�in
        //        Enable-Migrations �EnableAutomaticMigrations

        ////Configuration dosyas�nda yap�c� metodta kolonlar �zerinde i�lem
        //        yapabilmek i�in
        //AutomaticMigrationDataLossAllowed = true;

        ////Yeni migration eklemek i�in
        //add-migration SinifAdi = add - migration MigrationAdi

        ////de�i�iklikleri veri taban�nda g�ncellemek i�in
        //        Update-Database
        public SatisContext()
            : base("name=SatisContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SatisContext, Configuration>("SatisContext"));
        }

        public virtual DbSet<Musteri> Musteri { get; set; }
        public virtual DbSet<Satis> Satis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
