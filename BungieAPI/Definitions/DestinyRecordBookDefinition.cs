using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieAPI.Definitions
{
    public class DestinyRecordBookDefinition
    {
        public string bookAvailableUnlockExpression { get; set; }
        public string activeRanges { get; set; }
        public string pages { get; set; }
        public string displayName { get; set; }
        public string displayDescription { get; set; }
        public string icon { get; set; }
        public string unavailableReason { get; set; }
        public long progressionHash { get; set; }
        public long recordCount { get; set; }
        public string webmasterCampaignSystem { get; set; }
        public string bannerImage { get; set; }
        public long itemHash { get; set; }
        public string rewardImage { get; set; }
        public string promoEndDate { get; set; }
        public long hash { get; set; }
        public long index { get; set; }
        public string contentIdentifier { get; set; }
        public string redacted { get; set; }
    }
}
