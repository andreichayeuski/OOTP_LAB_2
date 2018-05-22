namespace Lab8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OMFG : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Books");
            AlterColumn("dbo.Books", "bookID", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Books", "bookID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Books");
            AlterColumn("dbo.Books", "bookID", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Books", "bookID");
        }
    }
}
