namespace NetworkAcademyFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ogrencis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(maxLength: 20),
                        Soyad = c.String(maxLength: 20),
                        TCKimlikNo = c.String(maxLength: 11),
                        Adres = c.String(maxLength: 50),
                        Telefon = c.String(maxLength: 20),
                        AldigiEgitim = c.String(maxLength: 20),
                        BasariDurumu = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ogrencis");
        }
    }
}
