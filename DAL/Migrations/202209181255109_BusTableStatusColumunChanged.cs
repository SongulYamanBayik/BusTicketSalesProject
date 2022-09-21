namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BusTableStatusColumunChanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Buses", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Buses", "Status", c => c.String());
        }
    }
}
