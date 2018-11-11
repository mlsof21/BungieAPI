using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieAPI.Definitions
{
    public class DestinyActivityModeDefinition
    {
        public string modeName { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
        public string pgcrImage { get; set; }
        public long modeType { get; set; }
        public long activityModeCategory { get; set; }
        public long tier { get; set; }
        public long activityTypeHash { get; set; }
        public string isAggregateMode { get; set; }
        public string friendlyName { get; set; }
        public string supportsFeedFiltering { get; set; }
        public string display { get; set; }
        public long order { get; set; }
        public long hash { get; set; }
        public long index { get; set; }
        public string redacted { get; set; }
    }
}
