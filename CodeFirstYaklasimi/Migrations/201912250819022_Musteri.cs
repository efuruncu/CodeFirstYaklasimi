namespace CodeFirstYaklasimi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Musteri : DbMigration
    {
        public override void Up()
        {
            //Ekleme  Ýþlemleri burada yapýlýr.
            CreateTable(
                "dbo.Musteri",
                c => new
                    {
                        MusteriID = c.Int(nullable: false, identity: true),
                        MusteriAdi = c.String(maxLength: 50),
                        MusteriSoyadi = c.String(maxLength: 50),
                        Adres = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.MusteriID);
            
            CreateTable(
                "dbo.Satis",
                c => new
                    {
                        SatisID = c.Int(nullable: false, identity: true),
                        MusteriID = c.Int(),
                        Tutar = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.SatisID)
                .ForeignKey("dbo.Musteri", t => t.MusteriID)
                .Index(t => t.MusteriID);

            //AddColumn("Musteri", "CepTelNo", x => x.String(maxLength:10,nullable:false,defaultValue:""));
            //AddColumn("Musteri", "MesajGelsinMi", x => x.Boolean(nullable: false, defaultValue: false));
            
        }
        
        public override void Down()
        {
            //Silme Ýþlemleri burada yapýlýr.
            DropForeignKey("dbo.Satis", "MusteriID", "dbo.Musteri");
            DropIndex("dbo.Satis", new[] { "MusteriID" });
            DropTable("dbo.Satis");
            DropTable("dbo.Musteri");

          //Silme...  DropColumn("Musteri", "CepTelNo");
        }
    }
}
