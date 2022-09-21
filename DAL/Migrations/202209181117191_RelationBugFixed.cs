namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelationBugFixed : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Buses", "BusActionPlan_BusActionPlanID", "dbo.BusActionPlans");
            DropForeignKey("dbo.Routes", "BusActionPlan_BusActionPlanID", "dbo.BusActionPlans");
            DropIndex("dbo.Buses", new[] { "BusActionPlan_BusActionPlanID" });
            DropIndex("dbo.Routes", new[] { "BusActionPlan_BusActionPlanID" });
            AddColumn("dbo.BusActionPlans", "Bus_BusID", c => c.Int());
            AddColumn("dbo.BusActionPlans", "Route_RouteID", c => c.Int());
            CreateIndex("dbo.BusActionPlans", "Bus_BusID");
            CreateIndex("dbo.BusActionPlans", "Route_RouteID");
            AddForeignKey("dbo.BusActionPlans", "Bus_BusID", "dbo.Buses", "BusID");
            AddForeignKey("dbo.BusActionPlans", "Route_RouteID", "dbo.Routes", "RouteID");
            DropColumn("dbo.Buses", "BusActionPlan_BusActionPlanID");
            DropColumn("dbo.Routes", "BusActionPlan_BusActionPlanID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Routes", "BusActionPlan_BusActionPlanID", c => c.Int());
            AddColumn("dbo.Buses", "BusActionPlan_BusActionPlanID", c => c.Int());
            DropForeignKey("dbo.BusActionPlans", "Route_RouteID", "dbo.Routes");
            DropForeignKey("dbo.BusActionPlans", "Bus_BusID", "dbo.Buses");
            DropIndex("dbo.BusActionPlans", new[] { "Route_RouteID" });
            DropIndex("dbo.BusActionPlans", new[] { "Bus_BusID" });
            DropColumn("dbo.BusActionPlans", "Route_RouteID");
            DropColumn("dbo.BusActionPlans", "Bus_BusID");
            CreateIndex("dbo.Routes", "BusActionPlan_BusActionPlanID");
            CreateIndex("dbo.Buses", "BusActionPlan_BusActionPlanID");
            AddForeignKey("dbo.Routes", "BusActionPlan_BusActionPlanID", "dbo.BusActionPlans", "BusActionPlanID");
            AddForeignKey("dbo.Buses", "BusActionPlan_BusActionPlanID", "dbo.BusActionPlans", "BusActionPlanID");
        }
    }
}
