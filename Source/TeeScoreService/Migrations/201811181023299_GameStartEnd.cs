namespace TeeScoreService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GameStartEnd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "StartTee", c => c.Int(nullable: false, defaultValue:1));
            AddColumn("dbo.Games", "CurrentTee", c => c.Int(nullable: false, defaultValue:1));
            AddColumn("dbo.Games", "StartedAt", c => c.DateTime(nullable: true));
            AddColumn("dbo.Games", "FinishedAt", c => c.DateTime(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "FinishedAt");
            DropColumn("dbo.Games", "StartedAt");
            DropColumn("dbo.Games", "CurrentTee");
            DropColumn("dbo.Games", "StartTee");
        }
    }
}
