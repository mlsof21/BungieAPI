using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieAPI.Definitions
{
    public class DestinyStatDefinition
    {
        public long statHash { get; set; }
        public string statName { get; set; }
        public string statDescription { get; set; }
        public string icon { get; set; }
        public string statIdentifier { get; set; }
        public long aggregationType { get; set; }
        public string hasComputedBlock { get; set; }
        public string interpolate { get; set; }
        public long hash { get; set; }
        public long index { get; set; }
        public string redacted { get; set; }
    }
}
