namespace iCantina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUniqueIndexToUsername : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Username", c => c.String(maxLength: 450));
            Sql("CREATE UNIQUE INDEX IX_Unique_Username ON dbo.Users (Username) WHERE Username IS NOT NULL");
        }

        public override void Down()
        {
            Sql("DROP INDEX IX_Unique_Username ON dbo.Users");
        }
    }
}
