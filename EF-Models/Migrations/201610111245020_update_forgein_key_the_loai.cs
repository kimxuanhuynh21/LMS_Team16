namespace EF_Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_forgein_key_the_loai : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TacGia",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ten_tac_gia = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.DauSach", "ten_dau_sach", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.DauSach", "TacGiaId", c => c.Int(nullable: false));
            AddColumn("dbo.DauSach", "tom_tat", c => c.String(maxLength: 2000));
            AddColumn("dbo.DauSach", "tai_ban", c => c.Int(nullable: false));
            AddColumn("dbo.DauSach", "id_nha_san_xuat", c => c.Int(nullable: false));
            AddColumn("dbo.DauSach", "so_luong_tong", c => c.Int(nullable: false));
            AddColumn("dbo.DauSach", "so_luong_ton", c => c.Int(nullable: false));
            AddColumn("dbo.DauSach", "trang_thai", c => c.Byte(nullable: false));
            AddColumn("dbo.TheLoai", "ten_the_loai", c => c.String(nullable: false));
            CreateIndex("dbo.DauSach", "TacGiaId");
            AddForeignKey("dbo.DauSach", "TacGiaId", "dbo.TacGia", "id", cascadeDelete: true);
            DropColumn("dbo.DauSach", "Ten");
            DropColumn("dbo.TheLoai", "Ten");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TheLoai", "Ten", c => c.String());
            AddColumn("dbo.DauSach", "Ten", c => c.String());
            DropForeignKey("dbo.DauSach", "TacGiaId", "dbo.TacGia");
            DropIndex("dbo.DauSach", new[] { "TacGiaId" });
            DropColumn("dbo.TheLoai", "ten_the_loai");
            DropColumn("dbo.DauSach", "trang_thai");
            DropColumn("dbo.DauSach", "so_luong_ton");
            DropColumn("dbo.DauSach", "so_luong_tong");
            DropColumn("dbo.DauSach", "id_nha_san_xuat");
            DropColumn("dbo.DauSach", "tai_ban");
            DropColumn("dbo.DauSach", "tom_tat");
            DropColumn("dbo.DauSach", "TacGiaId");
            DropColumn("dbo.DauSach", "ten_dau_sach");
            DropTable("dbo.TacGia");
        }
    }
}
