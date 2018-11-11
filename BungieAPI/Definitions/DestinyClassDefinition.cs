using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieAPI.Definitions
{
    public class DestinyClassDefinition
    {
        public long classHash { get; set; }
        public long classType { get; set; }
        public string className { get; set; }
        public string classNameMale { get; set; }
        public string classNameFemale { get; set; }
        public string classIdentifier { get; set; }
        public string mentorVendorIdentifier { get; set; }
        public long hash { get; set; }
        public long index { get; set; }
        public string redacted { get; set; }
    }
}
