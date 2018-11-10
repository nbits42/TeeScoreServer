namespace GlobalContracts.Interfaces
{
    public interface IVenue: IEntityData
    {
        string ImageUrl { get; set; }
        double Lat { get; set; }
        string Location { get; set; }
        double Long { get; set; }
        string Name { get; set; }
        string ThumbnailUrl { get; set; }
    }
}