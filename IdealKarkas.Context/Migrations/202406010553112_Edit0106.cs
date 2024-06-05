namespace IdealKarkas.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edit0106 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Clients", "TypeInforming");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "TypeInforming", c => c.Int(nullable: false));
        }
    }
}
