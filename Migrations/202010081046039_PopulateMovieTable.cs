namespace VideoKlub.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateMovieTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, NumberInStock, NumberAvailable, DateAdded, GenreId) VALUES ('DieHard', 17, 11, '08-10-2020', 1) ");
            Sql("INSERT INTO Movies (Name, NumberInStock, NumberAvailable, DateAdded, GenreId) VALUES ('Hangover', 27, 10, '08-10-2020', 2) ");
            Sql("INSERT INTO Movies (Name, NumberInStock, NumberAvailable, DateAdded, GenreId) VALUES ('Contatiempo', 7, 6, '08-10-2020', 3) ");

        }

        public override void Down()
        {
        }
    }
}
