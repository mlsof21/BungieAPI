using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieAPI.Definitions
{
    public class DestinyRewardSourceDefinition
    {
        public long sourceHash { get; set; }
        public long category { get; set; }
        public string identifier { get; set; }
        public string sourceName { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
        public long hash { get; set; }
        public long index { get; set; }
        public string redacted { get; set; }
    }
}
