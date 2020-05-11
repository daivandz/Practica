namespace Control_inventario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductCode = c.String(),
                        ProductName = c.String(),
                        Description = c.String(),
                        Quantity = c.Int(nullable: false),
                        SupplirId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Suppliers", t => t.SupplirId, cascadeDelete: true)
                .Index(t => t.SupplirId);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SupplierCode = c.String(),
                        SupplierName = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "SupplirId", "dbo.Suppliers");
            DropIndex("dbo.Products", new[] { "SupplirId" });
            DropTable("dbo.Suppliers");
            DropTable("dbo.Products");
        }
    }
}
