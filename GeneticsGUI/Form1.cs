using System;
using System.Windows.Forms;
using GeneticDLL;
using System.Collections.Generic;

namespace GeneticsGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            society = new Society();
            society.GetCreatures(out creatureList);
            /// Add Sort options to cboSort. Name and Generation hard, rest responsive.
            cboSort.Items.AddRange(new string[] 
            {
                "Name",
                "Youngest",
                "Oldest",
                "Generation",
                "Deviation",
                "Race",
                "Strength",
                "Dexterity",
                "Constitution",
                "Intelligence",
                "Wisdom",
                "Charisma",
                "Arcane",
                "Divine"
            });
            /// Add Creatures to ListView and to Mate selection comboBoxes.
            RefreshPopulation();
            nudRandAmount.Maximum = creatureList.Count;
        }
        
        private Society society;
        private List<Creature> creatureList = new List<Creature>();
        int siOne = -1, siTwo = -1;
        
        private void UpdateDisplay(int i)
        {
            rtbDisplay.Clear();
            rtbDisplay.AppendText(creatureList[i].ToString());
        }
        private void RefreshCreatureList()
        {
            creatureList.Clear();
            society.GetCreatures(out creatureList);
        }
        /// <summary>
        /// Refreshes the ListView anytime the population grows or is sorted.
        /// </summary>
        private void RefreshPopulation()
        {
            lsvPopulation.Items.Clear();
            foreach (Creature c in creatureList)
            {
                ListViewItem row = new ListViewItem(c.Name);
                row.SubItems.Add(c.Generation.ToString());
                lsvPopulation.Items.Add(row);
            }
            lblPopulation.Text = String.Format("{0} of {1}: Population ({2})", 
                society.Classification,
                society.Name,
                creatureList.Count);
        }
        /// <summary>
        /// Selects a creature at random from _population.Populace
        /// </summary>
        /// <returns>Randomly selected Creature from population</returns>
        private Creature GetRandomCreature()
        {
            return creatureList[ExtensionMethods.GetRandom(0, creatureList.Count - 1)];
        }
        
        /// <summary>
        /// Sorts the population by selected option in cboSort and refreshes
        /// the ListView utilizing RefreshPopulation() and mating options via
        /// RefreshMates(), so that index lines up.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSort_Click(object sender, EventArgs e)
        {
            SortCreatureList(cboSort.Text);
            siOne = siTwo = -1;
            UpdateMateSelected();
        }

        private void SortCreatureList(string sortKey)
        {
            if (sortKey != "")
            {
                switch (sortKey)
                {
                    case "Name":
                        creatureList.Sort((x, y) => x.Name.CompareTo(y.Name));
                        break;
                    case "Youngest":
                        creatureList.Sort((x, y) => x.Age.CompareTo(y.Age));
                        break;
                    case "Oldest":
                        creatureList.Sort((x, y) => -1 * x.Age.CompareTo(y.Age));
                        break;
                    case "Generation":
                        creatureList.Sort((x, y) => -1 * x.Genetics.Race.CompareTo(y.Genetics.Race));
                        break;
                    case "Deviation":
                        creatureList.Sort((x, y) => -1 * x.Genetics.DeviationIndex.CompareTo(y.Genetics.DeviationIndex));
                        break;
                    case "Race":
                        creatureList.Sort((x, y) => -1 * x.Genetics.Race.CompareTo(y.Genetics.Race));
                        break;
                    case "Strength":
                        creatureList.Sort((x, y) => -1 * x.Genetics.Strength.CompareTo(y.Genetics.Strength));
                        break;
                    case "Dexterity":
                        creatureList.Sort((x, y) => -1 * x.Genetics.Dexterity.CompareTo(y.Genetics.Dexterity));
                        break;
                    case "Constitution":
                        creatureList.Sort((x, y) => -1 * x.Genetics.Constitution.CompareTo(y.Genetics.Constitution));
                        break;
                    case "Intelligence":
                        creatureList.Sort((x, y) => -1 * x.Genetics.Intelligence.CompareTo(y.Genetics.Intelligence));
                        break;
                    case "Wisdom":
                        creatureList.Sort((x, y) => -1 * x.Genetics.Wisdom.CompareTo(y.Genetics.Wisdom));
                        break;
                    case "Charisma":
                        creatureList.Sort((x, y) => -1 * x.Genetics.Charisma.CompareTo(y.Genetics.Charisma));
                        break;
                    case "Arcane":
                        creatureList.Sort((x, y) => -1 * x.Genetics.Arcane.CompareTo(y.Genetics.Arcane));
                        break;
                    case "Divine":
                        creatureList.Sort((x, y) => -1 * x.Genetics.Divine.CompareTo(y.Genetics.Divine));
                        break;
                    default:
                        creatureList.Sort((x, y) => x.Name.CompareTo(y.Name));
                        break;
                }
                RefreshPopulation();
            }
        }
        /// <summary>
        /// Mates both selected mates!
        /// Refreshes both listview and mates comboBoxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMate_Click(object sender, EventArgs e)
        {
            if (siOne > -1 && siTwo > -1 && siOne != siTwo)
            {
                Creature offspring = new Creature(creatureList[siOne], creatureList[siTwo]);
                society.AdvanceAge(1);
                society.AddCreature(offspring);
                RefreshCreatureList();
                SortCreatureList("Youngest");
                RefreshPopulation();
            }
            siOne = siTwo = -1;
            UpdateMateSelected();
        }
        /// <summary>
        /// When a creature is selected, display its stats.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lsvPopulation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvPopulation.SelectedIndices.Count != 0)
            {
                siTwo = siOne;
                siOne = lsvPopulation.SelectedIndices[0];
                UpdateDisplay(lsvPopulation.SelectedItems[lsvPopulation.SelectedItems.Count - 1].Index);
                lblDisplay.Text = String.Format("Display: {0}", creatureList[siOne].Name);
                UpdateMateSelected();
            }
        }
        /// <summary>
        /// Randomly Mate two creatures from population.
        /// nudRandAmount will determine how many to mate.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRandMate_Click(object sender, EventArgs e)
        {
            List<Creature> temp = new List<Creature>();
            for (int i = 0; i < nudRandAmount.Value; i++)
            {
                while (temp.Count < i + 1)
                {
                    temp.Add(new Creature(GetRandomCreature(), GetRandomCreature()));
                }
            }
            society.AdvanceAge(1);
            society.AddCreature(temp);
            RefreshCreatureList();
            SortCreatureList("Youngest");
            RefreshPopulation();
            UpdateMateSelected();
        }
                
        private void nudRandAmount_ValueChanged(object sender, EventArgs e)
        {
            nudRandAmount.Maximum = creatureList.Count;
        }

        private void UpdateMateSelected()
        {
            if (siOne > -1 && siTwo > -1)
            {
                lblMateSelected.Text = String.Format("Selected: {0} and {1}", creatureList[siOne].Name, creatureList[siTwo].Name);
            }
            else if (siOne > -1 || siTwo > -1)
            {
                lblMateSelected.Text = String.Format("Selected: {0}, select one more", (siOne > siTwo ? creatureList[siOne].Name : creatureList[siTwo].Name));
            }
            else lblMateSelected.Text = "Select Two Creatures Above";
        }
    }
}