﻿using System;
using System.Windows.Forms;
using GeneticDLL;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

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
            RefreshPopulation();
            nudRandAmount.Maximum = creatureList.Count;
        }

        private Society society;
        private List<Creature> creatureList = new List<Creature>();
        int siOne = -1, siTwo = -1;
        string fileName;

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

        private void RefreshPopulation()
        {
            if (society != null)
            {
                lsvPopulation.Items.Clear();
                foreach (Creature c in creatureList)
                {
                    ListViewItem row = new ListViewItem(c.Name);
                    row.SubItems.Add(c.Generation.ToString());
                    lsvPopulation.Items.Add(row);
                }
                UpdatePopulationLabel();
            }
            else lblPopulation.Text = "No Society Opened.";
        }

        private void UpdatePopulationLabel()
        {
            lblPopulation.Text = String.Format("{0} of {1}: Population ({2}), Deceased ({3})",
                    society.Classification,
                    society.Name,
                    creatureList.Count,
                    (society.Graveyard.Count > 0 ? society.Graveyard.Count : 0));
        }

        private Creature GetRandomCreature()
        {
            return creatureList[ExtensionMethods.GetRandom(0, creatureList.Count - 1)];
        }

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

        private void btnRandMate_Click(object sender, EventArgs e)
        {
            if (society != null)
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
                nudRandAmount.Value = 1;
            }
        }

        private void nudRandAmount_ValueChanged(object sender, EventArgs e)
        {
            nudRandAmount.Maximum = creatureList.Count;
        }

        private void UpdateMateSelected()
        {
            if (siOne > -1 && siTwo > -1)
            {
                lblMateSelected.Text = string.Format("{0} and {1}", creatureList[siOne].Name, creatureList[siTwo].Name);
            }
            else if (siOne > -1 || siTwo > -1)
            {
                lblMateSelected.Text = string.Format("{0}, select one more", (siOne > siTwo ? creatureList[siOne].Name : creatureList[siTwo].Name));
            }
            else lblMateSelected.Text = "Select Two Creatures Above";
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Data File|*.dat";
            sfd.Title = "Save Society As...";
            sfd.ShowDialog();
            if (sfd.FileName != "")
            {
                FileStream fs = (FileStream)sfd.OpenFile();
                BinaryFormatter bf = new BinaryFormatter();
                try
                {
                    bf.Serialize(fs, society);
                    fileName = sfd.FileName;
                }
                catch (SerializationException se)
                {
                    MessageBox.Show(se.Message);
                }
                finally { fs.Close(); }
            }
        }

        private void closeSocietyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lsvPopulation.Items.Clear();
            creatureList.Clear();
            society = null;
            rtbDisplay.Clear();
            lblPopulation.Text = "No Society Opened.";
        }

        private void newSocietyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (society != null)
            {
                DialogResult saveCheck = MessageBox.Show(string.Format("Do you want to save {0} first?", society.Name), "Confirmation", MessageBoxButtons.YesNoCancel);
                if (saveCheck == DialogResult.Yes)
                {
                    saveAsToolStripMenuItem_Click(this, null);
                    closeSocietyToolStripMenuItem_Click(this, null);
                    society = new Society();
                    RefreshCreatureList();
                    RefreshPopulation();
                }
                else if (saveCheck == DialogResult.No)
                {
                    closeSocietyToolStripMenuItem_Click(this, null);
                    society = new Society();
                    RefreshCreatureList();
                    RefreshPopulation();
                }
                else { }
            }
            else
            {
                society = new Society();
                RefreshCreatureList();
                RefreshPopulation();
            }
        }

        private void openSocietyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Data Files|*.dat";
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;
            if (society != null)
            {
                DialogResult saveCheck = MessageBox.Show(string.Format("Do you want to save {0} first?", society.Name), "Confirmation", MessageBoxButtons.YesNoCancel);
                if (saveCheck == DialogResult.Yes)
                {
                    saveAsToolStripMenuItem_Click(this, null);
                }
                else if (saveCheck == DialogResult.No)
                {
                    
                }
                else { return; }
            }
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs;
                try
                {
                    if (ofd.FileName != null)
                    {
                        fileName = ofd.FileName;
                        fs = new FileStream(fileName, FileMode.Open);
                        BinaryFormatter bf = new BinaryFormatter();
                        society = null;
                        society = (Society)bf.Deserialize(fs);
                        fs.Close();
                        rtbDisplay.Clear();
                        RefreshCreatureList();
                        RefreshPopulation();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (society != null)
            {
                DialogResult saveCheck = MessageBox.Show(string.Format("Do you want to save {0} Before Exit?", society.Name), "Confirmation", MessageBoxButtons.YesNoCancel);
                if (saveCheck == DialogResult.Yes)
                {
                    saveAsToolStripMenuItem_Click(this, null);
                    Application.Exit();
                }
                else if (saveCheck == DialogResult.No)
                {
                    Application.Exit();
                }
                else { }
            }
        }

        private void changeSocietyNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new GeneticsDialog("Society Name Change", "Change name of " + society.Name))
            {
                var result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    society.Name = dialog.ReturnValue;
                    UpdatePopulationLabel();
                }
            }
        }

        private void changeSocietyClassifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new GeneticsDialog("Society Classifier Change", "Change name of " + society.Name + " from " + society.Classification + " to:"))
            {
                var result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    society.Classification = dialog.ReturnValue;
                    UpdatePopulationLabel();
                }
            }
        }

        private void editNewCreatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new EditCreatureDialog())
            {
                var result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    society.AddCreature(dialog.ReturnCreature);
                    RefreshCreatureList();
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileName == "" || fileName == null) fileName = @"Societies\" + society.Name + ".dat";
            string filePath = "Societies";
            bool exists = Directory.Exists(filePath);
            if (!exists) Directory.CreateDirectory(filePath);
            FileStream fs = new FileStream(fileName, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                bf.Serialize(fs, society);
            }
            catch (SerializationException se)
            {
                MessageBox.Show(se.Message);
            }
            finally { fs.Close(); }
        }
    }
}