namespace GlobalContracts.Interfaces
{
    public interface IVenueAvailabilityPeriod: IEntityData
    {
        string AvailabilityPeriodId { get; set; }
        string VenueId { get; set; }
    }
}