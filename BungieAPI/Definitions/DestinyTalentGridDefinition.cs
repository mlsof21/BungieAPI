using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieAPI.Definitions
{
    public class DestinyTalentGridDefinition
    {
        public long gridHash { get; set; }
        public long maxGridLevel { get; set; }
        public long gridLevelPerColumn { get; set; }
        public long progressionHash { get; set; }
        public string nodes { get; set; }
        public long calcMaxGridLevel { get; set; }
        public long calcProgressToMaxLevel { get; set; }
        public string exclusiveSets { get; set; }
        public string independentNodeIndexes { get; set; }
        public long maximumRandomMaterialRequirements { get; set; }
        public long hash { get; set; }
        public long index { get; set; }
        public string redacted { get; set; }
    }
}
