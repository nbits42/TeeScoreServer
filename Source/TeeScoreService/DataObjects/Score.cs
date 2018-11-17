using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Configuration;
using GlobalContracts.Interfaces;

namespace TeeScoreService.DataObjects
{
    public class Score : IScore
    {
        public string HoleId { get; set; }
        public string PlayerId { get; set; }
        public int Putts { get; set; }

        [ForeignKey(nameof(HoleId))]
        public Hole Hole { get; set; }
        [ForeignKey(nameof(PlayerId))]
        public Player Player { get; set; }

    }
}