namespace IdealKarkas.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edit2205 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Staffs", "IsActual", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Staffs", "IsActual");
        }
    }
}
