namespace IdealKarkas.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create2105 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Patronymic = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        CompanyName = c.String(),
                        INN = c.String(),
                        CityCompany = c.String(),
                        DateRegistration = c.DateTimeOffset(nullable: false, precision: 7),
                        TypeClient = c.Int(nullable: false),
                        TypeInforming = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumberProject = c.String(),
                        ClientId = c.Int(nullable: false),
                        StaffId = c.Int(nullable: false),
                        DateAdd = c.DateTimeOffset(nullable: false, precision: 7),
                        DateEnd = c.DateTimeOffset(nullable: false, precision: 7),
                        DatePay = c.DateTimeOffset(nullable: false, precision: 7),
                        DateEndFact = c.DateTimeOffset(precision: 7),
                        DatePayFact = c.DateTimeOffset(precision: 7),
                        Address = c.String(),
                        AllPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Staffs", t => t.StaffId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.StaffId);
            
            CreateTable(
                "dbo.ObjectMods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeObjectId = c.Int(nullable: false),
                        Title = c.String(),
                        Area = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Floor = c.Int(nullable: false),
                        CountBedroom = c.Int(nullable: false),
                        CountBathroom = c.Int(nullable: false),
                        MinPeriod = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                        ImagePreview = c.Binary(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TypeObjects", t => t.TypeObjectId, cascadeDelete: true)
                .Index(t => t.TypeObjectId);
            
            CreateTable(
                "dbo.TypeObjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Patronymic = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        Passport = c.String(),
                        Post = c.String(),
                        TypeUser = c.Int(nullable: false),
                        Login = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Hardwares",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        SerialNumber = c.String(),
                        Manufacturer = c.String(),
                        Description = c.String(),
                        TypeOvership = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ObjectModOrders",
                c => new
                    {
                        ObjectMod_Id = c.Int(nullable: false),
                        Order_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ObjectMod_Id, t.Order_Id })
                .ForeignKey("dbo.ObjectMods", t => t.ObjectMod_Id, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.Order_Id, cascadeDelete: true)
                .Index(t => t.ObjectMod_Id)
                .Index(t => t.Order_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "StaffId", "dbo.Staffs");
            DropForeignKey("dbo.ObjectMods", "TypeObjectId", "dbo.TypeObjects");
            DropForeignKey("dbo.ObjectModOrders", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.ObjectModOrders", "ObjectMod_Id", "dbo.ObjectMods");
            DropForeignKey("dbo.Orders", "ClientId", "dbo.Clients");
            DropIndex("dbo.ObjectModOrders", new[] { "Order_Id" });
            DropIndex("dbo.ObjectModOrders", new[] { "ObjectMod_Id" });
            DropIndex("dbo.ObjectMods", new[] { "TypeObjectId" });
            DropIndex("dbo.Orders", new[] { "StaffId" });
            DropIndex("dbo.Orders", new[] { "ClientId" });
            DropTable("dbo.ObjectModOrders");
            DropTable("dbo.Hardwares");
            DropTable("dbo.Staffs");
            DropTable("dbo.TypeObjects");
            DropTable("dbo.ObjectMods");
            DropTable("dbo.Orders");
            DropTable("dbo.Clients");
        }
    }
}
