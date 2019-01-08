namespace Market.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kategoriler", "UstKategoriId", c => c.Int());
            CreateIndex("dbo.Kategoriler", "UstKategoriId");
            AddForeignKey("dbo.Kategoriler", "UstKategoriId", "dbo.Kategoriler", "KategoriId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kategoriler", "UstKategoriId", "dbo.Kategoriler");
            DropIndex("dbo.Kategoriler", new[] { "UstKategoriId" });
            DropColumn("dbo.Kategoriler", "UstKategoriId");
        }
    }
}
