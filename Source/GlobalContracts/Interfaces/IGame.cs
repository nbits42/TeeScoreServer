using System;
using GlobalContracts.Enumerations;

namespace GlobalContracts.Interfaces
{
    public interface IGame: IEntityData
    {
        int ConnectedPlayersCount { get; set; }
        DateTime Date { get; set; }
        GameStatus GameStatus { get; set; }
        GameType GameType { get; set; }
        int InvitationNumber { get; set; }
        int InvitedPlayersCount { get; set; }
        int TeeCount { get; set; }
        int StartTee { get; set; }
        int CurrentTee { get; set; }
        DateTime? StartedAt { get; set; }
        DateTime? FinishedAt { get; set; }
        string VenueId { get; set; }
    }
}