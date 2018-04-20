using System;
using System.Windows.Forms;
using GeneticDLL;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Drawing;
using System.Drawing.Printing;

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
            nudRandAmount.Maximum = creatureList.Count / 2;
        }

        private Society society;
        private List<Creature> creatureList = new List<Creature>();
        int siOne = -1, siTwo = -1;
        string fileName;
        string linesToPrint;

        private void UpdateDisplay(int i)
        {
            rtbDisplay.Clear();
            rtbDisplay.AppendText(creatureList[i].ToString());
        }
        private void UpdateDisplay(string input)
        {
            rtbDisplay.Clear();
            rtbDisplay.AppendText(input);
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
            lblPopulation.Text = String.Format("{0} of {1}: Population ({2}), Deceased ({3}). Year: {4}",
                    society.Classification,
                    society.Name,
                    creatureList.Count,
                    (society.Graveyard.Count > 0 ? society.Graveyard.Count : 0),
                    society.Year);
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
                        creatureList.Sort((x, y) => -1 * x.Generation.CompareTo(y.Generation));
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
            nudRandAmount.Maximum = creatureList.Count / 2;
            if (nudRandAmount.Maximum < 2) nudRandAmount.Maximum = 2;
        }

        private void UpdateMateSelected()
        {
            if (lsvPopulation.Items.Count > 0)
            {
                if (siOne > -1 && siTwo > -1)
                {
                    lblMateSelected.Text = string.Format("{0} and {1}", creatureList[siOne].Name, creatureList[siTwo].Name);
                }
                else if (siOne > -1 || siTwo > -1)
                {
                    lblMateSelected.Text = string.Format("{0}, select one more", (siOne > siTwo ? creatureList[siOne].Name : creatureList[siTwo].Name));
                }
                else lblMateSelected.Text = "Select two creatures above.";
            }
            else lblMateSelected.Text = "Select two creatures above.";
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
                    RefreshPopulation();
                }
            }
        }

        private void editCreatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (siOne > -1)
                using (var dialog = new EditCreatureDialog(creatureList[siOne]))
                {
                    var result = dialog.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        society.AddCreature(dialog.ReturnCreature);
                        RefreshCreatureList();
                        RefreshPopulation();
                    }
                }
            else MessageBox.Show("Please select a creature to edit", "Creature Editor", MessageBoxButtons.OK);
        }

        private void removeCreatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (siOne > -1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete " + creatureList[siOne].Name + " ? ", "Creature Deletion", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    society.RemoveCreature(creatureList[siOne]);
                    RefreshCreatureList();
                    RefreshPopulation();
                }
            }
            else MessageBox.Show("Please select a creature to remove", "Creature Deletion", MessageBoxButtons.OK);
        }

        private void advanceAgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int years = ExtensionMethods.GetRandom(1, 100);
            int dead = society.Graveyard.Count;
            society.AdvanceAge(years);
            RefreshCreatureList();
            RefreshPopulation();
            string MESSAGE = string.Format("As {0} years pass, {1} creature{2}.",
                years,
                society.Graveyard.Count - dead,
                (society.Graveyard.Count - dead == 1 ? " died" : "s have died"));
            MessageBox.Show(MESSAGE, "Time Passed: " + years + " years", MessageBoxButtons.OK);
        }

        private void visitGraveyardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder cemetary = new StringBuilder();
            lblDisplay.Text = string.Format("Cemetary of {0}", society.Name);
            List<string> graveyard = new List<string>();
            society.GetGraveyard(out graveyard);
            graveyard.Sort((x, y) => x.CompareTo(y));
            foreach (string s in graveyard)
            {
                cemetary.Append(s + "\n");
            }
            UpdateDisplay(cemetary.ToString());
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

        private void cboSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboSort.Enabled = false;
            btnSort.PerformClick();
            cboSort.Enabled = true;
        }

        private void nudRandAmount_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnRandMate.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog pdl = new PrintDialog();
            //linesToPrint = string.Format("{0}\nInhabitants:\n{1}\nCemetary:\n{2}",
            //    society.societyPrintString(),
            //    printCreatures(),
            //    printGraveyard());
            pdl.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                linesToPrint = string.Format("{0}\nInhabitants:\n{1}\nCemetary:\n{2}", society.societyPrintString(), printCreatures(), printGraveyard());
                printDocument1.Print();
            }
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font printFont = new Font("Times New Romans", 12, FontStyle.Regular);
            float LinesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            string line;
            StringReader sr = new StringReader(linesToPrint);
            LinesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);
            line = sr.ReadLine();
            while (count < LinesPerPage && line != null)
            {
                yPos = topMargin + (count * printFont.GetHeight(e.Graphics));
                e.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
                count++;
                if (sr.ReadLine() == null) line = sr.ReadLine();
                else line = null;
            }
            if (line != null) e.HasMorePages = true;
            else e.HasMorePages = false;
            //linesToPrint = string.Format("{0}\nInhabitants:\n{1}\nCemetary:\n{2}", society.societyPrintString(), printCreatures(), printGraveyard());
            //e.Graphics.DrawString(linesToPrint, printFont, Brushes.Black, leftMargin, yPos);
            
        }


        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            linesToPrint = string.Format("{0}\n\nInhabitants:\n{1}\nCemetary:\n{2}", society.societyPrintString(), printCreatures(), printGraveyard());
            printPreviewDialog1.ShowDialog();
        }

        private string printCreatures()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Creature c in creatureList)
            {
                sb.Append(c.PrintString() + "\n");
            }

            return sb.ToString();
        }

        private string printGraveyard()
        {
            StringBuilder sb = new StringBuilder();
            List<string> graveyard = new List<string>();
            society.GetGraveyard(out graveyard);
            graveyard.Sort((x, y) => x.CompareTo(y));
            foreach (string s in graveyard)
            {
                sb.Append(s + "\n");
            }
            return sb.ToString();
        }

        private void basicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new HelpDialog("Basics"))
            {
                var result = dialog.ShowDialog();
                if (result != DialogResult.OK)
                {
                    dialog.Close();
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new HelpDialog("About"))
            {
                var result = dialog.ShowDialog();
                if (result != DialogResult.OK)
                {
                    dialog.Close();
                }         
            }
        }

        private void advancedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new HelpDialog("Advanced"))
            {
                var result = dialog.ShowDialog();
                if (result != DialogResult.OK)
                {
                    dialog.Close();
                }
            }
        }

        private void rtbDisplay_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}