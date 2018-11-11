using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieAPI.Definitions
{
    public class DestinyPlaceDefinition
    {
        public long placeHash { get; set; }
        public string placeName { get; set; }
        public string placeDescription { get; set; }
        public string icon { get; set; }
        public long hash { get; set; }
        public long index { get; set; }
        public string redacted { get; set; }
    }
}
