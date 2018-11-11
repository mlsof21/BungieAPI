using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieAPI.Definitions
{
    public class DestinyActivityCategoryDefinition
    {
        public string title { get; set; }
        public string identifier { get; set; }
        public string description { get; set; }
        public string helpTitle { get; set; }
        public string image { get; set; }
        public string links { get; set; }
        public string parentHashes { get; set; }
        public long order { get; set; }
        public string hasHelpContent { get; set; }
        public string resetIdentifier { get; set; }
        public long hash { get; set; }
        public long index { get; set; }
        public string redacted { get; set; }
    }
}
