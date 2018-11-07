using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Azure.Mobile.Server;

namespace TeeScoreService.DataObjects
{
    public class Venue: EntityData
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public string ThumbnailUrl { get; set; }
        public string ImageUrl { get; set; }
    }
}