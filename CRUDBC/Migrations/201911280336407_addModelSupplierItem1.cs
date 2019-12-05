namespace CRUDBC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addModelSupplierItem1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_m_item",
                c => new
                    {
                        ItemId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Stock = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        Supplier_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ItemId)
                .ForeignKey("dbo.tb_m_supplier", t => t.Supplier_Id)
                .Index(t => t.Supplier_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_m_item", "Supplier_Id", "dbo.tb_m_supplier");
            DropIndex("dbo.tb_m_item", new[] { "Supplier_Id" });
            DropTable("dbo.tb_m_item");
        }
    }
}
