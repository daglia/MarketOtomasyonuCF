namespace Market.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a21 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Urunler", "Indirim", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.SatisDetay", "Adet", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SatisDetay", "Adet");
            DropColumn("dbo.Urunler", "Indirim");
        }
    }
}
