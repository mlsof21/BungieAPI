using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieAPI.Definitions
{
    public class DestinyItemCategoryDefinition
    {
        public long itemCategoryHash { get; set; }
        public string identifier { get; set; }
        public string visible { get; set; }
        public string title { get; set; }
        public string shortTitle { get; set; }
        public string description { get; set; }
        public long grantDestinyItemType { get; set; }
        public long grantDestinySubType { get; set; }
        public long grantDestinyClass { get; set; }
        public long hash { get; set; }
        public long index { get; set; }
        public string redacted { get; set; }
    }
}
