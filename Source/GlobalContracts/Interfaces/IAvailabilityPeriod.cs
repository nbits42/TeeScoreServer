using System;

namespace GlobalContracts.Interfaces
{
    public interface IAvailabilityPeriod: IEntityData
    {
        string Name { get; set; }
        DateTime OpenFrom { get; set; }
        DateTime OpenUntil { get; set; }
    }
}