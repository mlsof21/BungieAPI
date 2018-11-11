using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieAPI.Definitions
{
    public class DestinyVendorCategoryDefinition
    {
        public long categoryHash { get; set; }
        public long order { get; set; }
        public string categoryName { get; set; }
        public string mobileBannerPath { get; set; }
        public string identifier { get; set; }
        public long hash { get; set; }
        public long index { get; set; }
        public string redacted { get; set; }
    }
}
