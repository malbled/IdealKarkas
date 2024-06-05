namespace IdealKarkas.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edit3105 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ObjectMods", "IsActual", c => c.Int());
            AddColumn("dbo.Hardwares", "IsActual", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Hardwares", "IsActual");
            DropColumn("dbo.ObjectMods", "IsActual");
        }
    }
}
