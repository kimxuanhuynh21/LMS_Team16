namespace EF_Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateagainphieunhapdausach : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PhieuNhapDauSach", "SoLuongCuonSach", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PhieuNhapDauSach", "SoLuongCuonSach");
        }
    }
}
