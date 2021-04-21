namespace Nhom08PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Describe : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Describes",
                c => new
                    {
                        NameDescribe = c.String(nullable: false, maxLength: 128),
                        ContentDescribe = c.String(),
                    })
                .PrimaryKey(t => t.NameDescribe);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Describes");
        }
    }
}
