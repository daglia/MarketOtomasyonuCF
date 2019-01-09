namespace Market.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SatisDetay", "SonFiyat", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SatisDetay", "SonFiyat");
        }
    }
}
