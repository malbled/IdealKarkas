namespace IdealKarkas.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edit0306_02 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Orders", "DatePay");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "DatePay", c => c.DateTimeOffset(nullable: false, precision: 7));
        }
    }
}
