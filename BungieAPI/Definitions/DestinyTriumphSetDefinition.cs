using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieAPI.Definitions
{
    public class DestinyTriumphSetDefinition
    {
        public long triumphSetHash { get; set; }
        public string identifier { get; set; }
        public long order { get; set; }
        public string title { get; set; }
        public string iconPath { get; set; }
        public string incompleteSubtitle { get; set; }
        public string incompleteDetails { get; set; }
        public string completedSubtitle { get; set; }
        public string completedDetails { get; set; }
        public string lockedSubtitle { get; set; }
        public string lockedDetails { get; set; }
        public string lockdownDate { get; set; }
        public string triumphs { get; set; }
        public string isRecordBook { get; set; }
        public long lockdownUnlockHash { get; set; }
        public long hash { get; set; }
        public long index { get; set; }
        public string redacted { get; set; }
    }
}
