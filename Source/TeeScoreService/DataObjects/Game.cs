﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Microsoft.Azure.Mobile.Server;
using TeeScoreService.Contracts;

namespace TeeScoreService.DataObjects
{
    public class Game: EntityData
    {
        public DateTime Date { get; set; }
        public GameStatus GameStatus { get; set; }
        public GameType GameType { get; set; }
        public int InvitedPlayersCount { get; set; }
        public int ConnectedPlayersCount { get; set; }
        public int TeeCount { get; set; }
        public string VenueId { get; set; }
        public int InvitationNumber { get; set; }

        [ForeignKey("VenueId")]
        public Venue Venue { get; set; }
    }
}