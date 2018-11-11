using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieAPI.Definitions
{
    public class DestinySandboxPerkDefinition
    {
        public long perkHash { get; set; }
        public string displayName { get; set; }
        public string displayDescription { get; set; }
        public string displayIcon { get; set; }
        public string isDisplayable { get; set; }
        public long hash { get; set; }
        public long index { get; set; }
        public string redacted { get; set; }
    }
}
