namespace SludinājumuWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sludinājums",
                c => new
                    {
                        AdvertId = c.Int(nullable: false, identity: true),
                        Price = c.Double(nullable: false),
                        Name = c.String(),
                        AdvertText = c.String(),
                        CreationTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AdvertId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sludinājums");
        }
    }
}
