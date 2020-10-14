namespace VideoKlub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class movieModelChanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Movies", "UserId");
            AddForeignKey("dbo.Movies", "UserId", "dbo.AspNetUsers", "Id");
            DropColumn("dbo.Movies", "AddedByUser");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "AddedByUser", c => c.String());
            DropForeignKey("dbo.Movies", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Movies", new[] { "UserId" });
            DropColumn("dbo.Movies", "UserId");
        }
    }
}
