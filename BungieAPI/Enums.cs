﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieAPI
{

    class Enums
    {
        public enum MembershipTypes : int {
            None=0,
            TigerXbox=1,
            TigerPsn=2,
            TigerBlizzard =4,
            TigerDemon=10,
            BungieNext =254,
            All =-1
        }
        public enum ComponentTypes : int {
            None = 0,
            Profiles = 100,
            VendorReceipts = 101,
            ProfileInventories = 102,
            ProfileCurrencies = 103,
            ProfileProgression = 104,
            Characters = 200,
            CharacterInventories = 201,
            CharacterProgressions = 202,
            CharacterRenderData = 203,
            CharacterActivities = 204,
            CharacterEquipment = 205,
            ItemInstances = 300,
            ItemObjectives = 301,
            ItemPerks = 302,
            ItemRenderData = 303,
            ItemStats = 304,
            ItemSockets = 305,
            ItemTalentGrids = 306,
            ItemCommonData = 307,
            ItemPlugStates = 308,
            Vendors = 400,
            VendorCategories = 401,
            VendorSales = 402,
            Kiosks = 500,
            CurrencyLookups = 600,
            PresentationNodes = 700,
            Collectibles = 800,
            Records = 900
        }
    }
}
