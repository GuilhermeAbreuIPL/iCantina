namespace iCantina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Nif = c.Int(nullable: false),
                        Saldo = c.Decimal(precision: 18, scale: 2),
                        Email = c.String(),
                        NumEstudante = c.Int(),
                        Username = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Nif, unique: true)
                .Index(t => t.NumEstudante, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "NumEstudante" });
            DropIndex("dbo.Users", new[] { "Nif" });
            DropTable("dbo.Users");
        }
    }
}
