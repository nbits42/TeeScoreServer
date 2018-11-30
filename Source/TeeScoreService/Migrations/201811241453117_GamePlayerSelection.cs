namespace TeeScoreService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GamePlayerSelection : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "PlayerSelection", c => c.Int(nullable: false, defaultValue:0));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "PlayerSelection");
        }
    }
}
