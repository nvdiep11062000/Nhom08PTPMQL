namespace Nhom08PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Item : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        NameItem = c.String(nullable: false, maxLength: 128),
                        IDIteam = c.String(),
                        PriceItem = c.Int(nullable: false),
                        AmountItem = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.NameItem);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Items");
        }
    }
}
