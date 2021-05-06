namespace VideoKlub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ZanrDodavanje : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Akcija')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Komedija')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Triler')");
        }
        
        public override void Down()
        {
        }
    }
}
