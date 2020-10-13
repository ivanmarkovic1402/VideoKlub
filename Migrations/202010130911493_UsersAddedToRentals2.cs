namespace VideoKlub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UsersAddedToRentals2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rentals", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Rentals", "UserId");
            AddForeignKey("dbo.Rentals", "UserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rentals", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Rentals", new[] { "UserId" });
            AlterColumn("dbo.Rentals", "UserId", c => c.String());
        }
    }
}
