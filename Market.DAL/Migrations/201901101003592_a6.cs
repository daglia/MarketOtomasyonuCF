namespace Market.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SatisDetay", "SatisFiyati", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.SatisDetay", "SonFiyat");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SatisDetay", "SonFiyat", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.SatisDetay", "SatisFiyati");
        }
    }
}
