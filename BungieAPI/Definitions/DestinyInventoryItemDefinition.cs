using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieAPI.Definitions
{
    public class DestinyInventoryItemDefinition
    {
        public long itemHash { get; set; }
        public string itemName { get; set; }
        public string itemDescription { get; set; }
        public string icon { get; set; }
        public string hasIcon { get; set; }
        public string secondaryIcon { get; set; }
        public string actionName { get; set; }
        public string hasAction { get; set; }
        public string deleteOnAction { get; set; }
        public string tierTypeName { get; set; }
        public long tierType { get; set; }
        public string itemTypeName { get; set; }
        public long bucketTypeHash { get; set; }
        public long primaryBaseStatHash { get; set; }
        public string stats { get; set; }
        public string perkHashes { get; set; }
        public long specialItemType { get; set; }
        public long talentGridHash { get; set; }
        public string equippingBlock { get; set; }
        public string hasGeometry { get; set; }
        public long statGroupHash { get; set; }
        public string itemLevels { get; set; }
        public long qualityLevel { get; set; }
        public string equippable { get; set; }
        public string instanced { get; set; }
        public long rewardItemHash { get; set; }
        public string values { get; set; }
        public long itemType { get; set; }
        public long itemSubType { get; set; }
        public long classType { get; set; }
        public string itemCategoryHashes { get; set; }
        public string sourceHashes { get; set; }
        public string nonTransferrable { get; set; }
        public long exclusive { get; set; }
        public long maxStackSize { get; set; }
        public long itemIndex { get; set; }
        public string setItemHashes { get; set; }
        public string tooltipStyle { get; set; }
        public long questlineItemHash { get; set; }
        public string needsFullCompletion { get; set; }
        public string objectiveHashes { get; set; }
        public string allowActions { get; set; }
        public long questTrackingUnlockValueHash { get; set; }
        public long bountyResetUnlockHash { get; set; }
        public long uniquenessHash { get; set; }
        public string showActiveNodesInTooltip { get; set; }
        public long hash { get; set; }
        public long index { get; set; }
        public string redacted { get; set; }
    }
}
