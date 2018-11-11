using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieAPI.Definitions
{
    public class DestinyRaceDefinition
    {
        public long raceHash { get; set; }
        public long raceType { get; set; }
        public string raceName { get; set; }
        public string raceNameMale { get; set; }
        public string raceNameFemale { get; set; }
        public string raceDescription { get; set; }
        public long hash { get; set; }
        public long index { get; set; }
        public string redacted { get; set; }
    }
}
