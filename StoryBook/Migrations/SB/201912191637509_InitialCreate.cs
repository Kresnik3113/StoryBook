namespace StoryBook.Migrations.SB
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Characters",
                c => new
                    {
                        CharacterId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DOB = c.DateTime(nullable: false),
                        Personalty = c.String(),
                        Apperance = c.String(),
                        Location_LocationId = c.Int(),
                    })
                .PrimaryKey(t => t.CharacterId)
                .ForeignKey("dbo.Locations", t => t.Location_LocationId)
                .Index(t => t.Location_LocationId);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventId = c.Int(nullable: false, identity: true),
                        EventName = c.String(),
                        EventDate = c.DateTime(nullable: false),
                        EventDescribtion = c.String(),
                    })
                .PrimaryKey(t => t.EventId);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ItemId = c.Int(nullable: false, identity: true),
                        ItemName = c.String(),
                        ItemDecsription = c.String(),
                        ItemOwner = c.String(),
                    })
                .PrimaryKey(t => t.ItemId);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        LocationId = c.Int(nullable: false, identity: true),
                        LocationName = c.String(),
                        LocationType = c.String(),
                        LocationDescription = c.String(),
                    })
                .PrimaryKey(t => t.LocationId);
            
            CreateTable(
                "dbo.EventCharacters",
                c => new
                    {
                        Event_EventId = c.Int(nullable: false),
                        Character_CharacterId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Event_EventId, t.Character_CharacterId })
                .ForeignKey("dbo.Events", t => t.Event_EventId, cascadeDelete: true)
                .ForeignKey("dbo.Characters", t => t.Character_CharacterId, cascadeDelete: true)
                .Index(t => t.Event_EventId)
                .Index(t => t.Character_CharacterId);
            
            CreateTable(
                "dbo.ItemEvents",
                c => new
                    {
                        Item_ItemId = c.Int(nullable: false),
                        Event_EventId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Item_ItemId, t.Event_EventId })
                .ForeignKey("dbo.Items", t => t.Item_ItemId, cascadeDelete: true)
                .ForeignKey("dbo.Events", t => t.Event_EventId, cascadeDelete: true)
                .Index(t => t.Item_ItemId)
                .Index(t => t.Event_EventId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Characters", "Location_LocationId", "dbo.Locations");
            DropForeignKey("dbo.ItemEvents", "Event_EventId", "dbo.Events");
            DropForeignKey("dbo.ItemEvents", "Item_ItemId", "dbo.Items");
            DropForeignKey("dbo.EventCharacters", "Character_CharacterId", "dbo.Characters");
            DropForeignKey("dbo.EventCharacters", "Event_EventId", "dbo.Events");
            DropIndex("dbo.ItemEvents", new[] { "Event_EventId" });
            DropIndex("dbo.ItemEvents", new[] { "Item_ItemId" });
            DropIndex("dbo.EventCharacters", new[] { "Character_CharacterId" });
            DropIndex("dbo.EventCharacters", new[] { "Event_EventId" });
            DropIndex("dbo.Characters", new[] { "Location_LocationId" });
            DropTable("dbo.ItemEvents");
            DropTable("dbo.EventCharacters");
            DropTable("dbo.Locations");
            DropTable("dbo.Items");
            DropTable("dbo.Events");
            DropTable("dbo.Characters");
        }
    }
}
