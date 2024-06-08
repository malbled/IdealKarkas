namespace IdealKarkas.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edit0806 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Hardwares", "ManufacrureId", c => c.Int(nullable: false));
            AddColumn("dbo.Hardwares", "Manufacturer_Id", c => c.Int());
            CreateIndex("dbo.Hardwares", "Manufacturer_Id");
            AddForeignKey("dbo.Hardwares", "Manufacturer_Id", "dbo.Manufacturers", "Id");
            DropColumn("dbo.Hardwares", "Manufacturer");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Hardwares", "Manufacturer", c => c.String());
            DropForeignKey("dbo.Hardwares", "Manufacturer_Id", "dbo.Manufacturers");
            DropIndex("dbo.Hardwares", new[] { "Manufacturer_Id" });
            DropColumn("dbo.Hardwares", "Manufacturer_Id");
            DropColumn("dbo.Hardwares", "ManufacrureId");
            DropTable("dbo.Manufacturers");
        }
    }
}
