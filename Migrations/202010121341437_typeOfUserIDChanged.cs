namespace VideoKlub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class typeOfUserIDChanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rentals", "UserId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rentals", "UserId", c => c.Int(nullable: false));
        }
    }
}
