using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using GlobalContracts.Interfaces;
using Microsoft.Azure.Mobile.Server;

namespace TeeScoreService.DataObjects
{
    public class Tee : EntityData, ITee
    {
        public string GameId { get; set; }
        public string Number { get; set; }
        public DateTime Started { get; set; }
        public DateTime Finished { get; set; }

        [ForeignKey(nameof(GameId))]
        public Game Game { get; set; }
    }
}