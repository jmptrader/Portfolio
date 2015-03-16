namespace Portfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class typefix : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Projects", "Type", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Projects", "Type", c => c.Int(nullable: false));
        }
    }
}
