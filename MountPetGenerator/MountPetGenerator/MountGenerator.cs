﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MountPetGenerator
{
    class MountGenerator
    {
        public static void GenerateMount(string CreatureID, string CreatureDisplayID, string SpellID, string SpellIcon, string SpellName, string SpellDescription, string Type)
        {
            StringBuilder SpellfrFR = new StringBuilder();
            StringBuilder SpellenEN = new StringBuilder();
            StringBuilder CoreScript = new StringBuilder();
            StringBuilder Creature_TemplateSQL = new StringBuilder();
            StringBuilder Creature_Model_SQL = new StringBuilder();
            StringBuilder SpellScriptNameSQL = new StringBuilder();
            
            switch (Type.ToString())
            {
                case "Land":
                    // frFR
                    SpellfrFR.AppendLine(int.Parse(SpellID) + ",0,0,21,269844752,0,0,536870912,0,0,131072,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,16,0,0,31,0,0,0,101,0,0,0,1,21,0,0,0,0,0,1,0.000000,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,0,0,6,6,0,0,1,0,0.000000,0.000000,0.000000,0,99,0,0,0,0,1,1,0,0,0,0,0,0,0,78,32,0,0,0,0,0.000000,0.000000,0.000000,0,0,0,0,0,0," + CreatureID + ",0,0,0,0,0,0,0,0,0.000000,0.000000,0.000000,0,0,0,0,0,0,0,0,0,1703,0," + SpellIcon + ",0,,0,0,\"" + SpellName + "\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,0,,0,0,0,0,0,0,0,0,0,0,0,0,0,16712188,0,0,\"Summon And Dismisses this " + Type + " mount." + SpellDescription + "\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,0,\"Increase Speed by $s2%.\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,0,0,0,0,0,0,0,0,0,0,0,1.000000,1.000000,1.000000,0,0,0,0,0,0,1,0,0,0,0.000000,0.000000,0.000000,0,0");
                    // En / US
                    SpellenEN.AppendLine(int.Parse(SpellID) + ",0,0,21,269844752,0,0,536870912,0,0,131072,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,16,0,0,31,0,0,0,101,0,0,0,1,21,0,0,0,0,0,1,0.000000,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,0,0,6,6,0,0,1,0,0.000000,0.000000,0.000000,0,99,0,0,0,0,1,1,0,0,0,0,0,0,0,78,32,0,0,0,0,0.000000,0.000000,0.000000,0,0,0,0,0,0," + CreatureID + ",0,0,0,0,0,0,0,0,0.000000,0.000000,0.000000,0,0,0,0,0,0,0,0,0,1703,0," + SpellIcon + ",0,,0,0,\"" + SpellName + "\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,0,,0,0,0,0,0,0,0,0,0,0,0,0,0,16712188,0,0,\"Summon And Dismisses this " + Type + " mount." + SpellDescription + "\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,0,\"Increase Speed by $s2%.\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,0,0,0,0,0,0,0,0,0,0,0,1.000000,1.000000,1.000000,0,0,0,0,0,0,1,0,0,0,0.000000,0.000000,0.000000,0,0");
                    break;
                case "Aquatic":
                    // frFR
                    SpellfrFR.AppendLine(int.Parse(SpellID) + ",0,0,21,269844752,0,0,536870912,0,0,131072,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,16,0,0,31,0,0,0,101,0,0,0,1,21,0,0,0,0,0,1,0.000000,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,0,0,6,6,0,1,1,1,0.000000,0.000000,0.000000,-1,149,-1,0,0,0,1,1,0,0,0,0,0,0,0,78,58,0,0,0,0,0.000000,0.000000,0.000000,0,0,0,0,0,0," + CreatureID + ",0,0,0,0,0,0,0,0,0.000000,0.000000,0.000000,0,0,0,0,0,0,0,0,0,5160,0," + SpellIcon + ",0,,0,0,\"" + SpellName + "\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,0,,0,0,0,0,0,0,0,0,0,0,0,0,0,16712188,0,0,\"Summon And Dismisses this " + Type + " mount." + SpellDescription + "\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,0,\"Increase Swimming Speed by $s2%.\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,0,0,0,0,0,0,0,0,0,0,0,1.000000,1.000000,1.000000,0,0,0,0,0,0,1,0,0,0,0.000000,0.000000,0.000000,0,0");
                    // En / US
                    SpellenEN.AppendLine(int.Parse(SpellID) + ",0,0,21,269844752,0,0,536870912,0,0,131072,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,16,0,0,31,0,0,0,101,0,0,0,1,21,0,0,0,0,0,1,0.000000,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,0,0,6,6,0,1,1,1,0.000000,0.000000,0.000000,-1,149,-1,0,0,0,1,1,0,0,0,0,0,0,0,78,58,0,0,0,0,0.000000,0.000000,0.000000,0,0,0,0,0,0," + CreatureID + ",0,0,0,0,0,0,0,0,0.000000,0.000000,0.000000,0,0,0,0,0,0,0,0,0,5160,0," + SpellIcon + ",0,,0,0,\"" + SpellName + "\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,0,,0,0,0,0,0,0,0,0,0,0,0,0,0,16712188,0,0,\"Summon And Dismisses this " + Type + " mount." + SpellDescription + "\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,0,\"Increase Swimming Speed by $s2%.\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,0,0,0,0,0,0,0,0,0,0,0,1.000000,1.000000,1.000000,0,0,0,0,0,0,1,0,0,0,0.000000,0.000000,0.000000,0,0");
                    break;
                case "Flying":
                    // frFR
                    // Adaptive Mount (Need more research)
                    SpellfrFR.AppendLine((int.Parse(SpellID) + 1000000) + ",0,0,21,286359824,0,0,0,0,0,131072,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,31,0,0,0,101,0,0,0,1,21,0,0,0,0,0,1,0.000000,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,0,0,6,6,0,0,1,1,0.000000,0.000000,0.000000,0,59,-1,0,0,0,1,1,0,0,0,0,0,0,0,78,32,0,0,0,0,0.000000,0.000000,0.000000,0,0,0,0,0,0," + CreatureID + ",0,0,1,0,0,0,0,0,0.000000,0.000000,0.000000,0,0,0,0,0,0,0,0,0,0,0," + SpellIcon + ",122,,0,0,\"" + SpellName + "\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,0,,0,0,0,0,0,0,0,0,0,0,0,0,0,16712188,0,0,\"Summon and Dismisses " + SpellName + ".\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,0,\"Increase Speed By $s2%.\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,133,0,0,0,0,0,0,0,0,0,0,1.000000,1.000000,1.000000,0,0,0,0,0,0,1,0,0,0,0.000000,0.000000,0.000000,0,0");
                    SpellfrFR.AppendLine((int.Parse(SpellID) + 2000000) + ",0,0,21,286359824,0,0,0,0,0,131072,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,31,0,0,0,101,0,0,0,1,21,0,0,0,0,0,1,0.000000,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,0,0,6,6,0,0,1,1,0.000000,0.000000,0.000000,0,99,-1,0,0,0,1,1,0,0,0,0,0,0,0,78,32,0,0,0,0,0.000000,0.000000,0.000000,0,0,0,0,0,0," + CreatureID + ",0,0,1,0,0,0,0,0,0.000000,0.000000,0.000000,0,0,0,0,0,0,0,0,0,0,0," + SpellIcon + ",122,,0,0,\"" + SpellName + "\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,0,,0,0,0,0,0,0,0,0,0,0,0,0,0,16712188,0,0,\"Summon and Dismisses " + SpellName + ".\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,0,\"Increase Speed By $s2 %.\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,133,0,0,0,0,0,0,0,0,0,0,1.000000,1.000000,1.000000,0,0,0,0,0,0,1,0,0,0,0.000000,0.000000,0.000000,0,0");
                    SpellfrFR.AppendLine((int.Parse(SpellID) + 3000000) + ",0,0,21,286359824,0,0,0,67108864,0,131072,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,31,128,0,0,101,0,0,0,1,21,0,0,0,0,0,1,0.000000,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,0,0,6,6,6,0,1,1,0.000000,0.000000,0.000000,0,59,149,0,0,0,1,1,1,0,0,0,0,0,0,78,32,207,0,0,0,0.000000,0.000000,0.000000,0,0,0,0,0,0," + CreatureID + ",0,0,2,0,0,0,0,0,0.000000,0.000000,0.000000,0,0,0,0,0,0,0,0,0,0,0," + SpellIcon + ",122,,0,0,\"" + SpellName + "\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,0,,0,0,0,0,0,0,0,0,0,0,0,0,0,16712188,0,0,\"Summon and Dismisses " + SpellName + ".\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,0,\"Increase Land Speed By $s2 %.Increase Flight Speed By $s3 %.\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,133,0,0,0,0,0,0,0,0,0,0,1.000000,1.000000,1.000000,0,0,0,0,0,0,1,0,0,0,0.000000,0.000000,0.000000,0,0");
                    SpellfrFR.AppendLine((int.Parse(SpellID) + 4000000) + ",0,0,21,286359824,0,0,0,67108864,0,131072,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,31,128,0,0,101,0,0,0,1,21,0,0,0,0,0,1,0.000000,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,0,0,6,6,6,0,1,1,0.000000,0.000000,0.000000,0,99,309,0,0,0,1,1,1,0,0,0,0,0,0,78,32,207,0,0,0,0.000000,0.000000,0.000000,0,0,0,0,0,0," + CreatureID + ",0,0,2,0,0,0,0,0,0.000000,0.000000,0.000000,0,0,0,0,0,0,0,0,0,0,0," + SpellIcon + ",122,,0,0,\"" + SpellName + "\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,0,,0,0,0,0,0,0,0,0,0,0,0,0,0,16712188,0,0,\"Summon and Dismisses " + SpellName + ". (Mount).\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,0,\"Increase Land Speed By $s2 %. Increase Flight Speed By $s3 %.\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,133,0,0,0,0,0,0,0,0,0,0,1.000000,1.000000,1.000000,0,0,0,0,0,0,1,0,0,0,0.000000,0.000000,0.000000,0,0");
                    SpellfrFR.AppendLine(SpellID + ",0,0,21,269582608,0,0,0,0,0,131072,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,16,0,0,9,4718592,0,0,101,0,0,0,0,21,0,0,0,0,0,1,0.000000,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,0,0,6,6,77,0,1,0,0.000000,0.000000,0.000000,0,-1,0,0,0,0,0,0,1,0,0,0,0,0,0,78,4,0,0,0,0,0.000000,0.000000,0.000000,0,0,0,0,0,0," + CreatureID + ",27153,0,1,0,0,0,0,0,0.000000,0.000000,0.000000,0,0,0,0,0,0,0,0,0,1706,0," + SpellIcon + ",0,,0,0,\"" + SpellName + "\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,0,,0,0,0,0,0,0,0,0,0,0,0,0,0,16712188,0,0,\"Summon and Dismisses " + SpellDescription + ". (Adaptive Mount).\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,0,,0,0,0,0,0,0,0,0,0,0,0,0,0,16712188,0,0,0,0,0,0,0,0,0,0,0,0,1.000000,1.000000,1.000000,0,0,0,0,0,0,1,0,0,0,0.000000,0.000000,0.000000,0,0");
                    // En / US
                    SpellenEN.AppendLine((int.Parse(SpellID) + 1000000) + ",0,0,21,286359824,0,0,0,0,0,131072,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,31,0,0,0,101,0,0,0,1,21,0,0,0,0,0,1,0.000000,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,0,0,6,6,0,0,1,1,0.000000,0.000000,0.000000,0,59,-1,0,0,0,1,1,0,0,0,0,0,0,0,78,32,0,0,0,0,0.000000,0.000000,0.000000,0,0,0,0,0,0," + CreatureID + ",0,0,1,0,0,0,0,0,0.000000,0.000000,0.000000,0,0,0,0,0,0,0,0,0,0,0," + SpellIcon + ",122,,0,0,\"" + SpellName + "\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,0,,0,0,0,0,0,0,0,0,0,0,0,0,0,16712188,0,0,\"Summon and Dismisses " + SpellName + ".\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,0,\"Increase Speed By $s2%.\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,133,0,0,0,0,0,0,0,0,0,0,1.000000,1.000000,1.000000,0,0,0,0,0,0,1,0,0,0,0.000000,0.000000,0.000000,0,0");
                    SpellenEN.AppendLine((int.Parse(SpellID) + 2000000) + ",0,0,21,286359824,0,0,0,0,0,131072,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,31,0,0,0,101,0,0,0,1,21,0,0,0,0,0,1,0.000000,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,0,0,6,6,0,0,1,1,0.000000,0.000000,0.000000,0,99,-1,0,0,0,1,1,0,0,0,0,0,0,0,78,32,0,0,0,0,0.000000,0.000000,0.000000,0,0,0,0,0,0," + CreatureID + ",0,0,1,0,0,0,0,0,0.000000,0.000000,0.000000,0,0,0,0,0,0,0,0,0,0,0," + SpellIcon + ",122,,0,0,\"" + SpellName + "\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,0,,0,0,0,0,0,0,0,0,0,0,0,0,0,16712188,0,0,\"Summon and Dismisses " + SpellName + ".\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,0,\"Increase Speed By $s2 %.\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,133,0,0,0,0,0,0,0,0,0,0,1.000000,1.000000,1.000000,0,0,0,0,0,0,1,0,0,0,0.000000,0.000000,0.000000,0,0");
                    SpellenEN.AppendLine((int.Parse(SpellID) + 3000000) + ",0,0,21,286359824,0,0,0,67108864,0,131072,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,31,128,0,0,101,0,0,0,1,21,0,0,0,0,0,1,0.000000,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,0,0,6,6,6,0,1,1,0.000000,0.000000,0.000000,0,59,149,0,0,0,1,1,1,0,0,0,0,0,0,78,32,207,0,0,0,0.000000,0.000000,0.000000,0,0,0,0,0,0," + CreatureID + ",0,0,2,0,0,0,0,0,0.000000,0.000000,0.000000,0,0,0,0,0,0,0,0,0,0,0," + SpellIcon + ",122,,0,0,\"" + SpellName + "\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,0,,0,0,0,0,0,0,0,0,0,0,0,0,0,16712188,0,0,\"Summon and Dismisses " + SpellName + ".\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,0,\"Increase Land Speed By $s2 %.Increase Flight Speed By $s3 %.\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,133,0,0,0,0,0,0,0,0,0,0,1.000000,1.000000,1.000000,0,0,0,0,0,0,1,0,0,0,0.000000,0.000000,0.000000,0,0");
                    SpellenEN.AppendLine((int.Parse(SpellID) + 4000000) + ",0,0,21,286359824,0,0,0,67108864,0,131072,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,31,128,0,0,101,0,0,0,1,21,0,0,0,0,0,1,0.000000,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,0,0,6,6,6,0,1,1,0.000000,0.000000,0.000000,0,99,309,0,0,0,1,1,1,0,0,0,0,0,0,78,32,207,0,0,0,0.000000,0.000000,0.000000,0,0,0,0,0,0," + CreatureID + ",0,0,2,0,0,0,0,0,0.000000,0.000000,0.000000,0,0,0,0,0,0,0,0,0,0,0," + SpellIcon + ",122,,0,0,\"" + SpellName + "\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,0,,0,0,0,0,0,0,0,0,0,0,0,0,0,16712188,0,0,\"Summon and Dismisses " + SpellName + ". (Mount).\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,0,\"Increase Land Speed By $s2 %. Increase Flight Speed By $s3 %.\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,133,0,0,0,0,0,0,0,0,0,0,1.000000,1.000000,1.000000,0,0,0,0,0,0,1,0,0,0,0.000000,0.000000,0.000000,0,0");
                    SpellenEN.AppendLine(SpellID + ",0,0,21,269582608,0,0,0,0,0,131072,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,16,0,0,9,4718592,0,0,101,0,0,0,0,21,0,0,0,0,0,1,0.000000,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,0,0,6,6,77,0,1,0,0.000000,0.000000,0.000000,0,-1,0,0,0,0,0,0,1,0,0,0,0,0,0,78,4,0,0,0,0,0.000000,0.000000,0.000000,0,0,0,0,0,0," + CreatureID + ",27153,0,1,0,0,0,0,0,0.000000,0.000000,0.000000,0,0,0,0,0,0,0,0,0,1706,0," + SpellIcon + ",0,,0,0,\"" + SpellName + "\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,0,,0,0,0,0,0,0,0,0,0,0,0,0,0,16712188,0,0,\"Summon and Dismisses " + SpellDescription + ". (Adaptive Mount).\",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,0,,0,0,0,0,0,0,0,0,0,0,0,0,0,16712188,0,0,0,0,0,0,0,0,0,0,0,0,1.000000,1.000000,1.000000,0,0,0,0,0,0,1,0,0,0,0.000000,0.000000,0.000000,0,0");

                    // Core Side Script
                    CoreScript.AppendLine("new spell_gen_mount(\"spell_" + SpellName.Replace(" ", "_").Replace("'", "").Replace("-", "_") + "\", 0, " + (int.Parse(SpellID) + 1000000) + ", " + (int.Parse(SpellID) + 2000000) + ", " + (int.Parse(SpellID) + 3000000) + ", " + (int.Parse(SpellID) + 4000000) + ");");
                    // SQL SIDE Script
                    SpellScriptNameSQL.AppendLine("INSERT INTO `Spell_Script_Names` VALUES (" + SpellID + "," + "\"spell_" + SpellName.Replace(" ", "_").Replace("'", "").Replace("-", "_") + "\");");
                    break;
            }
            Creature_TemplateSQL.AppendLine("INSERT INTO `creature_template` (`entry`, `difficulty_entry_1`, `difficulty_entry_2`, `difficulty_entry_3`, `KillCredit1`, `KillCredit2`, `modelid1`, `modelid2`, `modelid3`, `modelid4`, `name`, `subname`, `IconName`, `gossip_menu_id`, `minlevel`, `maxlevel`, `exp`, `faction`, `npcflag`, `speed_walk`, `speed_run`, `scale`, `rank`, `dmgschool`, `BaseAttackTime`, `RangeAttackTime`, `BaseVariance`, `RangeVariance`, `unit_class`, `unit_flags`, `unit_flags2`, `dynamicflags`, `family`, `trainer_type`, `trainer_spell`, `trainer_class`, `trainer_race`, `type`, `type_flags`, `lootid`, `pickpocketloot`, `skinloot`, `resistance1`, `resistance2`, `resistance3`, `resistance4`, `resistance5`, `resistance6`, `spell1`, `spell2`, `spell3`, `spell4`, `spell5`, `spell6`, `spell7`, `spell8`, `PetSpellDataId`, `VehicleId`, `mingold`, `maxgold`, `AIName`, `MovementType`, `InhabitType`, `HoverHeight`, `HealthModifier`, `ManaModifier`, `ArmorModifier`, `DamageModifier`, `ExperienceModifier`, `RacialLeader`, `movementId`, `RegenHealth`, `mechanic_immune_mask`, `flags_extra`, `ScriptName`, `VerifiedBuild`) VALUES " +
                       "(" + CreatureID + ", 0, 0, 0, 0, 0," + CreatureDisplayID + ", 0, 0, 0, " + "\"" + SpellName + "\"" + ", NULL, NULL, 0, 2, 2, 0, 35, 0, 0.91, 1.14286, 1, 0, 0, 2000, 2200, 1, 1, 1, 0, 2048, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '', 0, 3, 1, 1, 1, 1, 1, 1, 0, 140, 1, 0, 2, '', 27500); ");
            Creature_Model_SQL.AppendLine("INSERT INTO `creature_model_info` VALUES (" + CreatureDisplayID + "0, 0, 2, 0);");

            if (!Directory.Exists(@".\Mounts"))
            {
                Directory.CreateDirectory(@".\Mounts");
                Directory.CreateDirectory(@".\Mounts\enEN");
                Directory.CreateDirectory(@".\Mounts\frFR");
                Directory.CreateDirectory(@".\Mounts\SQL");
                Directory.CreateDirectory(@".\Mounts\CPP");
            }

            File.WriteAllText("./Mounts/frFR/Spell_" + SpellID + ".dbc.csv", SpellfrFR.ToString());
            File.WriteAllText("./Mounts/enEN/Spell_" + SpellID + ".dbc.csv", SpellenEN.ToString());
            File.WriteAllText("./Mounts/CPP/CoreScript.cpp", CoreScript.ToString());
            File.WriteAllText("./Mounts/SQL/SqlScript.sql", SpellScriptNameSQL.ToString());
            File.WriteAllText("./Mounts/SQL/Mount_Creature_Template.sql", Creature_TemplateSQL.ToString());
            File.WriteAllText("./Mounts/SQL/Mount_Creature_Model_Info.sql", Creature_Model_SQL.ToString());
        }
    }
}
