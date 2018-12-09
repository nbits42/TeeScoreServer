﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GlobalContracts.Interfaces;
using Microsoft.Azure.Mobile.Server;

namespace TeeScoreService.DataObjects
{
    public class Venue : EntityData, IVenue
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public string ThumbnailUrl { get; set; }
        public string OwnerId { get; set; }
        public string ImageUrl { get; set; }
    }
}