using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieAPI.Definitions
{
    public class DestinyStatGroupDefinition
    {
        public long statGroupHash { get; set; }
        public long maximumValue { get; set; }
        public long uiPosition { get; set; }
        public string scaledStats { get; set; }
        public string overrides { get; set; }
        public long hash { get; set; }
        public long index { get; set; }
        public string redacted { get; set; }
    }
}
