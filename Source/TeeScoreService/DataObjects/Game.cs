using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using GlobalContracts.Enumerations;
using GlobalContracts.Interfaces;
using Microsoft.Azure.Mobile.Server;



namespace TeeScoreService.DataObjects
{
    public class Game : EntityData, IGame
    {
        public DateTime Date { get; set; }
        public GameStatus GameStatus { get; set; }
        public GameType GameType { get; set; }
        public int InvitedPlayersCount { get; set; }
        public int ConnectedPlayersCount { get; set; }
        public int TeeCount { get; set; }
        public int StartTee { get; set; }
        public int CurrentTee { get; set; }
        public DateTime? StartedAt { get; set; }
        public DateTime? FinishedAt { get; set; }
        public string VenueId { get; set; }
        public PlayerSelection PlayerSelection { get; set; }
        public int InvitationNumber { get; set; }

        [ForeignKey("VenueId")]
        public Venue Venue { get; set; }
    }

    
}