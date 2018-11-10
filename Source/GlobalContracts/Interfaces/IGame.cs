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
        string VenueId { get; set; }
    }
}