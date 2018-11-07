using System;
using Microsoft.Azure.Mobile.Server;
using TeeScoreService.Contracts;

namespace TeeScoreService.DataObjects
{
    public class Facility: EntityData
    {
        public string Description { get; set; }
        public DateTime OpenFromTime { get; set; }
        public DateTime ClosedAtTime { get; set; }
        public DateTime OpenFromDate { get; set; }
        public DateTime ClosedFromDate { get; set; }
        public bool OpenOnMonday { get; set; }
        public bool OpenOnTuesday { get; set; }
        public bool OpenOnWednesdayy { get; set; }
        public bool OpenOnThursday{ get; set; }
        public bool OpenOnFriday { get; set; }
        public bool OpenOnSaturday { get; set; }
        public bool OpenOnSunday { get; set; }
        public FacilityType FacilityType { get; set; }
    }
}