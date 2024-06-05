namespace IdealKarkas.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edit2105 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Staffs", "ImagePreview", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Staffs", "ImagePreview");
        }
    }
}
