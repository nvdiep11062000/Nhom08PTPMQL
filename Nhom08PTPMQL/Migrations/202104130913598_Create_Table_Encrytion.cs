namespace Nhom08PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Encrytion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Encrytions",
                c => new
                    {
                        ktdn = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ktdn);
            
            AlterColumn("dbo.Accounts", "Password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Accounts", "Password", c => c.String());
            DropTable("dbo.Encrytions");
        }
    }
}
