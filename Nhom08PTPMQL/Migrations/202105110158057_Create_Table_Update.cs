namespace Nhom08PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Update : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.DonHangs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.DonHangs",
                c => new
                    {
                        TenDH = c.String(nullable: false, maxLength: 128),
                        GiatriDH = c.String(),
                        TinhtrangDH = c.String(),
                    })
                .PrimaryKey(t => t.TenDH);
            
        }
    }
}
