using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieAPI.Definitions
{
    public class DestinyDirectorBookDefinition
    {
        public long bookHash { get; set; }
        public string bookName { get; set; }
        public string bookDescription { get; set; }
        public string bookNumber { get; set; }
        public string nodes { get; set; }
        public string connections { get; set; }
        public string visible { get; set; }
        public string isOverview { get; set; }
        public string isDefaultExpression { get; set; }
        public string isVisibleExpression { get; set; }
        public long destinationHash { get; set; }
        public long hash { get; set; }
        public long index { get; set; }
        public string redacted { get; set; }
    }
}
