namespace EF_Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class version_21Dec2016 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PhieuTra", "PhieuMuonID", "dbo.PhieuMuon");
            DropIndex("dbo.PhieuTra", new[] { "PhieuMuonID" });
            DropColumn("dbo.PhieuTra", "PhieuMuonID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PhieuTra", "PhieuMuonID", c => c.Int(nullable: false));
            CreateIndex("dbo.PhieuTra", "PhieuMuonID");
            AddForeignKey("dbo.PhieuTra", "PhieuMuonID", "dbo.PhieuMuon", "ID");
        }
    }
}
