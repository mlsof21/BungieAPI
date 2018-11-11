using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieAPI.Definitions
{
    public class DestinyVendorDefinition
    {
        public string summary { get; set; }
        public string acceptedItems { get; set; }
        public string categories { get; set; }
        public string failureStrings { get; set; }
        public string sales { get; set; }
        public long unlockValueHash { get; set; }
        public long hash { get; set; }
        public long index { get; set; }
        public string redacted { get; set; }
    }
}
