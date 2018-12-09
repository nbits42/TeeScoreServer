using GlobalContracts.Enumerations;

namespace GlobalContracts.Interfaces
{
    public interface IGamePlayer: IEntityData
    {
        string GameId { get; set; }
        string PlayerId { get; set; }
        PlayerRole PlayerRole { get; set; }
        bool Hide { get; set; }
    }
}