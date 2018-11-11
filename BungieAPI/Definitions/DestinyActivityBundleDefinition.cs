using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieAPI.Definitions
{
    public class DestinyActivityBundleDefinition
    {
        public long bundleHash { get; set; }
        public string activityName { get; set; }
        public string activityDescription { get; set; }
        public string icon { get; set; }
        public string releaseIcon { get; set; }
        public long releaseTime { get; set; }
        public long destinationHash { get; set; }
        public long placeHash { get; set; }
        public long activityTypeHash { get; set; }
        public string activityHashes { get; set; }
        public long hash { get; set; }
        public long index { get; set; }
        public string redacted { get; set; }
    }
}
