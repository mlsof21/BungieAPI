using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieAPI.Definitions
{
    public class DestinyScriptedSkullDefinition
    {
        public long skullHash { get; set; }
        public string identifier { get; set; }
        public string skullName { get; set; }
        public string description { get; set; }
        public string iconPath { get; set; }
        public long hash { get; set; }
        public long index { get; set; }
        public string redacted { get; set; }
    }
}
