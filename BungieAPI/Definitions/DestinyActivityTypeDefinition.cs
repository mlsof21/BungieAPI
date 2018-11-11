using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieAPI.Definitions
{
    public class DestinyActivityTypeDefinition
    {
        public long activityTypeHash { get; set; }
        public string identifier { get; set; }
        public string activityTypeName { get; set; }
        public string activityTypeDescription { get; set; }
        public string icon { get; set; }
        public string activeBackgroundVirtualPath { get; set; }
        public string completedBackgroundVirtualPath { get; set; }
        public string hiddenOverrideVirtualPath { get; set; }
        public string tooltipBackgroundVirtualPath { get; set; }
        public string enlargedActiveBackgroundVirtualPath { get; set; }
        public string enlargedCompletedBackgroundVirtualPath { get; set; }
        public string enlargedHiddenOverrideVirtualPath { get; set; }
        public string enlargedTooltipBackgroundVirtualPath { get; set; }
        public long order { get; set; }
        public long hash { get; set; }
        public long index { get; set; }
        public string redacted { get; set; }
    }
}
