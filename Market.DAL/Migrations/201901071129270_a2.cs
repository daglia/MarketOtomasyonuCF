namespace Market.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SatisDetay",
                c => new
                    {
                        SatisId = c.Int(nullable: false),
                        UrunId = c.Int(nullable: false),
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
            DropIndex("dbo.SatisDetay", new[] { "UrunId" });
            DropIndex("dbo.SatisDetay", new[] { "SatisId" });
            DropTable("dbo.Satislar");
            DropTable("dbo.SatisDetay");
        }
    }
}
