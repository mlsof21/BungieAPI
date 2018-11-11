using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieAPI.Definitions
{
    public class DestinyFactionDefinition
    {
        public long factionHash { get; set; }
        public string factionName { get; set; }
        public string factionDescription { get; set; }
        public string factionIcon { get; set; }
        public long progressionHash { get; set; }
        public long hash { get; set; }
        public long index { get; set; }
        public string redacted { get; set; }
    }
}
