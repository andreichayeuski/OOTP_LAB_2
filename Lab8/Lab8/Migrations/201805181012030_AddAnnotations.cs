namespace Lab8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAnnotations : DbMigration
    {

        public override void Up()
        {
            AlterColumn("dbo.Books", "title", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Books", "author", c => c.String(maxLength: 50));
        }

        public override void Down()
        {
            AlterColumn("dbo.Books", "author", c => c.String());
            AlterColumn("dbo.Books", "title", c => c.String());
        }
    }
}
