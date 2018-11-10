using GlobalContracts.Enumerations;

namespace GlobalContracts.Interfaces
{
    public interface IFacility: IEntityData
    {
        string Description { get; set; }
        FacilityType FacilityType { get; set; }
    }
}