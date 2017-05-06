using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MountPetGenerator
{
    class PetGenerator
    {
        public static void GeneratePetSQL(string PetSpellID, string PetSpellName, string SpellIconID, string SpellIcon, string CreatureID, string CreatureDisplayID)
        {
            string builder;
            StringBuilder NewPet = new StringBuilder();

            builder = PetSpellID + "," +
                CreatureID + "," +
                CreatureDisplayID + "," +
                "0" + "," + "\"" +
                PetSpellName + "\"" + "," +
                "NULL" + "," + "\"" +
                SpellIcon + "\"" + "," +
                SpellIconID;
            // Create
            NewPet.AppendLine("INSERT INTO `pets` VALUES (" + builder + ");");
            File.WriteAllText(@".\Pets\Listfile\" + PetSpellID + ".sql", NewPet.ToString());
        }

        public static void GeneratePetDBC(string PetSpellID, string PetSpellName, string SpellIconID, string SpellIcon, string CreatureID, string CreatureDisplayID)
        {
            StringBuilder frSpell = new StringBuilder();
            StringBuilder enSpell = new StringBuilder();
            StringBuilder CreatureSQL = new StringBuilder();
            StringBuilder CreatureModel = new StringBuilder();

            frSpell.AppendLine(PetSpellID + ",0,0,0,262416,0,0,536870912,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,31,0,0,0,101,0,0,0,0,21,0,0,0,0,0,1,0.000000,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,0,0,28,0,0,1,0,0,0.000000,0.000000,0.000000,0,0,0,0,0,0,32,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1000.000000,0.000000,0.000000,0,0,0,0,0,0," + CreatureID + ",0,0,41,0,0,0,0,0,0.000000,0.000000,0.000000,0,0,0,0,0,0,0,0,0,353,0," + SpellIcon + ",0,0,0,0," + "\"" + PetSpellName + "\"" + ",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,0,,0,0,0,0,0,0,0,0,0,0,0,0,0,16712188,0,0,\"Cliquez droit pour invoquer ou renvoyer " + PetSpellName + ".\", 0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,0,,0,0,0,0,0,0,0,0,0,0,0,0,0,16712188,0,133,1500,0,0,0,0,0,0,0,0,0,1.000000,1.000000,1.000000,0,0,0,0,0,0,1,0,0,0,0.000000,0.000000,0.000000,0,0");
            enSpell.AppendLine(PetSpellID + ",0,0,0,262416,0,0,536870912,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,31,0,0,0,101,0,0,0,0,21,0,0,0,0,0,1,0.000000,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,0,0,28,0,0,1,0,0,0.000000,0.000000,0.000000,0,0,0,0,0,0,32,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1000.000000,0.000000,0.000000,0,0,0,0,0,0," + CreatureID + ",0,0,41,0,0,0,0,0,0.000000,0.000000,0.000000,0,0,0,0,0,0,0,0,0,353,0," + SpellIcon + ",0,0," + "\"" + PetSpellName + "\"" + ",0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,16712188,\"Right - click to summon and dismiss " + PetSpellName + ".\",0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,16712188,0,133,1500,0,0,0,0,0,0,0,0,0,1.000000,1.000000,1.000000,0,0,0,0,0,0,1,0,0,0,0.000000,0.000000,0.000000,0,0");
            
            CreatureSQL.AppendLine("insert into `creature_template` " +
                "(`entry`, `difficulty_entry_1`, `difficulty_entry_2`, `difficulty_entry_3`, `KillCredit1`, `KillCredit2`, `modelid1`, `modelid2`, `modelid3`, `modelid4`, `name`, `subname`, `IconName`, `gossip_menu_id`, `minlevel`, `maxlevel`, `exp`, `faction`, `npcflag`, `speed_walk`, `speed_run`, `scale`, `rank`, `dmgschool`, `BaseAttackTime`, `RangeAttackTime`, `BaseVariance`, `RangeVariance`, `unit_class`, `unit_flags`, `unit_flags2`, `dynamicflags`, `family`, `trainer_type`, `trainer_spell`, `trainer_class`, `trainer_race`, `type`, `type_flags`, `lootid`, `pickpocketloot`, `skinloot`, `resistance1`, `resistance2`, `resistance3`, `resistance4`, `resistance5`, `resistance6`, `spell1`, `spell2`, `spell3`, `spell4`, `spell5`, `spell6`, `spell7`, `spell8`, `PetSpellDataId`, `VehicleId`, `mingold`, `maxgold`, `AIName`, `MovementType`, `InhabitType`, `HoverHeight`, `HealthModifier`, `ManaModifier`, `ArmorModifier`, `DamageModifier`, `ExperienceModifier`, `RacialLeader`, `movementId`, `RegenHealth`, `mechanic_immune_mask`, `flags_extra`, `ScriptName`, `VerifiedBuild`) values" +
                "(" + CreatureID + ",'0','0','0','0','0'," + CreatureDisplayID + ",'0','0','0'," + "'" + PetSpellName.Replace("'", "\\'") + "'" + ",'','','0','1','1','0','188','0','1','1.14286','1','0','0','2000','2000','1','1','1','0','2048','0','0','0','0','0','0','12','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','','0','3','1','1','1','1','1','1','0','121','1','0','0','','12340');");

            CreatureModel.AppendLine("INSERT INTO `creature_model_info` Values (" + CreatureDisplayID + ",0, 0, 2, 0);");

            if (!Directory.Exists(@".\Pet"))
            {
                Directory.CreateDirectory(@".\Pet\SQL");
                Directory.CreateDirectory(@".\Pet\enEN");
                Directory.CreateDirectory(@".\Pet\frFR");
            }

            File.WriteAllText("./Pet/frFR/Spell.dbc.csv", frSpell.ToString());
            File.WriteAllText("./Pet/enEN/Spell.dbc.csv", enSpell.ToString());
            File.WriteAllText("./Pet/SQL/Creature_Template_Pet.sql", CreatureSQL.ToString());
            File.WriteAllText("./Pet/SQL/Creature_Model_Pet.sql", CreatureModel.ToString());
        }
    }
}
