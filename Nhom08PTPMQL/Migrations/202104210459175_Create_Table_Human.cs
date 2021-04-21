namespace Nhom08PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Human : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Humans",
                c => new
                    {
                        NameHuman = c.String(nullable: false, maxLength: 128),
                        PositionHuman = c.String(),
                        IDhuman = c.Int(nullable: false),
                        PhoneNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.NameHuman);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Humans");
        }
    }
}
