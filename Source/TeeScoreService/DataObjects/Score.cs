using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Configuration;
using GlobalContracts.Interfaces;
using Microsoft.Azure.Mobile.Server;

namespace TeeScoreService.DataObjects
{
    public class Score : EntityData,  IScore
    {
        public string GameId { get; set; }
        public string TeeId { get; set; }
        public string PlayerId { get; set; }
        public int Putts { get; set; }

        [ForeignKey(nameof(TeeId))]
        public Tee Tee { get; set; }
        [ForeignKey(nameof(PlayerId))]
        public Player Player { get; set; }
        [ForeignKey(nameof(GameId))]
        public Game Game { get; set; }
    }
}