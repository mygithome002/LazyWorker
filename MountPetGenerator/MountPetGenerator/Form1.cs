using LazyWorkerTool;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MountPetGenerator
{
    public partial class Form1 : Form
    {
        static ConcurrentDictionary<string, string> _dict = new ConcurrentDictionary<string, string> { };
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnGeneratePet_Click(object sender, EventArgs e)
        {
            // Member Variables
            string PetSpellID, PetSpellName, SpellIconID, SpellIcon, CreatureID, CreatureDisplayID;
           
            // Assignement
            PetSpellID = txtPetSpellID.Text;
            PetSpellName = txtPetName.Text;
            SpellIconID = txtPetIconID.Text;
            SpellIcon = txtPetIcon.Text;
            CreatureID = txtPetCreatureID.Text;
            CreatureDisplayID = txtPetDisplayID.Text.Replace(" ", "");

            PetGenerator.GeneratePetDBC(PetSpellID, PetSpellName, SpellIconID, SpellIcon, CreatureID, CreatureDisplayID);
            PetGenerator.GeneratePetSQL(PetSpellID, PetSpellName, SpellIconID, SpellIcon, CreatureID, CreatureDisplayID); // listing
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPetSpellID.Text = "";
            txtPetName.Text = "";
            txtPetIconID.Text = "";
            txtPetIcon.Text = "";
            txtPetCreatureID.Text = "";
            txtPetDisplayID.Text = "";
        }

        private void btnGenerateMount_Click(object sender, EventArgs e)
        {

            string CreatureID, CreatureDisplayID, SpellID, SpellIcon, SpellName, SpellDescription;
            string Type;

            CreatureDisplayID = txtMountDisplayID.Text;
            CreatureID = txtMountCreatureID.Text;
            SpellID = txtMountSpellID.Text;
            SpellIcon = txtMountIconID.Text;
            SpellName = txtMountName.Text;
            SpellDescription = rtxtDescription.Text;
            Type = cbxType.Text;

            MountGenerator.GenerateMount(CreatureID, CreatureDisplayID, SpellID, SpellIcon, SpellName, SpellDescription, Type);
        }


        private void txtMountIconName_TextChanged(object sender, EventArgs e)
        {
            txtMountIconID.Text = GetKeyAdress(txtPetIcon.Text.ToLower());
        }

        private void txtPetIcon_TextChanged(object sender, EventArgs e)
        {
            txtPetIconID.Text = GetKeyAdress(txtPetIcon.Text.ToLower());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string XMLFilePath = "./SpellIcon.xml";
            XElement doc = XElement.Load(XMLFilePath);
            IEnumerable<XElement> nodes = doc.Elements();
            string IconID, IconName;
            IconName = "";
            IconID = "";

            foreach (var node in nodes)
            {
                IconID = node.Element("ID").Value;
                IconName = node.Element("SpellIcon").Value;

                _dict.TryAdd(IconName.ToLower(), IconID);
            }
        }

        public static string GetKeyAdress(string Key)
        {
            // Try to get the result in the static Dictionary
            string result;
            if (_dict.TryGetValue(Key, out result))
                return result;
            else
                return "0";
        }

        private void btnItemSetGenerate_Click(object sender, EventArgs e)
        {
            string NameHead, NameShoulder, NameChest, NameHands, NameLegs;
            string DisplayHead, DisplayShoulder, DisplayChest, DisplayHands, DisplayLegs;
            string BaseEntry, Class;
            bool type;
            float Coeficient;
            int itemsetID = int.Parse(txtTierSetID.Text);
            // Name
            NameHead = txtItemSetHead.Text.Replace("'", "\\'");
            NameShoulder = txtItemSetShoulder.Text.Replace("'", "\\'");
            NameChest = txtItemSetChest.Text.Replace("'", "\\'");
            NameHands = txtItemSetHand.Text.Replace("'", "\\'");
            NameLegs = txtItemSetLegs.Text.Replace("'", "\\'");
            // Entry
            BaseEntry = txtItemSetBaseEntry.Text;
            // DisplayID
            DisplayHead = txtItemSetDHead.Text;
            DisplayShoulder = txtItemSetDShoulder.Text;
            DisplayChest = txtItemSetDChest.Text;
            DisplayHands = txtItemSetDHand.Text;
            DisplayLegs = txtItemSetDLegs.Text;
            // ComboBox
            Class = cbxclass.Text;
            Coeficient = float.Parse(cbxItemSetBaseMultiplier.Text.Replace("x", ""));
            type = cbxPvP.Checked;

            TierSetGenerator.GenerateTierSet(NameHead, NameShoulder, NameChest, NameHands, NameLegs, DisplayHead, DisplayShoulder, DisplayChest, DisplayHands, DisplayLegs,
                BaseEntry, Class, type, Coeficient, itemsetID, int.Parse(txtTierSetILvL.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            Form2 settingsForm = new Form2();

            // Show the settings form
            settingsForm.Show();
        }

        private void btnGenerateTitle_Click(object sender, EventArgs e)
        {
            string TitleMale, TitleFemale;
            int TitleID;

            TitleMale = txtTitleMale.Text;
            TitleFemale = txtTitleFemale.Text;
            TitleID = int.Parse(txtTitleID.Text);
            TitleGenerator.GenerateTitle(TitleMale, TitleFemale, TitleID, "");
        }

        private void btnTitleConstruct_Click(object sender, EventArgs e)
        {
            TitleGenerator.TitleMergeToDbc();
        }

        private void btnGenerateGem_Click(object sender, EventArgs e)
        {
            int GemProperties;
            GemProperties = int.Parse(txtGemPropID.Text);

            GemGenerator.GenerateGem(GemProperties, cbxGemColor.Text);
            GemGenerator.GenerateGemItemEnchantement(GemProperties, cbxGemType1.Text, txtGemStats1.Text, cbxGemType2.Text, txtGemStats2.Text, txtGemItemID.Text, cbxMultiStats.Checked);
            GemGenerator.GenerateGemSQL(GemProperties, cbxGemColor.Text.After("- "), txtGemName.Text, int.Parse(txtGemItemID.Text), int.Parse(txtGemDisplayID.Text), cbxGemQuality.Text.Before(" -"));
        }

        private void cbxMultiStats_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxMultiStats.Checked)
            {
                cbxGemType2.Enabled = true;
                txtGemStats2.Enabled = true;
            }
            else
            {
                cbxGemType2.Enabled = false;
                txtGemStats2.Enabled = false;
            }
        }
    }
}
