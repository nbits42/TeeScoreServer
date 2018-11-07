using Microsoft.Azure.Mobile.Server;

namespace TeeScoreService.DataObjects
{
    public class Player: EntityData
    {
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public string AvatarUrl { get; set; }
        public string ImageUrl { get; set; }
    }
}