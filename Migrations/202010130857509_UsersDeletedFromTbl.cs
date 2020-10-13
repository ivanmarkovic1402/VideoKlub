namespace VideoKlub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UsersDeletedFromTbl : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Rentals", "Users_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Rentals", new[] { "Users_Id" });
            DropColumn("dbo.Rentals", "Users_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rentals", "Users_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Rentals", "Users_Id");
            AddForeignKey("dbo.Rentals", "Users_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
