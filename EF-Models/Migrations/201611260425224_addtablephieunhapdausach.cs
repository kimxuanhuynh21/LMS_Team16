namespace EF_Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtablephieunhapdausach : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PhieuNhapDauSach",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DauSachID = c.Int(nullable: false),
                        NgayNhap = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.DauSach", t => t.DauSachID)
                .Index(t => t.DauSachID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PhieuNhapDauSach", "DauSachID", "dbo.DauSach");
            DropIndex("dbo.PhieuNhapDauSach", new[] { "DauSachID" });
            DropTable("dbo.PhieuNhapDauSach");
        }
    }
}
