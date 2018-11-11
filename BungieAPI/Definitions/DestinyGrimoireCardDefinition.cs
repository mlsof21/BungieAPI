using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieAPI.Definitions
{
    public class DestinyGrimoireCardDefinition
    {
        public long cardId { get; set; }
        public string cardName { get; set; }
        public string cardIntro { get; set; }
        public string cardDescription { get; set; }
        public string unlockHowToText { get; set; }
        public long rarity { get; set; }
        public long unlockFlagHash { get; set; }
        public long points { get; set; }
        public string normalResolution { get; set; }
        public string highResolution { get; set; }
    }
}
