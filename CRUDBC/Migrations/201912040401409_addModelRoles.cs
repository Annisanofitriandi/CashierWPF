namespace CRUDBC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addModelRoles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_m_role",
                c => new
                    {
                        IdRole = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.IdRole);
            
            CreateTable(
                "dbo.TB_M_User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        RegisterDate = c.DateTimeOffset(nullable: false, precision: 7),
                        Roles_IdRole = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tb_m_role", t => t.Roles_IdRole)
                .Index(t => t.Roles_IdRole);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_M_User", "Roles_IdRole", "dbo.tb_m_role");
            DropIndex("dbo.TB_M_User", new[] { "Roles_IdRole" });
            DropTable("dbo.TB_M_User");
            DropTable("dbo.tb_m_role");
        }
    }
}
