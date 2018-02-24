﻿using System;
using System.Windows.Forms;
using GeneticDLL;

namespace GeneticsGUI
{
    public partial class Form1 : Form
    {
        #region LOAD
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /// Will be replaced to detect if saved population exists
            /// after adding save options.
            _population = new Population();
            /// Add Sort options to cboSort. Name and Generation hard, rest responsive.
            cboSort.Items.AddRange(new string[] { "Name", "Generation" });
            foreach (string gk in _population.GeneKeys)
            {
                cboSort.Items.Add(gk);
            }
            /// Add Creatures to ListView and to Mate selection comboBoxes.
            foreach (Creature c in _population.Populace)
            {
                cboMateOne.Items.Add(c.Name);
                cboMateTwo.Items.Add(c.Name);
                ListViewItem row = new ListViewItem(c.Name);
                row.SubItems.Add(c.Generation.ToString());
                lsvPopulation.Items.Add(row);
            }
        }
        #endregion LOAD
        #region FIELDS
        private Population _population;
        #endregion FIELDS
        #region METHODS
        private void UpdateDisplay(int i)
        {
            rtbDisplay.Clear();
            rtbDisplay.AppendText(_population.Populace[i].ToString());
        }
        /// <summary>
        /// Refreshes the ListView anytime the population grows or is sorted.
        /// </summary>
        private void RefreshPopulation()
        {
            lsvPopulation.Items.Clear();
            foreach (Creature c in _population.Populace)
            {
                ListViewItem row = new ListViewItem(c.Name);
                row.SubItems.Add(c.Generation.ToString());
                lsvPopulation.Items.Add(row);
            }
        }
        /// <summary>
        /// Refreshes both Mate option comboBoxes when population grows.
        /// </summary>
        private void RefreshMates()
        {
            cboMateOne.Items.Clear();
            cboMateTwo.Items.Clear();
            foreach (Creature c in _population.Populace)
            {
                cboMateOne.Items.Add(c.Name);
                cboMateTwo.Items.Add(c.Name);
            }
            cboMateOne.SelectedIndex = 0;
            cboMateTwo.SelectedIndex = 1;
        }
        #endregion METHODS
        #region BUTTONS
        /// <summary>
        /// Sorts the population by selected option in cboSort and refreshes
        /// the ListView utilizing RefreshPopulation() and mating options via
        /// RefreshMates(), so that index lines up.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSort_Click(object sender, EventArgs e)
        {
            string selection = cboSort.Text;
            if (selection != "")
            {
                switch (selection)
                {
                    case "Name":
                        _population.SortByName();
                        break;
                    case "Generation":
                        _population.SortByGeneration();
                        break;
                    default:
                        _population.SortByGene(selection);
                        break;
                }
                RefreshPopulation();
                RefreshMates();
                cboSort.SelectedIndex = 0;
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
            int mOne = cboMateOne.SelectedIndex;
            int mTwo = cboMateTwo.SelectedIndex;
            if (mOne > -1 && mTwo > -1)
            {
                Creature offspring = new Creature(_population.Populace[mOne], _population.Populace[mTwo]);
                _population.Add(offspring);
                RefreshPopulation();
                RefreshMates();
            }
        }
        /// <summary>
        /// When a creature is selected, display its stats.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lsvPopulation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvPopulation.SelectedIndices.Count != 0)
                UpdateDisplay(lsvPopulation.SelectedItems[0].Index);
        }
        #endregion BUTTONS


    }
}