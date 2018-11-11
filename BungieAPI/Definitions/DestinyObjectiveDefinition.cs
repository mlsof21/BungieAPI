using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieAPI.Definitions
{
    public class DestinyObjectiveDefinition
    {
        public long objectiveHash { get; set; }
        public long unlockValueHash { get; set; }
        public long completionValue { get; set; }
        public long vendorHash { get; set; }
        public long vendorCategoryHash { get; set; }
        public string displayDescription { get; set; }
        public long locationHash { get; set; }
        public string allowNegativeValue { get; set; }
        public string allowValueChangeWhenCompleted { get; set; }
        public string isCountingDownward { get; set; }
        public long valueStyle { get; set; }
        public long hash { get; set; }
        public long index { get; set; }
        public string contentIdentifier { get; set; }
        public string redacted { get; set; }
    }
}
