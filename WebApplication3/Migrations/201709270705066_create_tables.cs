namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_tables : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Cities", name: "Province_ProvinceCode", newName: "ProvinceCode");
            RenameIndex(table: "dbo.Cities", name: "IX_Province_ProvinceCode", newName: "IX_ProvinceCode");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Cities", name: "IX_ProvinceCode", newName: "IX_Province_ProvinceCode");
            RenameColumn(table: "dbo.Cities", name: "ProvinceCode", newName: "Province_ProvinceCode");
        }
    }
}
