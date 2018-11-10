using System;
using GlobalContracts.Enumerations;

namespace GlobalContracts.Interfaces
{
    public interface IAvailability: IEntityData
    {
        DateTime ClosingAt { get; set; }
        DateTime OpemFrom { get; set; }
        WeekDay WeekDay { get; set; }
    }
}