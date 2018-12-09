namespace TeeScoreService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GamePlayer_Game : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GamePlayers", "PlayerRole", c => c.Int(nullable: false));
            AddColumn("dbo.GamePlayers", "Hide", c => c.Boolean(nullable: false));
            AddColumn("dbo.Games", "VenueName", c => c.String());
            AddColumn("dbo.Games", "PlayerNames", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "PlayerNames");
            DropColumn("dbo.Games", "VenueName");
            DropColumn("dbo.GamePlayers", "Hide");
            DropColumn("dbo.GamePlayers", "PlayerRole");
        }
    }
}
