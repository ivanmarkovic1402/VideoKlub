namespace VideoKlub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedByUseraddedToMovieModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "AddedByUser", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "AddedByUser");
        }
    }
}
