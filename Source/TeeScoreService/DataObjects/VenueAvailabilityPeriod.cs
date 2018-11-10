using System.ComponentModel.DataAnnotations.Schema;
using GlobalContracts.Interfaces;
using Microsoft.Azure.Mobile.Server;

namespace TeeScoreService.DataObjects
{
    public class VenueAvailabilityPeriod : EntityData, IVenueAvailabilityPeriod
    {
        public string VenueId { get; set; }
        public string AvailabilityPeriodId { get; set; }

        [ForeignKey(nameof(VenueId))]
        public Venue Venue { get; set; }

        [ForeignKey(nameof(AvailabilityPeriodId))]
        public AvailabilityPeriod AvailabilityPeriod { get; set; }
    }
}