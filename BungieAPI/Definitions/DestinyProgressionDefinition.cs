using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieAPI.Definitions
{
    public class DestinyProgressionDefinition
    {
        public long progressionHash { get; set; }
        public string name { get; set; }
        public long scope { get; set; }
        public string repeatLastStep { get; set; }
        public string steps { get; set; }
        public string visible { get; set; }
        public long hash { get; set; }
        public long index { get; set; }
        public string redacted { get; set; }
    }
}
