namespace GlobalContracts.Interfaces
{
    public interface IVenueFacilities: IEntityData
    {
        string FacilityId { get; set; }
        string VenueId { get; set; }
    }
}