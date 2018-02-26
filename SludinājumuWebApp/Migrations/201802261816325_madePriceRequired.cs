namespace SludinājumuWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class madePriceRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Sludinājums", "Name", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sludinājums", "Name", c => c.String());
        }
    }
}
