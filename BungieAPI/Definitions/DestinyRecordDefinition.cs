using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieAPI.Definitions
{
    public class DestinyRecordDefinition
    {
        public string displayName { get; set; }
        public string description { get; set; }
        public string recordValueUIStyle { get; set; }
        public string icon { get; set; }
        public long style { get; set; }
        public string rewards { get; set; }
        public string actualRewards { get; set; }
        public string objectives { get; set; }
        public long hash { get; set; }
        public long index { get; set; }
        public string contentIdentifier { get; set; }
        public string redacted { get; set; }
    }
}
