namespace TeeScoreService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ScoreRenameTeeId : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Scores", name: "HoleId", newName: "TeeId");
            RenameIndex(table: "dbo.Scores", name: "IX_HoleId", newName: "IX_TeeId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Scores", name: "IX_TeeId", newName: "IX_HoleId");
            RenameColumn(table: "dbo.Scores", name: "TeeId", newName: "HoleId");
        }
    }
}
