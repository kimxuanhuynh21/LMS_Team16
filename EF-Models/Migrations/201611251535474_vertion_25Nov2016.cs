namespace EF_Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class vertion_25Nov2016 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.PhieuTra", new[] { "MaPhieuTra" });
            AlterColumn("dbo.PhieuTra", "MaPhieuTra", c => c.String(maxLength: 100));
            CreateIndex("dbo.PhieuTra", "MaPhieuTra", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.PhieuTra", new[] { "MaPhieuTra" });
            AlterColumn("dbo.PhieuTra", "MaPhieuTra", c => c.String(nullable: false, maxLength: 100));
            CreateIndex("dbo.PhieuTra", "MaPhieuTra", unique: true);
        }
    }
}
