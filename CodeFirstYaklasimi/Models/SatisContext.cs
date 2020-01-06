namespace CodeFirstYaklasimi.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using CodeFirstYaklasimi.Migrations;

    public partial class SatisContext : DbContext
    {
        //        //Migration ektif etmek için
        //        Enable-Migrations ñEnableAutomaticMigrations

        ////Configuration dosyasýnda yapýcý metodta kolonlar üzerinde iþlem
        //        yapabilmek için
        //AutomaticMigrationDataLossAllowed = true;

        ////Yeni migration eklemek için
        //add-migration SinifAdi = add - migration MigrationAdi

        ////deðiþiklikleri veri tabanýnda güncellemek için
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
