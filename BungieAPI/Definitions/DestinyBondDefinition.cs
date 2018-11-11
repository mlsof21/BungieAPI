using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieAPI.Definitions
{
    public class DestinyBondDefinition
    {
        public string displayIcon { get; set; }
        public string questItemHashes { get; set; }
        public long providedUnlockHash { get; set; }
        public long providedUnlockValueHash { get; set; }
        public string showInAdvisor { get; set; }
        public long hash { get; set; }
        public long index { get; set; }
        public string contentIdentifier { get; set; }
        public string redacted { get; set; }
    }
}
