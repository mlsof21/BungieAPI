using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieAPI.Definitions
{
    public class DestinyGenderDefinition
    {
        public long genderHash { get; set; }
        public long genderType { get; set; }
        public string genderName { get; set; }
        public string genderDescription { get; set; }
        public long hash { get; set; }
        public long index { get; set; }
        public string redacted { get; set; }
    }
}
