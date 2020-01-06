namespace CodeFirstYaklasimi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Musteri1 : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Musteri", "VergiDairesi", c => c.String(maxLength: 20,nullable:false,defaultValue:""));
            //AddColumn("dbo.Musteri", "Kdv", c => c.Boolean(defaultValue: false));
        }
        
        public override void Down() 
        {
            
        }
    }
}
