namespace EF_Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_forgein_key_the_loai : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DauSach", "TheLoai_ID", "dbo.TheLoai");
            DropIndex("dbo.DauSach", new[] { "TheLoai_ID" });
            RenameColumn(table: "dbo.DauSach", name: "TheLoai_ID", newName: "TheLoaiId");
            AlterColumn("dbo.DauSach", "TheLoaiId", c => c.Int(nullable: false));
            CreateIndex("dbo.DauSach", "TheLoaiId");
            AddForeignKey("dbo.DauSach", "TheLoaiId", "dbo.TheLoai", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DauSach", "TheLoaiId", "dbo.TheLoai");
            DropIndex("dbo.DauSach", new[] { "TheLoaiId" });
            AlterColumn("dbo.DauSach", "TheLoaiId", c => c.Int());
            RenameColumn(table: "dbo.DauSach", name: "TheLoaiId", newName: "TheLoai_ID");
            CreateIndex("dbo.DauSach", "TheLoai_ID");
            AddForeignKey("dbo.DauSach", "TheLoai_ID", "dbo.TheLoai", "ID");
        }
    }
}
