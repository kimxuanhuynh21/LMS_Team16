namespace EF_Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class version_20Nov2016 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.PhieuMuon", new[] { "MaPhieuMuon" });
            AlterColumn("dbo.PhieuMuon", "MaPhieuMuon", c => c.String(maxLength: 100));
            CreateIndex("dbo.PhieuMuon", "MaPhieuMuon", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.PhieuMuon", new[] { "MaPhieuMuon" });
            AlterColumn("dbo.PhieuMuon", "MaPhieuMuon", c => c.String(nullable: false, maxLength: 100));
            CreateIndex("dbo.PhieuMuon", "MaPhieuMuon", unique: true);
        }
    }
}
