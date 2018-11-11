using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieAPI.Definitions
{
    public class DestinyInventoryBucketDefinition
    {
        public long bucketHash { get; set; }
        public string bucketName { get; set; }
        public string bucketDescription { get; set; }
        public long scope { get; set; }
        public long category { get; set; }
        public long bucketOrder { get; set; }
        public string bucketIdentifier { get; set; }
        public long itemCount { get; set; }
        public long location { get; set; }
        public string hasTransferDestination { get; set; }
        public string enabled { get; set; }
        public string fifo { get; set; }
        public long hash { get; set; }
        public long index { get; set; }
        public string redacted { get; set; }
    }
}
