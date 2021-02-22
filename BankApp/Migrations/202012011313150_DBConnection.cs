namespace BankApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBConnection : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "balanse", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "balanse", c => c.String());
        }
    }
}
