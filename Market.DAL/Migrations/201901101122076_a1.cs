namespace Market.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a1 : DbMigration
    {
        public override void Up()
        {
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
            
            AddColumn("dbo.Urunler", "Indirim", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Urunler", "Stok", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SatisDetay", "UrunId", "dbo.Urunler");
            DropForeignKey("dbo.SatisDetay", "SatisId", "dbo.Satislar");
            DropIndex("dbo.SatisDetay", new[] { "UrunId" });
            DropIndex("dbo.SatisDetay", new[] { "SatisId" });
            AlterColumn("dbo.Urunler", "Stok", c => c.Int(nullable: false));
            DropColumn("dbo.Urunler", "Indirim");
            DropTable("dbo.Satislar");
            DropTable("dbo.SatisDetay");
        }
    }
}
