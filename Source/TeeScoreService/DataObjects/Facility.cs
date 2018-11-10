using System;
using GlobalContracts.Enumerations;
using GlobalContracts.Interfaces;
using Microsoft.Azure.Mobile.Server;

namespace TeeScoreService.DataObjects
{
    public class Facility : EntityData, IFacility
    {
        public string Description { get; set; }
        public FacilityType FacilityType { get; set; }
    }
}