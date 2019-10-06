namespace rc907613_mis4200.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendees",
                c => new
                    {
                        attendeeID = c.Int(nullable: false, identity: true),
                        firstName = c.String(),
                        lastName = c.String(),
                        address = c.String(),
                        city = c.String(),
                        state = c.String(),
                        zip = c.String(),
                        email = c.String(),
                        phone = c.String(),
                    })
                .PrimaryKey(t => t.attendeeID);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        eventID = c.Int(nullable: false, identity: true),
                        attendeeID = c.Int(nullable: false),
                        ticketID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.eventID)
                .ForeignKey("dbo.Attendees", t => t.attendeeID, cascadeDelete: true)
                .ForeignKey("dbo.Tickets", t => t.ticketID, cascadeDelete: true)
                .Index(t => t.attendeeID)
                .Index(t => t.ticketID);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        ticketID = c.Int(nullable: false, identity: true),
                        eventName = c.String(),
                        eventLocation = c.String(),
                        eventDate = c.DateTime(nullable: false),
                        eventDuration = c.String(),
                        eventCost = c.String(),
                    })
                .PrimaryKey(t => t.ticketID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "ticketID", "dbo.Tickets");
            DropForeignKey("dbo.Events", "attendeeID", "dbo.Attendees");
            DropIndex("dbo.Events", new[] { "ticketID" });
            DropIndex("dbo.Events", new[] { "attendeeID" });
            DropTable("dbo.Tickets");
            DropTable("dbo.Events");
            DropTable("dbo.Attendees");
        }
    }
}
