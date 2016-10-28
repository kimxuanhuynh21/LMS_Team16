namespace EF_Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class versionfinal15Oct2016 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChiTietMuon",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PhieuMuonID = c.Int(nullable: false),
                        CuonSachID = c.Int(nullable: false),
                        TinhTrang = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CuonSach", t => t.CuonSachID)
                .ForeignKey("dbo.PhieuMuon", t => t.PhieuMuonID)
                .Index(t => t.PhieuMuonID)
                .Index(t => t.CuonSachID);
            
            CreateTable(
                "dbo.CuonSach",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MaVach = c.String(nullable: false, maxLength: 100),
                        DauSachID = c.Int(nullable: false),
                        TinhTrang = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.DauSach", t => t.DauSachID)
                .Index(t => t.MaVach, unique: true)
                .Index(t => t.DauSachID);
            
            CreateTable(
                "dbo.DauSach",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Ten = c.String(nullable: false, maxLength: 255),
                        TheLoaiID = c.Int(nullable: false),
                        TacGiaID = c.Int(nullable: false),
                        TomTat = c.String(maxLength: 2000),
                        TaiBan = c.Int(nullable: false),
                        NhaSanXuatID = c.Int(nullable: false),
                        SoLuongTong = c.Int(nullable: false),
                        SoLuongTon = c.Int(nullable: false),
                        TinhTrang = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.NhaSanXuat", t => t.NhaSanXuatID)
                .ForeignKey("dbo.TacGia", t => t.TacGiaID)
                .ForeignKey("dbo.TheLoai", t => t.TheLoaiID)
                .Index(t => t.TheLoaiID)
                .Index(t => t.TacGiaID)
                .Index(t => t.NhaSanXuatID);
            
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
                "dbo.TacGia",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Ten = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TheLoai",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MaTheLoai = c.String(nullable: false, maxLength: 100),
                        Ten = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.MaTheLoai, unique: true);
            
            CreateTable(
                "dbo.PhieuMuon",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MaPhieuMuon = c.String(nullable: false, maxLength: 100),
                        NgayMuon = c.DateTime(nullable: false),
                        DocGiaID = c.Int(nullable: false),
                        NhanVienID = c.Int(nullable: false),
                        NgayHetHan = c.DateTime(nullable: false),
                        TongSoLuongMuon = c.Int(nullable: false),
                        SoLuongTra = c.Int(nullable: false),
                        TinhTrang = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.DocGia", t => t.DocGiaID)
                .ForeignKey("dbo.NhanVien", t => t.NhanVienID)
                .Index(t => t.MaPhieuMuon, unique: true)
                .Index(t => t.DocGiaID)
                .Index(t => t.NhanVienID);
            
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
                        TinhTrang = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.MaThe, unique: true);
            
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
                        TinhTrang = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.MaNhanVien, unique: true);
            
            CreateTable(
                "dbo.ChiTietTra",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PhieuTraID = c.Int(nullable: false),
                        CuonSachID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CuonSach", t => t.CuonSachID)
                .ForeignKey("dbo.PhieuTra", t => t.PhieuTraID)
                .Index(t => t.PhieuTraID)
                .Index(t => t.CuonSachID);
            
            CreateTable(
                "dbo.PhieuTra",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MaPhieuTra = c.String(nullable: false, maxLength: 100),
                        PhieuMuonID = c.Int(nullable: false),
                        NgayTra = c.DateTime(nullable: false),
                        DocGiaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.DocGia", t => t.DocGiaID)
                .ForeignKey("dbo.PhieuMuon", t => t.PhieuMuonID)
                .Index(t => t.MaPhieuTra, unique: true)
                .Index(t => t.PhieuMuonID)
                .Index(t => t.DocGiaID);
            
            CreateTable(
                "dbo.DangKy",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DocGiaID = c.Int(nullable: false),
                        DauSachID = c.Int(nullable: false),
                        NgayDangKy = c.DateTime(nullable: false),
                        TinhTrang = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.DauSach", t => t.DauSachID)
                .ForeignKey("dbo.DocGia", t => t.DocGiaID)
                .Index(t => t.DocGiaID, unique: true)
                .Index(t => t.DauSachID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DangKy", "DocGiaID", "dbo.DocGia");
            DropForeignKey("dbo.DangKy", "DauSachID", "dbo.DauSach");
            DropForeignKey("dbo.ChiTietTra", "PhieuTraID", "dbo.PhieuTra");
            DropForeignKey("dbo.PhieuTra", "PhieuMuonID", "dbo.PhieuMuon");
            DropForeignKey("dbo.PhieuTra", "DocGiaID", "dbo.DocGia");
            DropForeignKey("dbo.ChiTietTra", "CuonSachID", "dbo.CuonSach");
            DropForeignKey("dbo.ChiTietMuon", "PhieuMuonID", "dbo.PhieuMuon");
            DropForeignKey("dbo.PhieuMuon", "NhanVienID", "dbo.NhanVien");
            DropForeignKey("dbo.PhieuMuon", "DocGiaID", "dbo.DocGia");
            DropForeignKey("dbo.ChiTietMuon", "CuonSachID", "dbo.CuonSach");
            DropForeignKey("dbo.CuonSach", "DauSachID", "dbo.DauSach");
            DropForeignKey("dbo.DauSach", "TheLoaiID", "dbo.TheLoai");
            DropForeignKey("dbo.DauSach", "TacGiaID", "dbo.TacGia");
            DropForeignKey("dbo.DauSach", "NhaSanXuatID", "dbo.NhaSanXuat");
            DropIndex("dbo.DangKy", new[] { "DauSachID" });
            DropIndex("dbo.DangKy", new[] { "DocGiaID" });
            DropIndex("dbo.PhieuTra", new[] { "DocGiaID" });
            DropIndex("dbo.PhieuTra", new[] { "PhieuMuonID" });
            DropIndex("dbo.PhieuTra", new[] { "MaPhieuTra" });
            DropIndex("dbo.ChiTietTra", new[] { "CuonSachID" });
            DropIndex("dbo.ChiTietTra", new[] { "PhieuTraID" });
            DropIndex("dbo.NhanVien", new[] { "MaNhanVien" });
            DropIndex("dbo.DocGia", new[] { "MaThe" });
            DropIndex("dbo.PhieuMuon", new[] { "NhanVienID" });
            DropIndex("dbo.PhieuMuon", new[] { "DocGiaID" });
            DropIndex("dbo.PhieuMuon", new[] { "MaPhieuMuon" });
            DropIndex("dbo.TheLoai", new[] { "MaTheLoai" });
            DropIndex("dbo.DauSach", new[] { "NhaSanXuatID" });
            DropIndex("dbo.DauSach", new[] { "TacGiaID" });
            DropIndex("dbo.DauSach", new[] { "TheLoaiID" });
            DropIndex("dbo.CuonSach", new[] { "DauSachID" });
            DropIndex("dbo.CuonSach", new[] { "MaVach" });
            DropIndex("dbo.ChiTietMuon", new[] { "CuonSachID" });
            DropIndex("dbo.ChiTietMuon", new[] { "PhieuMuonID" });
            DropTable("dbo.DangKy");
            DropTable("dbo.PhieuTra");
            DropTable("dbo.ChiTietTra");
            DropTable("dbo.NhanVien");
            DropTable("dbo.DocGia");
            DropTable("dbo.PhieuMuon");
            DropTable("dbo.TheLoai");
            DropTable("dbo.TacGia");
            DropTable("dbo.NhaSanXuat");
            DropTable("dbo.DauSach");
            DropTable("dbo.CuonSach");
            DropTable("dbo.ChiTietMuon");
        }
    }
}
