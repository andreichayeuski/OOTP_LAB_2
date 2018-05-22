namespace Lab8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Books");
            AddColumn("dbo.Books", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Books", "Author", c => c.String(maxLength: 60));
            AddPrimaryKey("dbo.Books", "Id");
            DropColumn("dbo.Books", "bookID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "bookID", c => c.String(nullable: false, maxLength: 128));
            DropPrimaryKey("dbo.Books");
            AlterColumn("dbo.Books", "Author", c => c.String(maxLength: 50));
            DropColumn("dbo.Books", "Id");
            AddPrimaryKey("dbo.Books", "bookID");
        }
    }
}
