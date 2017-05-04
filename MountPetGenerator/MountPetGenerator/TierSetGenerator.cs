﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MountPetGenerator
{
    class TierSetGenerator
    {
        public static void GenerateTierSet(string NameHead, string NameShoulder, string NameChest, string NameHands, string NameLegs,
            string DisplayHead, string DisplayShoulder, string DisplayChest, string DisplayHands, string DisplayLegs,
            string BaseEntry, string Class, bool type, float Coeficient, int itemsetID)
        {
            StringBuilder SQL = new StringBuilder();
            
            switch (Class.ToString())
            {
                case "Warrior":
                    if (type)
                    {

                    }
                    else
                    {
                    }
                    break;
                case "Paladin":
                    if (type)
                    {

                    }
                    else
                    {
                    }
                    break;
                case "Hunter":
                    if (type)
                    {

                    }
                    else
                    {
                    }
                    break;
                case "Rogue":
                    if (type)
                    {

                    }
                    else
                    {
                        SQL.AppendLine("insert into `item_template` (`entry`, `class`, `subclass`, `SoundOverrideSubclass`, `name`, `displayid`, `Quality`, `Flags`, `FlagsExtra`, `BuyCount`, `BuyPrice`, `SellPrice`, `InventoryType`, `AllowableClass`, `AllowableRace`, `ItemLevel`, `RequiredLevel`, `RequiredSkill`, `RequiredSkillRank`, `requiredspell`, `requiredhonorrank`, `RequiredCityRank`, `RequiredReputationFaction`, `RequiredReputationRank`, `maxcount`, `stackable`, `ContainerSlots`, `StatsCount`, `stat_type1`, `stat_value1`, `stat_type2`, `stat_value2`, `stat_type3`, `stat_value3`, `stat_type4`, `stat_value4`, `stat_type5`, `stat_value5`, `stat_type6`, `stat_value6`, `stat_type7`, `stat_value7`, `stat_type8`, `stat_value8`, `stat_type9`, `stat_value9`, `stat_type10`, `stat_value10`, `ScalingStatDistribution`, `ScalingStatValue`, `dmg_min1`, `dmg_max1`, `dmg_type1`, `dmg_min2`, `dmg_max2`, `dmg_type2`, `armor`, `holy_res`, `fire_res`, `nature_res`, `frost_res`, `shadow_res`, `arcane_res`, `delay`, `ammo_type`, `RangedModRange`, `spellid_1`, `spelltrigger_1`, `spellcharges_1`, `spellppmRate_1`, `spellcooldown_1`, `spellcategory_1`, `spellcategorycooldown_1`, `spellid_2`, `spelltrigger_2`, `spellcharges_2`, `spellppmRate_2`, `spellcooldown_2`, `spellcategory_2`, `spellcategorycooldown_2`, `spellid_3`, `spelltrigger_3`, `spellcharges_3`, `spellppmRate_3`, `spellcooldown_3`, `spellcategory_3`, `spellcategorycooldown_3`, `spellid_4`, `spelltrigger_4`, `spellcharges_4`, `spellppmRate_4`, `spellcooldown_4`, `spellcategory_4`, `spellcategorycooldown_4`, `spellid_5`, `spelltrigger_5`, `spellcharges_5`, `spellppmRate_5`, `spellcooldown_5`, `spellcategory_5`, `spellcategorycooldown_5`, `bonding`, `description`, `PageText`, `LanguageID`, `PageMaterial`, `startquest`, `lockid`, `Material`, `sheath`, `RandomProperty`, `RandomSuffix`, `block`, `itemset`, `MaxDurability`, `area`, `Map`, `BagFamily`, `TotemCategory`, `socketColor_1`, `socketContent_1`, `socketColor_2`, `socketContent_2`, `socketColor_3`, `socketContent_3`, `socketBonus`, `GemProperties`, `RequiredDisenchantSkill`, `ArmorDamageModifier`, `duration`, `ItemLimitCategory`, `HolidayId`, `ScriptName`, `DisenchantID`, `FoodType`, `minMoneyLoot`, `maxMoneyLoot`, `flagsCustom`, `VerifiedBuild`) values\n" +
                        "('" + int.Parse(BaseEntry) + ",'4','2','-1','" + NameChest + "','" + DisplayChest + "','4','4104','0','1','0','0','5','8','32767','" + 277 * Coeficient + "','80','0','0','0','0','0','0','0','0','1','0','5','38','" + 212 * Coeficient + "','3','" + 183 * Coeficient + "','7','" + 183 * Coeficient + "','32','" + 122 * Coeficient + "','44','" + 106 * Coeficient + "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','" + 694 * Coeficient + "','0','0','0','0','0','0','0','0','0','0','1','0','0','-1','0','-1','0','1','0','0','-1','0','-1','0','1','0','0','-1','0','-1','0','0','0','0','-1','0','-1','0','0','0','0','-1','0','-1','1','','0','0','0','0','0','8','0','0','0','0','" + itemsetID + "','120','0','0','0','0','2','0','4','0','0','0','3355','0','375','0','0','0','0','','68','0','0','0','0','27500'),\n" +
                        "('" + (int.Parse(BaseEntry) + 1) + "','4','2','-1','" + NameHands + "','" + DisplayHands + "','4','4104','0','1','0','0','10','8','2147483647','" + 277 * Coeficient + "','80','0','0','0','0','0','0','0','0','1','0','5','38','" + 165 * Coeficient + "','3','" + 136 * Coeficient + "','7','" + 136 * Coeficient + "','32','90','36','" + 82 * Coeficient + "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','" + 434 * Coeficient + "','0','0','0','0','0','0','0','0','0','0','1','0','0','-1','0','-1','0','0','0','0','-1','0','-1','0','0','0','0','-1','0','-1','0','0','0','0','-1','0','-1','0','0','0','0','-1','0','-1','1','','0','0','0','0','0','8','0','0','0','0','" + itemsetID + "','40','0','0','0','0','2','0','0','0','0','0','2877','0','375','0','0','0','0','','68','0','0','0','0','27500'),\n" +
                        "('" + (int.Parse(BaseEntry) + 2) + "','4','2','-1','" + NameHead + "','" + DisplayHead + "','4','4104','0','1','0','0','1','8','32767','" + 277 * Coeficient + "','80','0','0','0','0','0','0','0','0','1','0','5','38','" + 196 * Coeficient + "','3','" + 183 * Coeficient + "','7','" + 183 * Coeficient + "','32','114','44','" + 106 * Coeficient + "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','" + 564 * Coeficient + "','0','0','0','0','0','0','0','0','0','0','1','0','0','-1','0','-1','0','1','0','0','-1','0','-1','0','0','0','0','-1','0','-1','0','0','0','0','-1','0','-1','0','0','0','0','-1','0','-1','1','','0','0','0','0','0','8','0','0','0','0','" + itemsetID + "','70','0','0','0','0','1','0','2','0','0','0','3313','0','375','0','0','0','0','','68','0','0','0','0','27500'),\n" +
                        "('" + (int.Parse(BaseEntry) + 3) + "','4','2','-1','" + NameLegs + "','" + DisplayLegs + "','4','4104','0','1','0','0','7','8','2147483647','" + 277 * Coeficient + "','80','0','0','0','0','0','0','0','0','1','0','5','38','" + 212 * Coeficient + "','3','" + 183 * Coeficient + "','7','" + 183 * Coeficient + "','32','122','37','" + 106 * Coeficient + "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','" + 608 * Coeficient + "','0','0','0','0','0','0','0','0','0','0','1','0','0','-1','0','-1','0','0','0','0','-1','0','-1','0','0','0','0','-1','0','-1','0','0','0','0','-1','0','-1','0','0','0','0','-1','0','-1','1','','0','0','0','0','0','8','0','0','0','0','" + itemsetID + "','90','0','0','0','0','2','0','4','0','0','0','3355','0','375','0','0','0','0','','68','0','0','0','0','27500'),\n" +
                        "('" + (int.Parse(BaseEntry) + 4) + "','4','2','-1','" + NameShoulder + "','" + DisplayShoulder + "','4','4104','0','1','0','0','3','8','2147483647','" + 277 * Coeficient + "','80','0','0','0','0','0','0','0','0','1','0','5','38','" + 165 * Coeficient + "','3','" + 136 * Coeficient + "','7','" + 136 * Coeficient + "','32','" + 90 * Coeficient + "','31','" + 82 * Coeficient + "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','" + 521 * Coeficient + "','0','0','0','0','0','0','0','0','0','0','1','0','0','-1','0','-1','0','1','0','0','-1','0','-1','0','0','0','0','-1','0','-1','0','0','0','0','-1','0','-1','0','0','0','0','-1','0','-1','1','','0','0','0','0','0','8','0','0','0','0','" + itemsetID + "','70','0','0','0','0','2','0','0','0','0','0','2877','0','375','0','0','0','0','','68','0','0','0','0','27500');\n");
                    }
                    break;
                case "Priest":
                    if (type)
                    {

                    }
                    else
                    {
                    }
                    break;
                case "Death-Knight":
                    if (type)
                    {

                    }
                    else
                    {
                    }
                    break;
                case "Shaman":
                    if (type)
                    {

                    }
                    else
                    {
                    }
                    break;
                case "Mage":
                    if (type)
                    {

                    }
                    else
                    {
                        // Heroic
                        SQL.AppendLine("insert into `item_template` (`entry`, `class`, `subclass`, `SoundOverrideSubclass`, `name`, `displayid`, `Quality`, `Flags`, `FlagsExtra`, `BuyCount`, `BuyPrice`, `SellPrice`, `InventoryType`, `AllowableClass`, `AllowableRace`, `ItemLevel`, `RequiredLevel`, `RequiredSkill`, `RequiredSkillRank`, `requiredspell`, `requiredhonorrank`, `RequiredCityRank`, `RequiredReputationFaction`, `RequiredReputationRank`, `maxcount`, `stackable`, `ContainerSlots`, `StatsCount`, `stat_type1`, `stat_value1`, `stat_type2`, `stat_value2`, `stat_type3`, `stat_value3`, `stat_type4`, `stat_value4`, `stat_type5`, `stat_value5`, `stat_type6`, `stat_value6`, `stat_type7`, `stat_value7`, `stat_type8`, `stat_value8`, `stat_type9`, `stat_value9`, `stat_type10`, `stat_value10`, `ScalingStatDistribution`, `ScalingStatValue`, `dmg_min1`, `dmg_max1`, `dmg_type1`, `dmg_min2`, `dmg_max2`, `dmg_type2`, `armor`, `holy_res`, `fire_res`, `nature_res`, `frost_res`, `shadow_res`, `arcane_res`, `delay`, `ammo_type`, `RangedModRange`, `spellid_1`, `spelltrigger_1`, `spellcharges_1`, `spellppmRate_1`, `spellcooldown_1`, `spellcategory_1`, `spellcategorycooldown_1`, `spellid_2`, `spelltrigger_2`, `spellcharges_2`, `spellppmRate_2`, `spellcooldown_2`, `spellcategory_2`, `spellcategorycooldown_2`, `spellid_3`, `spelltrigger_3`, `spellcharges_3`, `spellppmRate_3`, `spellcooldown_3`, `spellcategory_3`, `spellcategorycooldown_3`, `spellid_4`, `spelltrigger_4`, `spellcharges_4`, `spellppmRate_4`, `spellcooldown_4`, `spellcategory_4`, `spellcategorycooldown_4`, `spellid_5`, `spelltrigger_5`, `spellcharges_5`, `spellppmRate_5`, `spellcooldown_5`, `spellcategory_5`, `spellcategorycooldown_5`, `bonding`, `description`, `PageText`, `LanguageID`, `PageMaterial`, `startquest`, `lockid`, `Material`, `sheath`, `RandomProperty`, `RandomSuffix`, `block`, `itemset`, `MaxDurability`, `area`, `Map`, `BagFamily`, `TotemCategory`, `socketColor_1`, `socketContent_1`, `socketColor_2`, `socketContent_2`, `socketColor_3`, `socketContent_3`, `socketBonus`, `GemProperties`, `RequiredDisenchantSkill`, `ArmorDamageModifier`, `duration`, `ItemLimitCategory`, `HolidayId`, `ScriptName`, `DisenchantID`, `FoodType`, `minMoneyLoot`, `maxMoneyLoot`, `flagsCustom`, `VerifiedBuild`) values\n" +
                        "('" + int.Parse(BaseEntry) + "', '4', '1', '-1', '" + NameHands + "', '" + DisplayHands + "', '4', '4104', '0', '1', '0', '0', '10', '128', '32767', '" + 277 * Coeficient + "', '80', '0', '0', '0', '0', '0', '0', '0', '0', '1', '0', '5', '45', '" + 150 * Coeficient + "', '7', '" + 103 * Coeficient + "', '5', '" + 103 * Coeficient + "', '32', '" + 90 * Coeficient + "', '31', '" + 82 * Coeficient + "', '0', '" + 0 * Coeficient + "', '0', '" + 0 * Coeficient + "', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '" + 231 * Coeficient + "', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '1', '0', '0', '-1', '0', '-1', '0', '1', '0', '0', '-1', '0', '-1', '0', '0', '0', '0', '-1', '0', '-1', '0', '0', '0', '0', '-1', '0', '-1', '0', '0', '0', '0', '-1', '0', '-1', '1', '', '0', '0', '0', '0', '0', '7', '0', '0', '0', '0', '" + itemsetID + "', '35', '0', '0', '0', '0', '8', '0', '0', '0', '0', '0', '3752', '0', '375', '0', '0', '0', '0', '', '68', '0', '0', '0', '0', '27500'),\n" +
                        "('" + (int.Parse(BaseEntry) + 1) + "', '4', '1', '-1', '" + NameHead + "', '" + DisplayHead + "', '4', '4104', '0', '1', '0', '0', '1', '128', '32767', '" + 277 * Coeficient + "', '80', '0', '0', '0', '0', '0', '0', '0', '0', '1', '0', '5', '45', '" + 186 * Coeficient + "', '7', '" + 139 * Coeficient + "', '5', '" + 139 * Coeficient + "', '32', '" + 122 * Coeficient + "', '36', '" + 98 * Coeficient + "', '0', '" + 0 * Coeficient + "', '0', '" + 0 * Coeficient + "', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '" + 300 * Coeficient + "', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '1', '0', '0', '-1', '0', '-1', '0', '1', '0', '0', '-1', '0', '-1', '0', '0', '0', '0', '-1', '0', '-1', '0', '0', '0', '0', '-1', '0', '-1', '0', '0', '0', '0', '-1', '0', '-1', '1', '', '0', '0', '0', '0', '0', '7', '0', '0', '0', '0', '" + itemsetID + "', '60', '0', '0', '0', '0', '1', '0', '8', '0', '0', '0', '3753', '0', '375', '0', '0', '0', '0', '', '68', '0', '0', '0', '0', '27500'),\n" +
                        "('" + (int.Parse(BaseEntry) + 2) + "', '4', '1', '-1', '" + NameLegs + "', '" + DisplayLegs + "', '4', '4104', '0', '1', '0', '0', '7', '128', '2147483647', '" + 277 * Coeficient + "', '80', '0', '0', '0', '0', '0', '0', '0', '0', '1', '0', '5', '45', '" + 195 * Coeficient + "', '7', '" + 139 * Coeficient + "', '5', '" + 139 * Coeficient + "', '32', '" + 122 * Coeficient + "', '31', '" + 106 * Coeficient + "', '0', '" + 0 * Coeficient + "', '" + 0 * Coeficient + "', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '" + 323 * Coeficient + "', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '1', '0', '0', '-1', '0', '-1', '0', '1', '0', '0', '-1', '0', '-1', '0', '0', '0', '0', '-1', '0', '-1', '0', '0', '0', '0', '-1', '0', '-1', '0', '0', '0', '0', '-1', '0', '-1', '1', '', '0', '0', '0', '0', '0', '7', '0', '0', '0', '0', '" + itemsetID + "', '75', '0', '0', '0', '0', '8', '0', '4', '0', '0', '0', '3602', '0', '375', '0', '0', '0', '0', '', '68', '0', '0', '0', '0', '27500'),\n" +
                        "('" + (int.Parse(BaseEntry) + 3) + "', '4', '1', '-1', '" + NameChest + "', '" + DisplayChest + "', '4', '4104', '0', '1', '0', '0', '20', '128', '2147483647', '" + 277 * Coeficient + "', '80', '0', '0', '0', '0', '0', '0', '0', '0', '1', '0', '5', '45', '" + 195 * Coeficient + "', '7', '" + 139 * Coeficient + "', '5', '" + 139 * Coeficient + "', '32', '" + 106 * Coeficient + "', '36', '" + 122 * Coeficient + "', '0', '" + 0 * Coeficient + "', '0', '" + 0 * Coeficient + "', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '" + 369 * Coeficient + "', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '1', '0', '0', '-1', '0', '-1', '0', '1', '0', '0', '-1', '0', '-1', '0', '1', '0', '0', '-1', '0', '-1', '0', '1', '0', '0', '-1', '0', '-1', '0', '0', '0', '0', '-1', '0', '-1', '1', '', '0', '0', '0', '0', '0', '7', '0', '0', '0', '0', '" + itemsetID + "', '100', '0', '0', '0', '0', '2', '0', '8', '0', '0', '0', '3602', '0', '375', '0', '0', '0', '0', '', '68', '0', '0', '0', '0', '27500'),\n" +
                        "('" + (int.Parse(BaseEntry) + 4) + "', '4', '1', '-1', '" + NameShoulder + "', '" + DisplayShoulder + "', '4', '4104', '0', '1', '0', '0', '3', '128', '2147483647', '" + 277 * Coeficient + "', '80', '0', '0', '0', '0', '0', '0', '0', '0', '1', '0', '5', '45', '" + 150 * Coeficient + "', '7', '" + 103 * Coeficient + "', '5', '" + 103 * Coeficient + "', '32', '" + 90 * Coeficient + "', '36', '" + 82 * Coeficient + "', '0', '" + 0 * Coeficient + "', '0', '" + 0 * Coeficient + "', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '" + 277 * Coeficient + "', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '1', '0', '0', '-1', '0', '-1', '0', '1', '0', '0', '-1', '0', '-1', '0', '0', '0', '0', '-1', '0', '-1', '0', '0', '0', '0', '-1', '0', '-1', '0', '0', '0', '0', '-1', '0', '-1', '1', '', '0', '0', '0', '0', '0', '7', '0', '0', '0', '0', '" + itemsetID + "', '60', '0', '0', '0', '0', '4', '0', '0', '0', '0', '0', '3752', '0', '375', '0', '0', '0', '0', '', '68', '0', '0', '0', '0', '27500');");
                    }
                    break;
                case "Warlock":
                    if (type)
                    {

                    }
                    else
                    {
                    }
                    break;
                case "Druid":
                    if (type)
                    {

                    }
                    else
                    {
                    }
                    break;
            }
            File.WriteAllText(@".\ItemSet\Tier_" + Class.ToString() + "_" + BaseEntry + ".sql", SQL.ToString());
        }
    }
}
