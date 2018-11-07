using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Azure.Mobile.Server;

namespace TeeScoreService.DataObjects
{
    public class GamePlayer: EntityData
    {
        public string GameId { get; set; }
        public string PlayerId { get; set; }

        [ForeignKey(nameof(GameId))]
        public Game Game { get; set; }
        [ForeignKey(nameof(PlayerId))]
        public Player Player { get; set; }
    }
}