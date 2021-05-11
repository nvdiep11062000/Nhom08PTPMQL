namespace Nhom08PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_DonDatHang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DonDatHangs",
                c => new
                    {
                        TenDDH = c.String(nullable: false, maxLength: 128),
                        GiaTriDDH = c.String(),
                        TinhTrang = c.String(),
                    })
                .PrimaryKey(t => t.TenDDH);
            
            DropColumn("dbo.DonHangs", "Ghichu");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DonHangs", "Ghichu", c => c.String());
            DropTable("dbo.DonDatHangs");
        }
    }
}
