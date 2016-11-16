namespace EF_Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class version_16Nov20161 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ThongKeDauSach",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DauSachID = c.Int(nullable: false),
                        Ngay = c.DateTime(nullable: false),
                        SoLuongHienTai = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PhieuTra", t => t.DauSachID)
                .Index(t => t.DauSachID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ThongKeDauSach", "DauSachID", "dbo.PhieuTra");
            DropIndex("dbo.ThongKeDauSach", new[] { "DauSachID" });
            DropTable("dbo.ThongKeDauSach");
        }
    }
}
