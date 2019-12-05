namespace CRUDBC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addModelTransaksi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_t_transaksiitem",
                c => new
                    {
                        IdTransaksiItem = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        SubTotal = c.Int(nullable: false),
                        Item_ItemId = c.Int(),
                        Transaksi_IdTransaksi = c.Int(),
                    })
                .PrimaryKey(t => t.IdTransaksiItem)
                .ForeignKey("dbo.tb_m_item", t => t.Item_ItemId)
                .ForeignKey("dbo.tb_m_transaksi", t => t.Transaksi_IdTransaksi)
                .Index(t => t.Item_ItemId)
                .Index(t => t.Transaksi_IdTransaksi);
            
            CreateTable(
                "dbo.tb_m_transaksi",
                c => new
                    {
                        IdTransaksi = c.Int(nullable: false, identity: true),
                        Total = c.Int(nullable: false),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.IdTransaksi);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_t_transaksiitem", "Transaksi_IdTransaksi", "dbo.tb_m_transaksi");
            DropForeignKey("dbo.tb_t_transaksiitem", "Item_ItemId", "dbo.tb_m_item");
            DropIndex("dbo.tb_t_transaksiitem", new[] { "Transaksi_IdTransaksi" });
            DropIndex("dbo.tb_t_transaksiitem", new[] { "Item_ItemId" });
            DropTable("dbo.tb_m_transaksi");
            DropTable("dbo.tb_t_transaksiitem");
        }
    }
}
