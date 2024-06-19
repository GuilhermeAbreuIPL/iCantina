namespace iCantina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUniqueConstraintOnNumEstudante : DbMigration
    {
        public override void Up()
        {
            // Create unique index on NumEstudante where it is not null
            Sql("CREATE UNIQUE INDEX IX_Unique_NumEstudante ON dbo.Users (NumEstudante) WHERE NumEstudante IS NOT NULL");
        }

        public override void Down()
        {
            // Drop the unique index if rolling back
            Sql("DROP INDEX IX_Unique_NumEstudante ON dbo.Users");
        }
    }
}
