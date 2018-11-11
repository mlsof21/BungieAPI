using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieAPI.Definitions
{
    public class DestinyHistoricalStatsDefinition
    {
        public string statId { get; set; }
        public long group { get; set; }
        public string periodTypes { get; set; }
        public string modes { get; set; }
        public long category { get; set; }
        public string statName { get; set; }
        public string statDescription { get; set; }
        public long unitType { get; set; }
        public string unitLabel { get; set; }
        public long weight { get; set; }
    }
}
