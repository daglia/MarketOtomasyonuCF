namespace Market.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Kategoriler", "UstKategoriId", "dbo.Kategoriler");
            DropIndex("dbo.Kategoriler", new[] { "UstKategoriId" });
            DropColumn("dbo.Kategoriler", "UstKategoriId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kategoriler", "UstKategoriId", c => c.Int());
            CreateIndex("dbo.Kategoriler", "UstKategoriId");
            AddForeignKey("dbo.Kategoriler", "UstKategoriId", "dbo.Kategoriler", "KategoriId");
        }
    }
}
