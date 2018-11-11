using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieAPI.Definitions
{
    public class DestinyDestinationDefinition
    {
        public long destinationHash { get; set; }
        public string destinationName { get; set; }
        public string icon { get; set; }
        public long placeHash { get; set; }
        public string destinationIdentifier { get; set; }
        public long hash { get; set; }
        public long index { get; set; }
        public string redacted { get; set; }
    }
}
