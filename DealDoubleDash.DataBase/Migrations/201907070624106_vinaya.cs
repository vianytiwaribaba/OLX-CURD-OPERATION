namespace DealDoubleDash.DataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class vinaya : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_Auction",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        ActualAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StartingTime = c.DateTime(nullable: false),
                        EndindTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tbl_Auction");
        }
    }
}
