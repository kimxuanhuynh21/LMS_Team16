namespace EF_Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editDocGia : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DocGia", "HinhAnh", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DocGia", "HinhAnh");
        }
    }
}
