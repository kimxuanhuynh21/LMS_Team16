namespace EF_Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update12Oct2016 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DauSach", "TacGiaId", "dbo.TacGia");
            DropForeignKey("dbo.DauSach", "TheLoaiId", "dbo.TheLoai");
            DropIndex("dbo.DauSach", new[] { "TheLoaiId" });
            DropIndex("dbo.DauSach", new[] { "TacGiaId" });
            CreateTable(
                "dbo.ChiTietMuon",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PhieuMuonID = c.Int(nullable: false),
                        CuonSachID = c.Int(nullable: false),
                        TinhTrangID = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CuonSach", t => t.CuonSachID)
                .ForeignKey("dbo.PhieuMuon", t => t.PhieuMuonID)
                .ForeignKey("dbo.TinhTrang", t => t.TinhTrangID)
                .Index(t => t.PhieuMuonID)
                .Index(t => t.CuonSachID)
                .Index(t => t.TinhTrangID);
            
            CreateTable(
                "dbo.CuonSach",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MaVach = c.String(nullable: false, maxLength: 100),
                        DauSachID = c.Int(nullable: false),
                        TinhTrangID = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.DauSach", t => t.DauSachID)
                .ForeignKey("dbo.TinhTrang", t => t.TinhTrangID)
                .Index(t => t.MaVach, unique: true)
                .Index(t => t.DauSachID)
                .Index(t => t.TinhTrangID);
            
            CreateTable(
                "dbo.NhaSanXuat",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Ten = c.String(nullable: false, maxLength: 255),
                        DienThoai = c.String(nullable: false, maxLength: 11),
                        DiaChi = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TinhTrang",
                c => new
                    {
                        ID = c.Byte(nullable: false),
                        Ten = c.String(nullable: false, maxLength: 255),
                        BangLienQuan = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PhieuMuon",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MaPhieuMuon = c.String(nullable: false, maxLength: 100),
                        NgayMuon = c.DateTime(nullable: false),
                        NgayTra = c.DateTime(nullable: false),
                        DocGiaID = c.Int(nullable: false),
                        NhanVienID = c.Int(nullable: false),
                        NgayHetHan = c.DateTime(nullable: false),
                        TongSoLuongMuon = c.Int(nullable: false),
                        SoLuongTra = c.Int(nullable: false),
                        TinhTrangID = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.DocGia", t => t.DocGiaID)
                .ForeignKey("dbo.NhanVien", t => t.NhanVienID)
                .ForeignKey("dbo.TinhTrang", t => t.TinhTrangID)
                .Index(t => t.MaPhieuMuon, unique: true)
                .Index(t => t.DocGiaID)
                .Index(t => t.NhanVienID)
                .Index(t => t.TinhTrangID);
            
            CreateTable(
                "dbo.DocGia",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MaThe = c.String(nullable: false, maxLength: 100),
                        Ten = c.String(nullable: false, maxLength: 255),
                        DiaChi = c.String(nullable: false, maxLength: 255),
                        Email = c.String(nullable: false, maxLength: 255),
                        DienThoai = c.String(nullable: false, maxLength: 11),
                        NgayCapThe = c.DateTime(nullable: false),
                        NgayHetHan = c.DateTime(nullable: false),
                        NamTotNghiep = c.Int(nullable: false),
                        Loai = c.Byte(nullable: false),
                        SoSachConLai = c.Int(nullable: false),
                        TinhTrangID = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TinhTrang", t => t.TinhTrangID)
                .Index(t => t.MaThe, unique: true)
                .Index(t => t.TinhTrangID);
            
            CreateTable(
                "dbo.NhanVien",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MaNhanVien = c.String(nullable: false, maxLength: 100),
                        Ten = c.String(nullable: false, maxLength: 255),
                        DiaChi = c.String(nullable: false, maxLength: 255),
                        Email = c.String(nullable: false, maxLength: 255),
                        DienThoai = c.String(nullable: false, maxLength: 11),
                        TinhTrangID = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TinhTrang", t => t.TinhTrangID)
                .Index(t => t.MaNhanVien, unique: true)
                .Index(t => t.TinhTrangID);
            
            CreateTable(
                "dbo.ChiTietTra",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PhieuTraID = c.Int(nullable: false),
                        CuonSachID = c.Int(nullable: false),
                        TinhTrangID = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CuonSach", t => t.CuonSachID)
                .ForeignKey("dbo.PhieuTra", t => t.PhieuTraID)
                .ForeignKey("dbo.TinhTrang", t => t.TinhTrangID)
                .Index(t => t.PhieuTraID)
                .Index(t => t.CuonSachID)
                .Index(t => t.TinhTrangID);
            
            CreateTable(
                "dbo.PhieuTra",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MaPhieuTra = c.String(nullable: false, maxLength: 100),
                        PhieuMuonID = c.Int(nullable: false),
                        NgayTra = c.DateTime(nullable: false),
                        DocGiaID = c.Int(nullable: false),
                        TinhTrangID = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.DocGia", t => t.DocGiaID)
                .ForeignKey("dbo.PhieuMuon", t => t.PhieuMuonID)
                .ForeignKey("dbo.TinhTrang", t => t.TinhTrangID)
                .Index(t => t.MaPhieuTra, unique: true)
                .Index(t => t.PhieuMuonID)
                .Index(t => t.DocGiaID)
                .Index(t => t.TinhTrangID);
            
            CreateTable(
                "dbo.DangKy",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DocGiaID = c.Int(nullable: false),
                        DauSachID = c.Int(nullable: false),
                        NgayDangKy = c.DateTime(nullable: false),
                        TinhTrangID = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.DauSach", t => t.DauSachID)
                .ForeignKey("dbo.DocGia", t => t.DocGiaID)
                .ForeignKey("dbo.TinhTrang", t => t.TinhTrangID)
                .Index(t => t.DocGiaID)
                .Index(t => t.DauSachID)
                .Index(t => t.TinhTrangID);
            
            AddColumn("dbo.DauSach", "Ten", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.DauSach", "TomTat", c => c.String(maxLength: 2000));
            AddColumn("dbo.DauSach", "TaiBan", c => c.Int(nullable: false));
            AddColumn("dbo.DauSach", "NhaSanXuatID", c => c.Int(nullable: false));
            AddColumn("dbo.DauSach", "SoLuongTong", c => c.Int(nullable: false));
            AddColumn("dbo.DauSach", "SoLuongTon", c => c.Int(nullable: false));
            AddColumn("dbo.DauSach", "TinhTrangID", c => c.Byte(nullable: false));
            AddColumn("dbo.TacGia", "Ten", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.TheLoai", "Ten", c => c.String(nullable: false, maxLength: 255));
            CreateIndex("dbo.DauSach", "TheLoaiID");
            CreateIndex("dbo.DauSach", "TacGiaID");
            CreateIndex("dbo.DauSach", "NhaSanXuatID");
            CreateIndex("dbo.DauSach", "TinhTrangID");
            AddForeignKey("dbo.DauSach", "NhaSanXuatID", "dbo.NhaSanXuat", "ID");
            AddForeignKey("dbo.DauSach", "TinhTrangID", "dbo.TinhTrang", "ID");
            AddForeignKey("dbo.DauSach", "TacGiaID", "dbo.TacGia", "ID");
            AddForeignKey("dbo.DauSach", "TheLoaiID", "dbo.TheLoai", "ID");
            DropColumn("dbo.DauSach", "ten_dau_sach");
            DropColumn("dbo.DauSach", "tom_tat");
            DropColumn("dbo.DauSach", "tai_ban");
            DropColumn("dbo.DauSach", "id_nha_san_xuat");
            DropColumn("dbo.DauSach", "so_luong_tong");
            DropColumn("dbo.DauSach", "so_luong_ton");
            DropColumn("dbo.DauSach", "trang_thai");
            DropColumn("dbo.TacGia", "ten_tac_gia");
            DropColumn("dbo.TheLoai", "ten_the_loai");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TheLoai", "ten_the_loai", c => c.String(nullable: false));
            AddColumn("dbo.TacGia", "ten_tac_gia", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.DauSach", "trang_thai", c => c.Byte(nullable: false));
            AddColumn("dbo.DauSach", "so_luong_ton", c => c.Int(nullable: false));
            AddColumn("dbo.DauSach", "so_luong_tong", c => c.Int(nullable: false));
            AddColumn("dbo.DauSach", "id_nha_san_xuat", c => c.Int(nullable: false));
            AddColumn("dbo.DauSach", "tai_ban", c => c.Int(nullable: false));
            AddColumn("dbo.DauSach", "tom_tat", c => c.String(maxLength: 2000));
            AddColumn("dbo.DauSach", "ten_dau_sach", c => c.String(nullable: false, maxLength: 255));
            DropForeignKey("dbo.DauSach", "TheLoaiID", "dbo.TheLoai");
            DropForeignKey("dbo.DauSach", "TacGiaID", "dbo.TacGia");
            DropForeignKey("dbo.DangKy", "TinhTrangID", "dbo.TinhTrang");
            DropForeignKey("dbo.DangKy", "DocGiaID", "dbo.DocGia");
            DropForeignKey("dbo.DangKy", "DauSachID", "dbo.DauSach");
            DropForeignKey("dbo.ChiTietTra", "TinhTrangID", "dbo.TinhTrang");
            DropForeignKey("dbo.ChiTietTra", "PhieuTraID", "dbo.PhieuTra");
            DropForeignKey("dbo.PhieuTra", "TinhTrangID", "dbo.TinhTrang");
            DropForeignKey("dbo.PhieuTra", "PhieuMuonID", "dbo.PhieuMuon");
            DropForeignKey("dbo.PhieuTra", "DocGiaID", "dbo.DocGia");
            DropForeignKey("dbo.ChiTietTra", "CuonSachID", "dbo.CuonSach");
            DropForeignKey("dbo.ChiTietMuon", "TinhTrangID", "dbo.TinhTrang");
            DropForeignKey("dbo.ChiTietMuon", "PhieuMuonID", "dbo.PhieuMuon");
            DropForeignKey("dbo.PhieuMuon", "TinhTrangID", "dbo.TinhTrang");
            DropForeignKey("dbo.PhieuMuon", "NhanVienID", "dbo.NhanVien");
            DropForeignKey("dbo.NhanVien", "TinhTrangID", "dbo.TinhTrang");
            DropForeignKey("dbo.PhieuMuon", "DocGiaID", "dbo.DocGia");
            DropForeignKey("dbo.DocGia", "TinhTrangID", "dbo.TinhTrang");
            DropForeignKey("dbo.ChiTietMuon", "CuonSachID", "dbo.CuonSach");
            DropForeignKey("dbo.CuonSach", "TinhTrangID", "dbo.TinhTrang");
            DropForeignKey("dbo.CuonSach", "DauSachID", "dbo.DauSach");
            DropForeignKey("dbo.DauSach", "TinhTrangID", "dbo.TinhTrang");
            DropForeignKey("dbo.DauSach", "NhaSanXuatID", "dbo.NhaSanXuat");
            DropIndex("dbo.DangKy", new[] { "TinhTrangID" });
            DropIndex("dbo.DangKy", new[] { "DauSachID" });
            DropIndex("dbo.DangKy", new[] { "DocGiaID" });
            DropIndex("dbo.PhieuTra", new[] { "TinhTrangID" });
            DropIndex("dbo.PhieuTra", new[] { "DocGiaID" });
            DropIndex("dbo.PhieuTra", new[] { "PhieuMuonID" });
            DropIndex("dbo.PhieuTra", new[] { "MaPhieuTra" });
            DropIndex("dbo.ChiTietTra", new[] { "TinhTrangID" });
            DropIndex("dbo.ChiTietTra", new[] { "CuonSachID" });
            DropIndex("dbo.ChiTietTra", new[] { "PhieuTraID" });
            DropIndex("dbo.NhanVien", new[] { "TinhTrangID" });
            DropIndex("dbo.NhanVien", new[] { "MaNhanVien" });
            DropIndex("dbo.DocGia", new[] { "TinhTrangID" });
            DropIndex("dbo.DocGia", new[] { "MaThe" });
            DropIndex("dbo.PhieuMuon", new[] { "TinhTrangID" });
            DropIndex("dbo.PhieuMuon", new[] { "NhanVienID" });
            DropIndex("dbo.PhieuMuon", new[] { "DocGiaID" });
            DropIndex("dbo.PhieuMuon", new[] { "MaPhieuMuon" });
            DropIndex("dbo.DauSach", new[] { "TinhTrangID" });
            DropIndex("dbo.DauSach", new[] { "NhaSanXuatID" });
            DropIndex("dbo.DauSach", new[] { "TacGiaID" });
            DropIndex("dbo.DauSach", new[] { "TheLoaiID" });
            DropIndex("dbo.CuonSach", new[] { "TinhTrangID" });
            DropIndex("dbo.CuonSach", new[] { "DauSachID" });
            DropIndex("dbo.CuonSach", new[] { "MaVach" });
            DropIndex("dbo.ChiTietMuon", new[] { "TinhTrangID" });
            DropIndex("dbo.ChiTietMuon", new[] { "CuonSachID" });
            DropIndex("dbo.ChiTietMuon", new[] { "PhieuMuonID" });
            DropColumn("dbo.TheLoai", "Ten");
            DropColumn("dbo.TacGia", "Ten");
            DropColumn("dbo.DauSach", "TinhTrangID");
            DropColumn("dbo.DauSach", "SoLuongTon");
            DropColumn("dbo.DauSach", "SoLuongTong");
            DropColumn("dbo.DauSach", "NhaSanXuatID");
            DropColumn("dbo.DauSach", "TaiBan");
            DropColumn("dbo.DauSach", "TomTat");
            DropColumn("dbo.DauSach", "Ten");
            DropTable("dbo.DangKy");
            DropTable("dbo.PhieuTra");
            DropTable("dbo.ChiTietTra");
            DropTable("dbo.NhanVien");
            DropTable("dbo.DocGia");
            DropTable("dbo.PhieuMuon");
            DropTable("dbo.TinhTrang");
            DropTable("dbo.NhaSanXuat");
            DropTable("dbo.CuonSach");
            DropTable("dbo.ChiTietMuon");
            CreateIndex("dbo.DauSach", "TacGiaId");
            CreateIndex("dbo.DauSach", "TheLoaiId");
            AddForeignKey("dbo.DauSach", "TheLoaiId", "dbo.TheLoai", "id", cascadeDelete: true);
            AddForeignKey("dbo.DauSach", "TacGiaId", "dbo.TacGia", "id", cascadeDelete: true);
        }
    }
}
