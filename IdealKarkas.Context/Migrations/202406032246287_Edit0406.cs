namespace IdealKarkas.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edit0406 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        DateAdd = c.DateTimeOffset(nullable: false, precision: 7),
                        AdminFIO = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HardwareTasks",
                c => new
                    {
                        Hardware_Id = c.Int(nullable: false),
                        Task_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Hardware_Id, t.Task_Id })
                .ForeignKey("dbo.Hardwares", t => t.Hardware_Id, cascadeDelete: true)
                .ForeignKey("dbo.Tasks", t => t.Task_Id, cascadeDelete: true)
                .Index(t => t.Hardware_Id)
                .Index(t => t.Task_Id);
            
            CreateTable(
                "dbo.TaskOrders",
                c => new
                    {
                        Task_Id = c.Int(nullable: false),
                        Order_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Task_Id, t.Order_Id })
                .ForeignKey("dbo.Tasks", t => t.Task_Id, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.Order_Id, cascadeDelete: true)
                .Index(t => t.Task_Id)
                .Index(t => t.Order_Id);
            
            CreateTable(
                "dbo.TaskStaffs",
                c => new
                    {
                        Task_Id = c.Int(nullable: false),
                        Staff_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Task_Id, t.Staff_Id })
                .ForeignKey("dbo.Tasks", t => t.Task_Id, cascadeDelete: true)
                .ForeignKey("dbo.Staffs", t => t.Staff_Id, cascadeDelete: true)
                .Index(t => t.Task_Id)
                .Index(t => t.Staff_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TaskStaffs", "Staff_Id", "dbo.Staffs");
            DropForeignKey("dbo.TaskStaffs", "Task_Id", "dbo.Tasks");
            DropForeignKey("dbo.TaskOrders", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.TaskOrders", "Task_Id", "dbo.Tasks");
            DropForeignKey("dbo.HardwareTasks", "Task_Id", "dbo.Tasks");
            DropForeignKey("dbo.HardwareTasks", "Hardware_Id", "dbo.Hardwares");
            DropIndex("dbo.TaskStaffs", new[] { "Staff_Id" });
            DropIndex("dbo.TaskStaffs", new[] { "Task_Id" });
            DropIndex("dbo.TaskOrders", new[] { "Order_Id" });
            DropIndex("dbo.TaskOrders", new[] { "Task_Id" });
            DropIndex("dbo.HardwareTasks", new[] { "Task_Id" });
            DropIndex("dbo.HardwareTasks", new[] { "Hardware_Id" });
            DropTable("dbo.TaskStaffs");
            DropTable("dbo.TaskOrders");
            DropTable("dbo.HardwareTasks");
            DropTable("dbo.Tasks");
        }
    }
}
