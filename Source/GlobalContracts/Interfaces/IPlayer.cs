namespace GlobalContracts.Interfaces
{
    public interface IPlayer: IEntityData
    {
        string Abbreviation { get; set; }
        string AvatarUrl { get; set; }
        string ImageUrl { get; set; }
        string Name { get; set; }
    }
}