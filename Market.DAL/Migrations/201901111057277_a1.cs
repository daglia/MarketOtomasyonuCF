namespace Market.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategoriler",
                c => new
                    {
                        KategoriId = c.Int(nullable: false, identity: true),
                        KategoriAdi = c.String(nullable: false, maxLength: 20),
                        KDV = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Kar = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.KategoriId);
            
            CreateTable(
                "dbo.Urunler",
                c => new
                    {
                        UrunId = c.Int(nullable: false, identity: true),
                        UrunBarkod = c.String(nullable: false, maxLength: 13),
                        UrunAdi = c.String(nullable: false, maxLength: 100),
                        KutuBasinaAdet = c.Int(nullable: false),
                        BirimFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Indirim = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Stok = c.Int(nullable: false),
                        KategoriId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UrunId)
                .ForeignKey("dbo.Kategoriler", t => t.KategoriId, cascadeDelete: true)
                .Index(t => t.KategoriId);
            
            CreateTable(
                "dbo.SatisDetay",
                c => new
                    {
                        SatisId = c.Int(nullable: false),
                        UrunId = c.Int(nullable: false),
                        Adet = c.Int(nullable: false),
                        SatisFiyati = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.SatisId, t.UrunId })
                .ForeignKey("dbo.Satislar", t => t.SatisId, cascadeDelete: true)
                .ForeignKey("dbo.Urunler", t => t.UrunId, cascadeDelete: true)
                .Index(t => t.SatisId)
                .Index(t => t.UrunId);
            
            CreateTable(
                "dbo.Satislar",
                c => new
                    {
                        SatisId = c.Int(nullable: false, identity: true),
                        SatisZamani = c.DateTime(nullable: false),
                        OdemeYontemi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SatisId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SatisDetay", "UrunId", "dbo.Urunler");
            DropForeignKey("dbo.SatisDetay", "SatisId", "dbo.Satislar");
            DropForeignKey("dbo.Urunler", "KategoriId", "dbo.Kategoriler");
            DropIndex("dbo.SatisDetay", new[] { "UrunId" });
            DropIndex("dbo.SatisDetay", new[] { "SatisId" });
            DropIndex("dbo.Urunler", new[] { "KategoriId" });
            DropTable("dbo.Satislar");
            DropTable("dbo.SatisDetay");
            DropTable("dbo.Urunler");
            DropTable("dbo.Kategoriler");
        }
    }
}
