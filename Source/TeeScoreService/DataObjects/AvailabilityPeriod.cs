using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GlobalContracts.Interfaces;
using Microsoft.Azure.Mobile.Server;

namespace TeeScoreService.DataObjects
{
    public class AvailabilityPeriod : EntityData, IAvailabilityPeriod
    {
        public string Name { get; set; }
        public DateTime OpenFrom { get; set; }
        public DateTime OpenUntil { get; set; }
    }
}