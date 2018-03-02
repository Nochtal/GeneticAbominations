using System;
using System.Windows.Forms;
using GeneticDLL;
using System.Text;

namespace GeneticsGUI
{
    public partial class EditCreatureDialog : Form
    {
        public EditCreatureDialog()
        {
            InitializeComponent();
        }

        public EditCreatureDialog(Creature c)
        {
            InitializeComponent();
            ReturnCreature = c;
        }
        
        private void EditCreatureDialog_Load(object sender, EventArgs e)
        {
            MinimizeBox = false;
            MaximizeBox = false;
            if (ReturnCreature != null)
            {
                _DNA = ReturnCreature.Genetics;
                A_HELIX = ReturnCreature.Genetics.Alpha;
                B_HELIX = ReturnCreature.Genetics.Beta;
                A_RACE = ReturnCreature.Genetics.Alpha.Race;
                A_STRENGTH = ReturnCreature.Genetics.Alpha.Strength;
                A_DEXTERITY = ReturnCreature.Genetics.Alpha.Dexterity;
                A_CONSTITUTION = ReturnCreature.Genetics.Alpha.Constitution;
                A_INTELLIGENCE = ReturnCreature.Genetics.Alpha.Intelligence;
                A_WISDOM = ReturnCreature.Genetics.Alpha.Wisdom;
                A_CHARISMA = ReturnCreature.Genetics.Alpha.Charisma;
                A_ARCANE = ReturnCreature.Genetics.Alpha.Arcane;
                A_DIVINE = ReturnCreature.Genetics.Alpha.Divine;
                B_RACE = ReturnCreature.Genetics.Beta.Race;
                B_STRENGTH = ReturnCreature.Genetics.Beta.Strength;
                B_DEXTERITY = ReturnCreature.Genetics.Beta.Dexterity;
                B_CONSTITUTION = ReturnCreature.Genetics.Beta.Constitution;
                B_INTELLIGENCE = ReturnCreature.Genetics.Beta.Intelligence;
                B_WISDOM = ReturnCreature.Genetics.Beta.Wisdom;
                B_CHARISMA = ReturnCreature.Genetics.Beta.Charisma;
                B_ARCANE = ReturnCreature.Genetics.Beta.Arcane;
                B_DIVINE = ReturnCreature.Genetics.Beta.Divine;
                FillSheet();
            }
        }

        private void FillSheet()
        {
            txtName.Text = ReturnCreature.Name;
            nudAge.Value = ReturnCreature.Age;
            nudGeneration.Value = ReturnCreature.Generation;
            txtParentOne.Text = ReturnCreature.ParentOne;
            txtParentTwo.Text = ReturnCreature.ParentTwo;
            nudAlphaRaceValue.Value = A_RACE.Value;
            nudAlphaRaceWeight.Value = A_RACE.Weight;
            nudAlphaRaceDeviation.Value = A_RACE.Deviation;
            nudAlphaStrengthValue.Value = A_STRENGTH.Value;
            nudAlphaStrengthWeight.Value = A_STRENGTH.Weight;
            nudAlphaStrengthDeviation.Value = A_STRENGTH.Deviation;
            nudAlphaDexterityValue.Value = A_DEXTERITY.Value;
            nudAlphaDexterityWeight.Value = A_DEXTERITY.Weight;
            nudAlphaDexterityDeviation.Value = A_DEXTERITY.Deviation;
            nudAlphaConstitutionValue.Value = A_CONSTITUTION.Value;
            nudAlphaConstitutionWeight.Value = A_CONSTITUTION.Weight;
            nudAlphaConstitutionDeviation.Value = A_CONSTITUTION.Deviation;
            nudAlphaIntelligenceValue.Value = A_INTELLIGENCE.Value;
            nudAlphaIntelligenceWeight.Value = A_INTELLIGENCE.Weight;
            nudAlphaIntelligenceDeviation.Value = A_INTELLIGENCE.Deviation;
            nudAlphaWisdomValue.Value = A_WISDOM.Value;
            nudAlphaWisdomWeight.Value = A_WISDOM.Weight;
            nudAlphaWisdomDeviation.Value = A_WISDOM.Deviation;
            nudAlphaCharismaValue.Value = A_CHARISMA.Value;
            nudAlphaCharismaWeight.Value = A_CHARISMA.Weight;
            nudAlphaCharismaDeviation.Value = A_CHARISMA.Deviation;
            nudAlphaArcaneValue.Value = A_ARCANE.Value;
            nudAlphaArcaneWeight.Value = A_ARCANE.Weight;
            nudAlphaArcaneDeviation.Value = A_ARCANE.Deviation;
            nudAlphaDivineValue.Value = A_DIVINE.Value;
            nudAlphaDivineWeight.Value = A_DIVINE.Weight;
            nudAlphaDivineDeviation.Value = A_DIVINE.Deviation;
            nudBetaRaceValue.Value = B_RACE.Value;
            nudBetaRaceWeight.Value = B_RACE.Weight;
            nudBetaRaceDeviation.Value = B_RACE.Deviation;
            nudBetaStrengthValue.Value = B_STRENGTH.Value;
            nudBetaStrengthWeight.Value = B_STRENGTH.Weight;
            nudBetaStrengthDeviation.Value = B_STRENGTH.Deviation;
            nudBetaDexterityValue.Value = B_DEXTERITY.Value;
            nudBetaDexterityWeight.Value = B_DEXTERITY.Weight;
            nudBetaDexterityDeviation.Value = B_DEXTERITY.Deviation;
            nudBetaConstitutionValue.Value = B_CONSTITUTION.Value;
            nudBetaConstitutionWeight.Value = B_CONSTITUTION.Weight;
            nudBetaConstitutionDeviation.Value = B_CONSTITUTION.Deviation;
            nudBetaIntelligenceValue.Value = B_INTELLIGENCE.Value;
            nudBetaIntelligenceWeight.Value = B_INTELLIGENCE.Weight;
            nudBetaIntelligenceDeviation.Value = B_INTELLIGENCE.Deviation;
            nudBetaWisdomValue.Value = B_WISDOM.Value;
            nudBetaWisdomWeight.Value = B_WISDOM.Weight;
            nudBetaWisdomDeviation.Value = B_WISDOM.Deviation;
            nudBetaCharismaValue.Value = B_CHARISMA.Value;
            nudBetaCharismaWeight.Value = B_CHARISMA.Weight;
            nudBetaCharismaDeviation.Value = B_CHARISMA.Deviation;
            nudBetaArcaneValue.Value = B_ARCANE.Value;
            nudBetaArcaneWeight.Value = B_ARCANE.Weight;
            nudBetaArcaneDeviation.Value = B_ARCANE.Deviation;
            nudBetaDivineValue.Value = B_DIVINE.Value;
            nudBetaDivineWeight.Value = B_DIVINE.Weight;
            nudBetaDivineDeviation.Value = B_DIVINE.Deviation;
        }

        /// <summary>
        ///  OK Button... btnOK
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" &&
                txtParentOne.Text != "" &&
                txtParentTwo.Text != "")
            {
                GENERATION = (int)nudGeneration.Value;
                PARENTONE = txtParentOne.Text;
                PARENTTWO = txtParentTwo.Text;
                NAME = txtName.Text;
                AGE = (int)nudAge.Value;

                AssignGenes();
                A_HELIX = new Helix(A_RACE, A_STRENGTH, A_DEXTERITY, A_CONSTITUTION, A_INTELLIGENCE, A_WISDOM, A_CHARISMA, A_ARCANE, A_DIVINE);
                B_HELIX = new Helix(B_RACE, B_STRENGTH, B_DEXTERITY, B_CONSTITUTION, B_INTELLIGENCE, B_WISDOM, B_CHARISMA, B_ARCANE, B_DIVINE);
                _DNA = new DNA(A_HELIX, B_HELIX);
                ReturnCreature = new Creature(GENERATION, PARENTONE, PARENTTWO, _DNA, NAME, AGE);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                StringBuilder ErrorMessage = new StringBuilder();
                if (txtName.Text != "") ErrorMessage.Append("Please fill in Name or select Random.\n");
                if (txtParentOne.Text != "" || txtParentTwo.Text != "") ErrorMessage.Append("Please fill in Name or select Random.\n");
                    MessageBox.Show("Creature Editor: Error", ErrorMessage.ToString(), MessageBoxButtons.OK);
            }
        }

        private void AssignGenes()
        {
            A_RACE = new Gene((int)nudAlphaRaceValue.Value, (int)nudAlphaRaceWeight.Value, (int)nudAlphaRaceDeviation.Value);
            A_STRENGTH = new Gene((int)nudAlphaStrengthValue.Value, (int)nudAlphaStrengthWeight.Value, (int)nudAlphaStrengthDeviation.Value);
            A_DEXTERITY = new Gene((int)nudAlphaDexterityValue.Value, (int)nudAlphaDexterityWeight.Value, (int)nudAlphaDexterityDeviation.Value);
            A_CONSTITUTION = new Gene((int)nudAlphaConstitutionValue.Value, (int)nudAlphaConstitutionWeight.Value, (int)nudAlphaConstitutionDeviation.Value);
            A_INTELLIGENCE = new Gene((int)nudAlphaIntelligenceValue.Value, 
                (int)nudAlphaIntelligenceWeight.Value, (int)nudAlphaIntelligenceDeviation.Value);
            A_WISDOM = new Gene((int)nudAlphaWisdomValue.Value, (int)nudAlphaWisdomWeight.Value, (int)nudAlphaWisdomDeviation.Value);
            A_CHARISMA = new Gene((int)nudAlphaCharismaValue.Value, (int)nudAlphaCharismaWeight.Value, (int)nudAlphaCharismaDeviation.Value);
            A_ARCANE = new Gene((int)nudAlphaArcaneValue.Value, (int)nudAlphaCharismaWeight.Value, (int)nudAlphaCharismaDeviation.Value);
            A_DIVINE = new Gene((int)nudAlphaDivineValue.Value, (int)nudAlphaDivineWeight.Value, (int)nudAlphaDivineDeviation.Value);

            B_RACE = new Gene((int)nudBetaRaceValue.Value, (int)nudBetaRaceWeight.Value, (int)nudBetaRaceDeviation.Value);
            B_STRENGTH = new Gene((int)nudBetaStrengthValue.Value, 
                (int)nudBetaStrengthWeight.Value, (int)nudBetaStrengthDeviation.Value);
            B_DEXTERITY = new Gene((int)nudBetaDexterityValue.Value, (int)nudBetaDexterityWeight.Value, (int)nudBetaDexterityDeviation.Value);
            B_CONSTITUTION = new Gene((int)nudBetaConstitutionValue.Value, (int)nudBetaConstitutionWeight.Value, (int)nudBetaConstitutionDeviation.Value);
            B_INTELLIGENCE = new Gene((int)nudBetaIntelligenceValue.Value, (int)nudBetaIntelligenceWeight.Value, (int)nudBetaIntelligenceDeviation.Value);
            B_WISDOM = new Gene((int)nudBetaWisdomValue.Value, (int)nudBetaWisdomWeight.Value, (int)nudBetaWisdomDeviation.Value);
            B_CHARISMA = new Gene((int)nudBetaCharismaValue.Value, (int)nudBetaCharismaWeight.Value, (int)nudBetaCharismaDeviation.Value);
            B_ARCANE = new Gene((int)nudBetaArcaneValue.Value, (int)nudBetaArcaneWeight.Value, (int)nudBetaArcaneDeviation.Value);
            B_DIVINE = new Gene((int)nudBetaDivineValue.Value, (int)nudBetaDivineWeight.Value, (int)nudBetaDivineDeviation.Value);
        }

        /// <summary>
        /// CANCEL Button... btnCancel
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

        public Creature ReturnCreature { get; set; }
        string NAME;
        int AGE;
        int GENERATION;
        string PARENTONE;
        string PARENTTWO;
        public DNA _DNA;
        public Helix A_HELIX, B_HELIX;
        public Gene A_RACE, A_STRENGTH, A_DEXTERITY, A_CONSTITUTION, A_INTELLIGENCE, A_WISDOM, A_CHARISMA, A_ARCANE, A_DIVINE, B_RACE, B_STRENGTH, B_DEXTERITY, B_CONSTITUTION, B_INTELLIGENCE, B_WISDOM, B_CHARISMA, B_ARCANE, B_DIVINE;

        private void cboAlphaDivine_CheckedChanged(object sender, EventArgs e)
        {
            if (cboAlphaDivine.Checked)
            {
                A_DIVINE = new Gene();
                nudAlphaDivineValue.Value = A_DIVINE.Value;
                nudAlphaDivineWeight.Value = A_DIVINE.Weight;
                nudAlphaDivineDeviation.Value = A_DIVINE.Deviation;
                nudAlphaDivineValue.Enabled = true;
                nudAlphaDivineWeight.Enabled = true;
                nudAlphaDivineDeviation.Enabled = true;
            }
            else
            {
                nudAlphaDivineValue.Enabled = false;
                nudAlphaDivineWeight.Enabled = false;
                nudAlphaDivineDeviation.Enabled = false;
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
                nudAlphaArcaneValue.Enabled = true;
                nudAlphaArcaneWeight.Enabled = true;
                nudAlphaArcaneDeviation.Enabled = true;
            }
            else
            {
                nudAlphaArcaneValue.Enabled = false;
                nudAlphaArcaneWeight.Enabled = false;
                nudAlphaArcaneDeviation.Enabled = false;
            }
        }
        
        private void cboAlphaCharisma_CheckedChanged(object sender, EventArgs e)
        {
            if (cboAlphaCharisma.Checked)
            {
                A_CHARISMA = new Gene();
                nudAlphaCharismaValue.Value = A_CHARISMA.Value;
                nudAlphaCharismaWeight.Value = A_CHARISMA.Weight;
                nudAlphaCharismaDeviation.Value = A_CHARISMA.Deviation;
                nudAlphaCharismaValue.Enabled = true;
                nudAlphaCharismaWeight.Enabled = true;
                nudAlphaCharismaDeviation.Enabled = true;
            }
            else
            {
                nudAlphaCharismaValue.Enabled = false;
                nudAlphaCharismaWeight.Enabled = false;
                nudAlphaCharismaDeviation.Enabled = false;
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
                nudAlphaWisdomValue.Enabled = true;
                nudAlphaWisdomWeight.Enabled = true;
                nudAlphaWisdomDeviation.Enabled = true;
            }
            else
            {
                nudAlphaWisdomValue.Enabled = false;
                nudAlphaWisdomWeight.Enabled = false;
                nudAlphaWisdomDeviation.Enabled = false;
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
                nudAlphaIntelligenceValue.Enabled = true;
                nudAlphaIntelligenceWeight.Enabled = true;
                nudAlphaIntelligenceDeviation.Enabled = true;
            }
            else
            {
                nudAlphaIntelligenceValue.Enabled = false;
                nudAlphaIntelligenceWeight.Enabled = false;
                nudAlphaIntelligenceDeviation.Enabled = false;
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
                nudAlphaConstitutionValue.Enabled = true;
                nudAlphaConstitutionWeight.Enabled = true;
                nudAlphaConstitutionDeviation.Enabled = true;
            }
            else
            {
                nudAlphaConstitutionValue.Enabled = false;
                nudAlphaConstitutionWeight.Enabled = false;
                nudAlphaConstitutionDeviation.Enabled = false;
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
                nudAlphaDexterityValue.Enabled = true;
                nudAlphaDexterityWeight.Enabled = true;
                nudAlphaDexterityDeviation.Enabled = true;
            }
            else
            {
                nudAlphaDexterityValue.Enabled = false;
                nudAlphaDexterityWeight.Enabled = false;
                nudAlphaDexterityDeviation.Enabled = false;
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
                nudAlphaStrengthValue.Enabled = true;
                nudAlphaStrengthWeight.Enabled = true;
                nudAlphaStrengthDeviation.Enabled = true;
            }
            else
            {
                nudAlphaStrengthValue.Enabled = false;
                nudAlphaStrengthWeight.Enabled = false;
                nudAlphaStrengthDeviation.Enabled = false;
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
                nudAlphaRaceValue.Enabled = true;
                nudAlphaRaceWeight.Enabled = true;
                nudAlphaRaceDeviation.Enabled = true;
            }
            else
            {
                nudAlphaRaceValue.Enabled = false;
                nudAlphaRaceWeight.Enabled = false;
                nudAlphaRaceDeviation.Enabled = false;
            }
        }

        private void cboBetaDivine_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cboBetaDivine.Checked)
            {
                B_DIVINE = new Gene();
                nudBetaDivineValue.Value = B_DIVINE.Value;
                nudBetaDivineWeight.Value = B_DIVINE.Weight;
                nudBetaDivineDeviation.Value = B_DIVINE.Deviation;
                nudBetaDivineValue.Enabled = true;
                nudBetaDivineWeight.Enabled = true;
                nudBetaDivineDeviation.Enabled = true;
            }
            else
            {
                nudBetaDivineValue.Enabled = false;
                nudBetaDivineWeight.Enabled = false;
                nudBetaDivineDeviation.Enabled = false;
            }
        }

        private void cboBetaArcane_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cboBetaArcane.Checked)
            {
                B_ARCANE = new Gene();
                nudBetaArcaneValue.Value = B_ARCANE.Value;
                nudBetaArcaneWeight.Value = B_ARCANE.Weight;
                nudBetaArcaneDeviation.Value = B_ARCANE.Deviation;
                nudBetaArcaneValue.Enabled = true;
                nudBetaArcaneWeight.Enabled = true;
                nudBetaArcaneDeviation.Enabled = true;
            }
            else
            {
                nudBetaArcaneValue.Enabled = false;
                nudBetaArcaneWeight.Enabled = false;
                nudBetaArcaneDeviation.Enabled = false;
            }
        }

        private void cboBetaCharisma_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cboBetaCharisma.Checked)
            {
                B_CHARISMA = new Gene();
                nudBetaCharismaValue.Value = B_CHARISMA.Value;
                nudBetaCharismaWeight.Value = B_CHARISMA.Weight;
                nudBetaCharismaDeviation.Value = B_CHARISMA.Deviation;
                nudBetaCharismaValue.Enabled = true;
                nudBetaCharismaWeight.Enabled = true;
                nudBetaCharismaDeviation.Enabled = true;
            }
            else
            {
                nudBetaCharismaValue.Enabled = false;
                nudBetaCharismaWeight.Enabled = false;
                nudBetaCharismaDeviation.Enabled = false;
            }
        }

        private void cboBetaWisdom_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cboBetaWisdom.Checked)
            {
                B_WISDOM = new Gene();
                nudBetaWisdomValue.Value = B_WISDOM.Value;
                nudBetaWisdomWeight.Value = B_WISDOM.Weight;
                nudBetaWisdomDeviation.Value = B_WISDOM.Deviation;
                nudBetaWisdomValue.Enabled = true;
                nudBetaWisdomWeight.Enabled = true;
                nudBetaWisdomDeviation.Enabled = true;
            }
            else
            {
                nudBetaWisdomValue.Enabled = false;
                nudBetaWisdomWeight.Enabled = false;
                nudBetaWisdomDeviation.Enabled = false;
            }
        }

        private void cboBetaIntelligence_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cboBetaIntelligence.Checked)
            {
                B_INTELLIGENCE = new Gene();
                nudBetaIntelligenceValue.Value = B_INTELLIGENCE.Value;
                nudBetaIntelligenceWeight.Value = B_INTELLIGENCE.Weight;
                nudBetaIntelligenceDeviation.Value = B_INTELLIGENCE.Deviation;
                nudBetaIntelligenceValue.Enabled = true;
                nudBetaIntelligenceWeight.Enabled = true;
                nudBetaIntelligenceDeviation.Enabled = true;
            }
            else
            {
                nudBetaIntelligenceValue.Enabled = false;
                nudBetaIntelligenceWeight.Enabled = false;
                nudBetaIntelligenceDeviation.Enabled = false;
            }
        }

        private void cboBetaConstitution_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cboBetaConstitution.Checked)
            {
                B_CONSTITUTION = new Gene();
                nudBetaConstitutionValue.Value = B_CONSTITUTION.Value;
                nudBetaConstitutionWeight.Value = B_CONSTITUTION.Weight;
                nudBetaConstitutionDeviation.Value = B_CONSTITUTION.Deviation;
                nudBetaConstitutionValue.Enabled = true;
                nudBetaConstitutionWeight.Enabled = true;
                nudBetaConstitutionDeviation.Enabled = true;
            }
            else
            {
                nudBetaConstitutionValue.Enabled = false;
                nudBetaConstitutionWeight.Enabled = false;
                nudBetaConstitutionDeviation.Enabled = false;
            }
        }

        private void cboBetaDexterity_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cboBetaDexterity.Checked)
            {
                B_DEXTERITY = new Gene();
                nudBetaDexterityValue.Value = B_DEXTERITY.Value;
                nudBetaDexterityWeight.Value = B_DEXTERITY.Weight;
                nudBetaDexterityDeviation.Value = B_DEXTERITY.Deviation;
                nudBetaDexterityValue.Enabled = true;
                nudBetaDexterityWeight.Enabled = true;
                nudBetaDexterityDeviation.Enabled = true;
            }
            else
            {
                nudBetaDexterityValue.Enabled = false;
                nudBetaDexterityWeight.Enabled = false;
                nudBetaDexterityDeviation.Enabled = false;
            }
        }

        private void cboBetaStrength_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cboBetaStrength.Checked)
            {
                B_STRENGTH = new Gene();
                nudBetaStrengthValue.Value = B_STRENGTH.Value;
                nudBetaStrengthWeight.Value = B_STRENGTH.Weight;
                nudBetaStrengthDeviation.Value = B_STRENGTH.Deviation;
                nudBetaStrengthValue.Enabled = true;
                nudBetaStrengthWeight.Enabled = true;
                nudBetaStrengthDeviation.Enabled = true;
            }
            else
            {
                nudBetaStrengthValue.Enabled = false;
                nudBetaStrengthWeight.Enabled = false;
                nudBetaStrengthDeviation.Enabled = false;
            }
        }

        private void cboBetaRace_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cboBetaRace.Checked)
            {
                B_RACE = new Gene();
                nudBetaRaceValue.Value = B_RACE.Value;
                nudBetaRaceWeight.Value = B_RACE.Weight;
                nudBetaRaceDeviation.Value = B_RACE.Deviation;
                nudBetaRaceValue.Enabled = true;
                nudBetaRaceWeight.Enabled = true;
                nudBetaRaceDeviation.Enabled = true;
            }
            else
            {
                nudBetaRaceValue.Enabled = false;
                nudBetaRaceWeight.Enabled = false;
                nudBetaRaceDeviation.Enabled = false;
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