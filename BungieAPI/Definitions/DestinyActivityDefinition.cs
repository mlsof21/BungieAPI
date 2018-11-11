using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieAPI.Definitions
{
    public class DestinyActivityDefinition
    {
        public long activityHash { get; set; }
        public string activityName { get; set; }
        public string activityDescription { get; set; }
        public string icon { get; set; }
        public string releaseIcon { get; set; }
        public long releaseTime { get; set; }
        public long activityLevel { get; set; }
        public long completionFlagHash { get; set; }
        public string activityPower { get; set; }
        public long minParty { get; set; }
        public long maxParty { get; set; }
        public long maxPlayers { get; set; }
        public long destinationHash { get; set; }
        public long placeHash { get; set; }
        public long activityTypeHash { get; set; }
        public long tier { get; set; }
        public string pgcrImage { get; set; }
        public string rewards { get; set; }
        public string skulls { get; set; }
        public string isPlaylist { get; set; }
        public string isMatchmade { get; set; }
        public long hash { get; set; }
        public long index { get; set; }
        public string redacted { get; set; }
    }
}
