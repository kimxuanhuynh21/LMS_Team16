namespace EF_Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_dausach : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DauSach", "TT_Xoa", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DauSach", "TT_Xoa");
        }
    }
}
