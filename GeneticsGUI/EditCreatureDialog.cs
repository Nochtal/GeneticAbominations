﻿using System;
using System.Windows.Forms;
using GeneticDLL;

namespace GeneticsGUI
{
    public partial class EditCreatureDialog : Form
    {
        public EditCreatureDialog()
        {
            InitializeComponent();
        }
        
        private void EditCreatureDialog_Load(object sender, EventArgs e)
        {
            MinimizeBox = false;
            MaximizeBox = false;
        }

        /// <summary>
        ///  OK Button... 
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// CANCEL Button...
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void label16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HUZZUH!", "You found the secret button!", MessageBoxButtons.OK);
        }

        private void label41_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wah Wah!", "This isn't a secret button.", MessageBoxButtons.OK);
        }

        private void numericUpDown13_ValueChanged(object sender, EventArgs e)
        {
            
        }

        public Creature ReturnCreature { get; set; }
        string NAME;
        int AGE;
        int GENERATION;
        string PARENTONE;
        string PARENTTWO;
        DNA _DNA;
        Helix A_HELIX, B_HELIX;
        Gene A_RACE, A_STRENGTH, A_DEXTERITY, A_CONSTITUTION, A_INTELLIGENCE, A_WISDOM, A_CHARISMA, A_ARCANE, A_DIVINE, B_RACE, B_STRENGTH, B_DEXTERITY, B_CONSTITUTION, B_INTELLIGENCE, B_WISDOM, B_CHARISMA, B_ARCANE, B_DIVINE;

        private void cboAlphaDivine_CheckedChanged(object sender, EventArgs e)
        {
            if (cboAlphaDivine.Checked)
            {
                A_DIVINE = new Gene();
                nudAlphaDivineValue.Value = A_DIVINE.Value;
                nudAlphaDivineWeight.Value = A_DIVINE.Weight;
                nudAlphaDivineDeviation.Value = A_DIVINE.Deviation;
                nudAlphaDivineValue.ReadOnly = true;
                nudAlphaDivineWeight.ReadOnly = true;
                nudAlphaDivineDeviation.ReadOnly = true;
            }
            else
            {
                nudAlphaDivineValue.ReadOnly = false;
                nudAlphaDivineWeight.ReadOnly = false;
                nudAlphaDivineDeviation.ReadOnly = false;
            }
        }

        private void cboAlphaArcane_CheckedChanged(object sender, EventArgs e)
        {
            if (cboAlphaArcane.Checked)
            {
                A_ARCANE = new Gene();
                nudAlphaArcaneValue.Value = A_ARCANE.Value;
                nudAlphaArcaneWeight.Value = A_ARCANE.Weight;
                nudAlphaArcaneDeviation.Value = A_ARCANE.Deviation;
                nudAlphaArcaneValue.ReadOnly = true;
                nudAlphaArcaneWeight.ReadOnly = true;
                nudAlphaArcaneDeviation.ReadOnly = true;
            }
            else
            {
                nudAlphaArcaneValue.ReadOnly = false;
                nudAlphaArcaneWeight.ReadOnly = false;
                nudAlphaArcaneDeviation.ReadOnly = false;
            }
        }

        private void cboBetaRace_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }

        private void cboAlphaCharisma_CheckedChanged(object sender, EventArgs e)
        {
            if (cboAlphaCharisma.Checked)
            {
                A_CHARISMA = new Gene();
                nudAlphaCharismaValue.Value = A_CHARISMA.Value;
                nudAlphaCharismaWeight.Value = A_CHARISMA.Weight;
                nudAlphaCharismaDeviation.Value = A_CHARISMA.Deviation;
                nudAlphaCharismaValue.ReadOnly = true;
                nudAlphaCharismaWeight.ReadOnly = true;
                nudAlphaCharismaDeviation.ReadOnly = true;
            }
            else
            {
                nudAlphaCharismaValue.ReadOnly = false;
                nudAlphaCharismaWeight.ReadOnly = false;
                nudAlphaCharismaDeviation.ReadOnly = false;
            }
        }

        private void cboAlphaWisdom_CheckedChanged(object sender, EventArgs e)
        {
            if (cboAlphaWisdom.Checked)
            {
                A_WISDOM = new Gene();
                nudAlphaWisdomValue.Value = A_WISDOM.Value;
                nudAlphaWisdomWeight.Value = A_WISDOM.Weight;
                nudAlphaWisdomDeviation.Value = A_WISDOM.Deviation;
                nudAlphaWisdomValue.ReadOnly = true;
                nudAlphaWisdomWeight.ReadOnly = true;
                nudAlphaWisdomDeviation.ReadOnly = true;
            }
            else
            {
                nudAlphaWisdomValue.ReadOnly = false;
                nudAlphaWisdomWeight.ReadOnly = false;
                nudAlphaWisdomDeviation.ReadOnly = false;
            }
        }

        private void cboAlphaIntelligence_CheckedChanged(object sender, EventArgs e)
        {
            if (cboAlphaIntelligence.Checked)
            {
                A_INTELLIGENCE = new Gene();
                nudAlphaIntelligenceValue.Value = A_INTELLIGENCE.Value;
                nudAlphaIntelligenceWeight.Value = A_INTELLIGENCE.Weight;
                nudAlphaIntelligenceDeviation.Value = A_INTELLIGENCE.Deviation;
                nudAlphaIntelligenceValue.ReadOnly = true;
                nudAlphaIntelligenceWeight.ReadOnly = true;
                nudAlphaIntelligenceDeviation.ReadOnly = true;
            }
            else
            {
                nudAlphaIntelligenceValue.ReadOnly = false;
                nudAlphaIntelligenceWeight.ReadOnly = false;
                nudAlphaIntelligenceDeviation.ReadOnly = false;
            }
        }

        private void cboAlphaConstitution_CheckedChanged(object sender, EventArgs e)
        {
            if (cboAlphaConstitution.Checked)
            {
                A_CONSTITUTION = new Gene();
                nudAlphaConstitutionValue.Value = A_CONSTITUTION.Value;
                nudAlphaConstitutionWeight.Value = A_CONSTITUTION.Weight;
                nudAlphaConstitutionDeviation.Value = A_CONSTITUTION.Deviation;
                nudAlphaConstitutionValue.ReadOnly = true;
                nudAlphaConstitutionWeight.ReadOnly = true;
                nudAlphaConstitutionDeviation.ReadOnly = true;
            }
            else
            {
                nudAlphaConstitutionValue.ReadOnly = false;
                nudAlphaConstitutionWeight.ReadOnly = false;
                nudAlphaConstitutionDeviation.ReadOnly = false;
            }
        }

        private void cboAlphaDexterity_CheckedChanged(object sender, EventArgs e)
        {
            if (cboAlphaDexterity.Checked)
            {
                A_DEXTERITY = new Gene();
                nudAlphaDexterityValue.Value = A_DEXTERITY.Value;
                nudAlphaDexterityWeight.Value = A_DEXTERITY.Weight;
                nudAlphaDexterityDeviation.Value = A_DEXTERITY.Deviation;
                nudAlphaDexterityValue.ReadOnly = true;
                nudAlphaDexterityWeight.ReadOnly = true;
                nudAlphaDexterityDeviation.ReadOnly = true;
            }
            else
            {
                nudAlphaDexterityValue.ReadOnly = false;
                nudAlphaDexterityWeight.ReadOnly = false;
                nudAlphaDexterityDeviation.ReadOnly = false;
            }
        }

        private void cboAlphaStrength_CheckedChanged(object sender, EventArgs e)
        {
            if (cboAlphaStrength.Checked)
            {
                A_STRENGTH = new Gene();
                nudAlphaStrengthValue.Value = A_STRENGTH.Value;
                nudAlphaStrengthWeight.Value = A_STRENGTH.Weight;
                nudAlphaStrengthDeviation.Value = A_STRENGTH.Deviation;
                nudAlphaStrengthValue.ReadOnly = true;
                nudAlphaStrengthWeight.ReadOnly = true;
                nudAlphaStrengthDeviation.ReadOnly = true;
            }
            else
            {
                nudAlphaStrengthValue.ReadOnly = false;
                nudAlphaStrengthWeight.ReadOnly = false;
                nudAlphaStrengthDeviation.ReadOnly = false;
            }
        }

        private void cboAlphaRace_CheckedChanged(object sender, EventArgs e)
        {
            if (cboAlphaRace.Checked)
            {
                A_RACE = new Gene();
                nudAlphaRaceValue.Value = A_RACE.Value;
                nudAlphaRaceWeight.Value = A_RACE.Weight;
                nudAlphaRaceDeviation.Value = A_RACE.Deviation;
                nudAlphaRaceValue.ReadOnly = true;
                nudAlphaRaceWeight.ReadOnly = true;
                nudAlphaRaceDeviation.ReadOnly = true;
            }
            else
            {
                nudAlphaRaceValue.ReadOnly = false;
                nudAlphaRaceWeight.ReadOnly = false;
                nudAlphaRaceDeviation.ReadOnly = false;
            }
        }

        private void cboBetaDivine_CheckedChanged(object sender, EventArgs e)
        {
            if (cboBetaDivine.Checked)
            {
                B_DIVINE = new Gene();
                nudBetaDivineValue.Value = B_DIVINE.Value;
                nudBetaDivineWeight.Value = B_DIVINE.Weight;
                nudBetaDivineDeviation.Value = B_DIVINE.Deviation;
                nudBetaDivineValue.ReadOnly = true;
                nudBetaDivineWeight.ReadOnly = true;
                nudBetaDivineDeviation.ReadOnly = true;
            }
            else
            {
                nudBetaDivineValue.ReadOnly = false;
                nudBetaDivineWeight.ReadOnly = false;
                nudBetaDivineDeviation.ReadOnly = false;
            }
        }

        private void cboBetaArcane_CheckedChanged(object sender, EventArgs e)
        {
            if (cboBetaArcane.Checked)
            {
                B_ARCANE = new Gene();
                nudBetaArcaneValue.Value = B_ARCANE.Value;
                nudBetaArcaneWeight.Value = B_ARCANE.Weight;
                nudBetaArcaneDeviation.Value = B_ARCANE.Deviation;
                nudBetaArcaneValue.ReadOnly = true;
                nudBetaArcaneWeight.ReadOnly = true;
                nudBetaArcaneDeviation.ReadOnly = true;
            }
            else
            {
                nudBetaArcaneValue.ReadOnly = false;
                nudBetaArcaneWeight.ReadOnly = false;
                nudBetaArcaneDeviation.ReadOnly = false;
            }
        }

        private void cboBetaCharisma_CheckedChanged(object sender, EventArgs e)
        {
            if (cboBetaCharisma.Checked)
            {
                B_CHARISMA = new Gene();
                nudBetaCharismaValue.Value = B_CHARISMA.Value;
                nudBetaCharismaWeight.Value = B_CHARISMA.Weight;
                nudBetaCharismaDeviation.Value = B_CHARISMA.Deviation;
                nudBetaCharismaValue.ReadOnly = true;
                nudBetaCharismaWeight.ReadOnly = true;
                nudBetaCharismaDeviation.ReadOnly = true;
            }
            else
            {
                nudBetaCharismaValue.ReadOnly = false;
                nudBetaCharismaWeight.ReadOnly = false;
                nudBetaCharismaDeviation.ReadOnly = false;
            }
        }

        private void cboBetaWisdom_CheckedChanged(object sender, EventArgs e)
        {
            if (cboBetaWisdom.Checked)
            {
                B_WISDOM = new Gene();
                nudBetaWisdomValue.Value = B_WISDOM.Value;
                nudBetaWisdomWeight.Value = B_WISDOM.Weight;
                nudBetaWisdomDeviation.Value = B_WISDOM.Deviation;
                nudBetaWisdomValue.ReadOnly = true;
                nudBetaWisdomWeight.ReadOnly = true;
                nudBetaWisdomDeviation.ReadOnly = true;
            }
            else
            {
                nudBetaWisdomValue.ReadOnly = false;
                nudBetaWisdomWeight.ReadOnly = false;
                nudBetaWisdomDeviation.ReadOnly = false;
            }
        }

        private void cboBetaIntelligence_CheckedChanged(object sender, EventArgs e)
        {
            if (cboBetaIntelligence.Checked)
            {
                B_INTELLIGENCE = new Gene();
                nudBetaIntelligenceValue.Value = B_INTELLIGENCE.Value;
                nudBetaIntelligenceWeight.Value = B_INTELLIGENCE.Weight;
                nudBetaIntelligenceDeviation.Value = B_INTELLIGENCE.Deviation;
                nudBetaIntelligenceValue.ReadOnly = true;
                nudBetaIntelligenceWeight.ReadOnly = true;
                nudBetaIntelligenceDeviation.ReadOnly = true;
            }
            else
            {
                nudBetaIntelligenceValue.ReadOnly = false;
                nudBetaIntelligenceWeight.ReadOnly = false;
                nudBetaIntelligenceDeviation.ReadOnly = false;
            }
        }

        private void cboBetaConstitution_CheckedChanged(object sender, EventArgs e)
        {
            if (cboBetaConstitution.Checked)
            {
                B_CONSTITUTION = new Gene();
                nudBetaConstitutionValue.Value = B_CONSTITUTION.Value;
                nudBetaConstitutionWeight.Value = B_CONSTITUTION.Weight;
                nudBetaConstitutionDeviation.Value = B_CONSTITUTION.Deviation;
                nudBetaConstitutionValue.ReadOnly = true;
                nudBetaConstitutionWeight.ReadOnly = true;
                nudBetaConstitutionDeviation.ReadOnly = true;
            }
            else
            {
                nudBetaConstitutionValue.ReadOnly = false;
                nudBetaConstitutionWeight.ReadOnly = false;
                nudBetaConstitutionDeviation.ReadOnly = false;
            }
        }

        private void cboBetaDexterity_CheckedChanged(object sender, EventArgs e)
        {
            if (cboBetaDexterity.Checked)
            {
                B_DEXTERITY = new Gene();
                nudBetaDexterityValue.Value = B_DEXTERITY.Value;
                nudBetaDexterityWeight.Value = B_DEXTERITY.Weight;
                nudBetaDexterityDeviation.Value = B_DEXTERITY.Deviation;
                nudBetaDexterityValue.ReadOnly = true;
                nudBetaDexterityWeight.ReadOnly = true;
                nudBetaDexterityDeviation.ReadOnly = true;
            }
            else
            {
                nudBetaDexterityValue.ReadOnly = false;
                nudBetaDexterityWeight.ReadOnly = false;
                nudBetaDexterityDeviation.ReadOnly = false;
            }
        }

        private void cboBetaStrength_CheckedChanged(object sender, EventArgs e)
        {
            if (cboBetaStrength.Checked)
            {
                B_STRENGTH = new Gene();
                nudBetaStrengthValue.Value = B_STRENGTH.Value;
                nudBetaStrengthWeight.Value = B_STRENGTH.Weight;
                nudBetaStrengthDeviation.Value = B_STRENGTH.Deviation;
                nudBetaStrengthValue.ReadOnly = true;
                nudBetaStrengthWeight.ReadOnly = true;
                nudBetaStrengthDeviation.ReadOnly = true;
            }
            else
            {
                nudBetaStrengthValue.ReadOnly = false;
                nudBetaStrengthWeight.ReadOnly = false;
                nudBetaStrengthDeviation.ReadOnly = false;
            }
        }

        private void cboBetaRace_CheckedChanged(object sender, EventArgs e)
        {
            if (cboBetaRace.Checked)
            {
                B_RACE = new Gene();
                nudBetaRaceValue.Value = B_RACE.Value;
                nudBetaRaceWeight.Value = B_RACE.Weight;
                nudBetaRaceDeviation.Value = B_RACE.Deviation;
                nudBetaRaceValue.ReadOnly = true;
                nudBetaRaceWeight.ReadOnly = true;
                nudBetaRaceDeviation.ReadOnly = true;
            }
            else
            {
                nudBetaRaceValue.ReadOnly = false;
                nudBetaRaceWeight.ReadOnly = false;
                nudBetaRaceDeviation.ReadOnly = false;
            }
        }

        private void cbxParentsRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxParentsRandom.Checked)
            {
                txtParentOne.Text = ExtensionMethods.GenerateName();
                txtParentTwo.Text = ExtensionMethods.GenerateName();
                txtParentOne.ReadOnly = true;
                txtParentTwo.ReadOnly = true;
            }
            else
            {
                txtParentOne.ReadOnly = false;
                txtParentTwo.ReadOnly = false;
            }
        }

        private void cbxNameRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxNameRandom.Checked)
            {
                txtName.Text = ExtensionMethods.GenerateName();
                txtName.ReadOnly = true;
            }
            else txtName.ReadOnly = false;
        }
    }
}