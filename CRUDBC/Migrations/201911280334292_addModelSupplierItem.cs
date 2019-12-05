namespace CRUDBC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addModelSupplierItem : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_m_supplier",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tb_m_supplier");
        }
    }
}
