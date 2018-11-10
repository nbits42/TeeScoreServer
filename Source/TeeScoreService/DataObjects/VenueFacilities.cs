using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using GlobalContracts.Interfaces;
using Microsoft.Azure.Mobile.Server;

namespace TeeScoreService.DataObjects
{
    public class VenueFacilities : EntityData, IVenueFacilities
    {
        public string VenueId { get; set; }
        public string FacilityId { get; set; }

        [ForeignKey(nameof(VenueId))]
        public Venue Venue { get; set; }
        
        [ForeignKey(nameof(FacilityId))]
        public Facility Facility { get; set; }
    }
}