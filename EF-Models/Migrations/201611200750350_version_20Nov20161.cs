namespace EF_Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class version_20Nov20161 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.PhieuMuon", new[] { "MaPhieuMuon" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.PhieuMuon", "MaPhieuMuon", unique: true);
        }
    }
}
