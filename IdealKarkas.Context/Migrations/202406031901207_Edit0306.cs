namespace IdealKarkas.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edit0306 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ObjectModOrders", "ObjectMod_Id", "dbo.ObjectMods");
            DropForeignKey("dbo.ObjectModOrders", "Order_Id", "dbo.Orders");
            DropIndex("dbo.ObjectModOrders", new[] { "ObjectMod_Id" });
            DropIndex("dbo.ObjectModOrders", new[] { "Order_Id" });
            CreateTable(
                "dbo.ObjectOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ObjectModId = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                        CountObject = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ObjectMods", t => t.ObjectModId, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.ObjectModId)
                .Index(t => t.OrderId);
            
            DropTable("dbo.ObjectModOrders");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ObjectModOrders",
                c => new
                    {
                        ObjectMod_Id = c.Int(nullable: false),
                        Order_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ObjectMod_Id, t.Order_Id });
            
            DropForeignKey("dbo.ObjectOrders", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.ObjectOrders", "ObjectModId", "dbo.ObjectMods");
            DropIndex("dbo.ObjectOrders", new[] { "OrderId" });
            DropIndex("dbo.ObjectOrders", new[] { "ObjectModId" });
            DropTable("dbo.ObjectOrders");
            CreateIndex("dbo.ObjectModOrders", "Order_Id");
            CreateIndex("dbo.ObjectModOrders", "ObjectMod_Id");
            AddForeignKey("dbo.ObjectModOrders", "Order_Id", "dbo.Orders", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ObjectModOrders", "ObjectMod_Id", "dbo.ObjectMods", "Id", cascadeDelete: true);
        }
    }
}
