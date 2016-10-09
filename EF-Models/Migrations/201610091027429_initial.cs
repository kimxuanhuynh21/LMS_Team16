namespace EF_Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DauSach",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Ten = c.String(),
                        TheLoai_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TheLoai", t => t.TheLoai_ID)
                .Index(t => t.TheLoai_ID);
            
            CreateTable(
                "dbo.TheLoai",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Ten = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DauSach", "TheLoai_ID", "dbo.TheLoai");
            DropIndex("dbo.DauSach", new[] { "TheLoai_ID" });
            DropTable("dbo.TheLoai");
            DropTable("dbo.DauSach");
        }
    }
}
