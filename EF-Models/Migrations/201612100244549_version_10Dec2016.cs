namespace EF_Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class version_10Dec2016 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DocGia", "Loai", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DocGia", "Loai", c => c.String(nullable: false));
        }
    }
}
