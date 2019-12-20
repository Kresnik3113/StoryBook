namespace StoryBook.Migrations.SB
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "EventDescription", c => c.String());
            AlterColumn("dbo.Characters", "DOB", c => c.String());
            AlterColumn("dbo.Events", "EventDate", c => c.String());
            DropColumn("dbo.Events", "EventDescribtion");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Events", "EventDescribtion", c => c.String());
            AlterColumn("dbo.Events", "EventDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Characters", "DOB", c => c.DateTime(nullable: false));
            DropColumn("dbo.Events", "EventDescription");
        }
    }
}
