using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieAPI.Definitions
{
    public class DestinySpecialEventDefinition
    {
        public long eventHash { get; set; }
        public string eventIdentifier { get; set; }
        public string backgroundImageWeb { get; set; }
        public string title { get; set; }
        public string subtitle { get; set; }
        public string description { get; set; }
        public string link { get; set; }
        public string icon { get; set; }
        public string showNagMessage { get; set; }
        public string returnInActivityAdvisor { get; set; }
        public long progressionHash { get; set; }
        public long vendorHash { get; set; }
        public long factionHash { get; set; }
        public string backgroundImageMobile { get; set; }
        public long activeUnlockValueHash { get; set; }
        public string bountyHashes { get; set; }
        public string questHashes { get; set; }
        public string friendlyIdentifier { get; set; }
        public string recruitmentIds { get; set; }
        public long playlistActivityHash { get; set; }
        public long unlockEventHash { get; set; }
        public long activityMode { get; set; }
        public long hash { get; set; }
        public long index { get; set; }
        public string redacted { get; set; }
    }
}
