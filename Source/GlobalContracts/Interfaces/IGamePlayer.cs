namespace GlobalContracts.Interfaces
{
    public interface IGamePlayer: IEntityData
    {
        string GameId { get; set; }
        string PlayerId { get; set; }
    }
}