namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                        Population = c.Int(nullable: false),
                        Province_ProvinceCode = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.CityId)
                .ForeignKey("dbo.Provinces", t => t.Province_ProvinceCode)
                .Index(t => t.Province_ProvinceCode);
            
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        ProvinceCode = c.String(nullable: false, maxLength: 128),
                        ProvinceName = c.String(),
                    })
                .PrimaryKey(t => t.ProvinceCode);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "Province_ProvinceCode", "dbo.Provinces");
            DropIndex("dbo.Cities", new[] { "Province_ProvinceCode" });
            DropTable("dbo.Provinces");
            DropTable("dbo.Cities");
        }
    }
}
