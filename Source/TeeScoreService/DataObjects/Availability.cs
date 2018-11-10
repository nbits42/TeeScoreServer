using Microsoft.Azure.Mobile.Server;
using System;
using GlobalContracts.Interfaces;


namespace TeeScoreService.DataObjects
{
    public class Availability : EntityData, IAvailability
    {
        public GlobalContracts.Enumerations.WeekDay WeekDay { get; set; }
        public DateTime OpemFrom { get; set; }
        public DateTime ClosingAt { get; set; }
    }
}