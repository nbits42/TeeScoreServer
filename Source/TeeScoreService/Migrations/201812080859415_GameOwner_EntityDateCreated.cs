namespace TeeScoreService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GameOwner_EntityDateCreated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "GameDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Venues", "OwnerId", c => c.String());
            AlterColumn("dbo.Games", "StartedAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Games", "FinishedAt", c => c.DateTime(nullable: false));
            DropColumn("dbo.Games", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Games", "Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Games", "FinishedAt", c => c.DateTime());
            AlterColumn("dbo.Games", "StartedAt", c => c.DateTime());
            DropColumn("dbo.Venues", "OwnerId");
            DropColumn("dbo.Games", "GameDate");
        }
    }
}
