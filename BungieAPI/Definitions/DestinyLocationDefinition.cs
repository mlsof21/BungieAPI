using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieAPI.Definitions
{
    public class DestinyLocationDefinition
    {
        public long locationHash { get; set; }
        public string uiLocationType { get; set; }
        public string locationReleases { get; set; }
        public long hash { get; set; }
        public long index { get; set; }
        public string contentIdentifier { get; set; }
        public string redacted { get; set; }
    }
}
